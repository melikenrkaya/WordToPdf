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

