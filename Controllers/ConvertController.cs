
using Aspose.Words;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace document.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConvertController : ControllerBase
    {
        [HttpPost("Word-To-Pdf-With-LibreOffice")]
        public async Task<IActionResult> WordToPdfLibreOffice(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Dosya yüklenmedi");

            var uploads = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
            if (!Directory.Exists(uploads))
                Directory.CreateDirectory(uploads);

            var wordPath = Path.Combine(uploads, file.FileName);
            using (var stream = new FileStream(wordPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var pdfPath = Path.Combine(uploads, Path.GetFileNameWithoutExtension(file.FileName) + ".pdf");

            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = @"C:\Program Files\LibreOffice\program\soffice.exe";
            process.StartInfo.Arguments = $"--headless --convert-to pdf \"{wordPath}\" --outdir \"{uploads}\"";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            process.WaitForExit();

            if (!System.IO.File.Exists(pdfPath))
                return StatusCode(500, "PDF dönüştürme başarısız");

            var pdfBytes = await System.IO.File.ReadAllBytesAsync(pdfPath);
            return File(pdfBytes, "application/pdf", Path.GetFileName(pdfPath));
        }


        [HttpPost("Word-To-Pdf-With-Aspos")]
        public async Task<IActionResult> WordToPdfAspos(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Dosya yüklenmedi");

            var uploads = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
            if (!Directory.Exists(uploads))
                Directory.CreateDirectory(uploads);

            var wordPath = Path.Combine(uploads, file.FileName);
            using (var stream = new FileStream(wordPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var pdfPath = Path.Combine(uploads, Path.GetFileNameWithoutExtension(file.FileName) + ".pdf");
            try
            {
                var doc = new Document(wordPath);
                doc.Save(pdfPath, SaveFormat.Pdf);

                var pdfBytes = await System.IO.File.ReadAllBytesAsync(pdfPath);
                return File(pdfBytes, "application/pdf", Path.GetFileName(pdfPath));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Hata: {ex.Message}");
            }
        }

        [HttpPost("DownloadVideo")]
        public IActionResult DownloadVideo([FromBody] DownloadRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Url))
                return BadRequest("Video URL gerekli");

            try
            {
                // Çalışma klasörünü loglamak faydalı
                string currentDir = Directory.GetCurrentDirectory();

                // yt-dlp.exe yolu
                string ytDlpPath = Path.Combine(currentDir, "yt-dlp.exe");
                if (!System.IO.File.Exists(ytDlpPath))
                    return StatusCode(500, $"yt-dlp.exe bulunamadı!\nBeklenen konum: {ytDlpPath}\nLütfen dosyayı buraya ekleyin ve 'Copy to Output Directory: Copy always' yapın.");

                // ffmpeg.exe yolu
                string ffmpegPath = Path.Combine(currentDir, "ffmpeg.exe");
                if (!System.IO.File.Exists(ffmpegPath))
                    return StatusCode(500, $"ffmpeg.exe bulunamadı!\nBeklenen konum: {ffmpegPath}\nLütfen dosyayı buraya ekleyin ve 'Copy to Output Directory: Copy always' yapın.");

                // İndirilecek klasör
                string outputFolder = Path.Combine(currentDir, "Downloads");
                Directory.CreateDirectory(outputFolder);

                // 1️⃣ Videoyu indir
                string arguments =
                    $"--merge-output-format mp4 --concurrent-fragments 8 -f \"bv[height<=720]+ba\" -o \"{outputFolder}/%(title)s.%(ext)s\" \"{request.Url}\"";

                var ytDlpLog = RunProcess(ytDlpPath, arguments);

                // 2️⃣ En son indirilen MP4 dosyasını bul
                var downloadedFile = Directory.GetFiles(outputFolder, "*.mp4")
                                              .OrderByDescending(f => new FileInfo(f).CreationTime)
                                              .FirstOrDefault();

                if (string.IsNullOrWhiteSpace(downloadedFile) || !System.IO.File.Exists(downloadedFile))
                    return StatusCode(500, "İndirme başarısız veya MP4 dosyası bulunamadı");

                // 3️⃣ FFmpeg ile uyumlu MP4 oluştur (aynı dosya üzerine yaz)
                string ffmpegArgs =
                    $"-i \"{downloadedFile}\" -c:v libx264 -preset veryfast -crf 23 -c:a aac -b:a 192k \"{downloadedFile}\" -y";

                var ffmpegLog = RunProcess(ffmpegPath, ffmpegArgs);

                // 4️⃣ JSON cevabı
                return Ok(new
                {
                    Message = "Video başarıyla indirildi ve uyumlu MP4 formatına dönüştürüldü",
                    FilePath = downloadedFile,
                    FileName = Path.GetFileName(downloadedFile),
                    SizeMB = Math.Round(new FileInfo(downloadedFile).Length / 1024f / 1024f, 2),
                    CurrentDir = currentDir,
                    YtDlpLog = ytDlpLog,
                    FfmpegLog = ffmpegLog
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Hata: {ex.Message}");
            }
        }

        private string RunProcess(string fileName, string arguments)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Çalıştırılacak dosya yolu boş olamaz.");

            if (!System.IO.File.Exists(fileName))
                throw new FileNotFoundException($"Çalıştırılacak dosya bulunamadı: {fileName}");

            var psi = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new Process())
            {
                process.StartInfo = psi;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                return output + "\n" + error;
            }
        }


    }

    public class DownloadRequest
    {
        public string Url { get; set; }
    }
}


