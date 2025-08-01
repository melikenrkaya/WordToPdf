<h1 align="center">📄✨ Word to PDF & 🎥 Video Downloader API</h1>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-purple?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/Language-C%23-blue?style=for-the-badge&logo=csharp" />
  <img src="https://img.shields.io/badge/License-MIT-green?style=for-the-badge" />
  <img src="https://img.shields.io/github/stars/melikenrkaya/WordToPdf-And-YoutubeDownloadVideo?style=for-the-badge" />
</p>

---

## ✨ Proje Hakkında

Bu proje **.NET 8 Web API** kullanılarak geliştirilmiş bir **Word → PDF dönüştürücü** ve **Video indirme** servisidir.  
Amacı hem **belgeleri PDF'e çevirmek**, hem de **YouTube / desteklenen diğer platformlardan video indirmek** isteyenlere kolay bir REST API sunmaktır.

---

## 🚀 Özellikler

✅ **Word → PDF Dönüştürme** (Aspose.Words ile yüksek kaliteli çıktı)  
✅ **YouTube dahil yüzlerce siteden video indirme** (`yt-dlp`)  
✅ **720p’ye kadar hızlı video indirme** (paralel indirme)  
✅ **FFmpeg ile H.264 + AAC formatında uyumlu çıktı**  
✅ **Swagger UI ile test edilebilir JSON API**  

---

## 📌 API Endpoint’leri

### 1️⃣ Word → PDF
```http
POST /Convert/WordToPdf

Form-Data:

file → Word dosyası (.docx, .doc)

Dönüş: PDF dosyası yolu

2️⃣ Video İndir
POST /Convert/DownloadVideo

Body (JSON):
{
  "url": "https://www.youtube.com/watch?v=VIDEO_ID"
}
Dönüş (JSON):
{
  "message": "Video başarıyla indirildi ve uyumlu MP4 formatına dönüştürüldü",
  "filePath": "C:\\path\\to\\Downloads\\video.mp4",
  "sizeMB": 123.45
}
🛠️ Kurulum
# 1️⃣ Projeyi klonla
git clone https://github.com/KULLANICI_ADI/WordToPdf-And-YoutubeDownloadVideo.git
cd WordToPdf-And-YoutubeDownloadVideo

# 2️⃣ Gerekli bağımlılıkları yükle
# - Aspose.Words
# - yt-dlp.exe ve ffmpeg.exe dosyalarını proje köküne koy
# - Properties → Copy to Output Directory → Copy always

# 3️⃣ Çalıştır
dotnet run

Tarayıcıda: [http://localhost:5116/index.html]

📂 Klasör Yapısı
📁 Downloads/       → İndirilen videolar
📁 Controllers/     → API controller dosyaları
📁 Services/        → Servis katmanı
📁 Properties/      → Proje ayarları

📸 Uygulamanın Ekran Görüntüsü

<img width="946" height="866" alt="D2" src="https://github.com/user-attachments/assets/f6230b12-ff03-480f-a5c6-bc52795010a2" />
<img width="553" height="973" alt="d1" src="https://github.com/user-attachments/assets/3e2ca21a-ff99-4b5c-9af8-33af35c6ea3f" />
























