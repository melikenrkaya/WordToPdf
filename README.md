📄✨ Word to PDF & 🎥 YouTube Video Downloader
C# .NET 8 Web API ile hazırlanmış, hem Word belgelerini PDF formatına dönüştüren hem de YouTube/desteklenen diğer platformlardan video indiren güçlü bir API.

🚀 Özellikler
✅ Word → PDF Dönüştürme

Microsoft Word dosyalarını (.docx, .doc) hızlıca PDF’e çevirir.

Aspose.Words kütüphanesi ile yüksek kaliteli çıktı.

✅ YouTube & Video İndirme

yt-dlp ile YouTube dahil yüzlerce siteden video indirebilme.

İndirilen videoları FFmpeg ile H.264 + AAC formatında her oynatıcıda çalışacak şekilde encode etme.

720p kalite sınırı + paralel indirme ile hızlı sonuç.

✅ JSON API Desteği

Swagger UI ile kolay test edilebilir.

Basit JSON istekleriyle dosya dönüştürme ve indirme.

✅ Esnek Yapı

Downloads klasörüne kaydetme.

İndirilen dosya boyutunu JSON çıktısında gösterme.

Tüm loglar (yt-dlp & ffmpeg) API yanıtında.

🛠️ Kullanılan Teknolojiler
.NET 8 Web API

Aspose.Words – Word → PDF dönüştürme

yt-dlp – Video indirme motoru

FFmpeg – Video & ses encode / dönüştürme

Swagger – API dokümantasyonu ve test arayüzü

📂 API Endpoint’leri
📄 Word → PDF
http
Kopyala
Düzenle
POST /Convert/WordToPdf
Body (Form-Data):

file → Word dosyası (.docx, .doc)

📌 Dönüş: PDF dosya yolu

🎥 Video İndir
http
Kopyala
Düzenle
POST /Convert/DownloadVideo
Body (JSON):

{
  "url": "https://www.youtube.com/watch?v=VIDEO_ID"
}
📌 Dönüş:

{
  "message": "Video başarıyla indirildi ve uyumlu MP4 formatına dönüştürüldü",
  "filePath": "C:\\path\\to\\Downloads\\video.mp4",
  "sizeMB": 123.45
}
📦 Kurulum
1️⃣ Projeyi klonla

git clone https://github.com/KULLANICI_ADI/WordToPdf-And-YoutubeDownloadVideo.git
cd WordToPdf-And-YoutubeDownloadVideo
2️⃣ Gerekli bağımlılıkları ekle

Aspose.Words

yt-dlp.exe ve ffmpeg.exe dosyalarını proje köküne koy ve
Properties → Copy to Output Directory → Copy always yap.

3️⃣ Çalıştır

dotnet run
Tarayıcıda: http://localhost:5000/swagger

📸 Ekran Görüntüleri
Word → PDF	Video İndirme

⚠️ Notlar
GitHub’a yüklerken büyük dosyaları (*.mp4, *.exe) .gitignore ile hariç tut.

Video indirme hızı internet bağlantına ve seçilen kaliteye bağlıdır.

💡 Gelecek Geliştirmeler
 Çoklu dosya dönüştürme desteği

 İndirilen videolar için thumbnail oluşturma

 Arka planda indirme (BackgroundService)

🧑‍💻 Katkıda Bulunma
Pull request’ler her zaman açıktır.
Daha büyük değişiklikler için önce tartışma başlatmak adına bir issue açın.

📜 Lisans
MIT License – Özgürce kullanın, geliştirin, paylaşın.
