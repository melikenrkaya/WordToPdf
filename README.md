# 📂 Document & Video Converter API

Bu proje; .NET 8 tabanlı, hem **Word → PDF** dönüştürme hem de **video indirme / format dönüştürme** işlemleri yapabilen bir Web API içerir.

---

## 🚀 Özellikler

### 📄 **Word → PDF**
- **LibreOffice ile** dönüştürme (Office gerektirmez)
- **Aspose.Words ile** dönüştürme (yüksek doğruluk)

### 🎥 **Video İndirme**
- **yt-dlp** ile YouTube ve desteklenen diğer platformlardan video indirme
- **ffmpeg** ile video uyumluluk dönüştürme

### 🎵 **MP4 → MP3 Dönüştürme**
- MP4 içinden ses çıkarma
- Yüksek kaliteli MP3 kaydı

---

## 🛠 Gerekli Bağımlılıklar

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [LibreOffice](https://www.libreoffice.org/download/download/) *(LibreOffice ile PDF dönüştürme için)*
- [Aspose.Words](https://releases.aspose.com/words/net/) *(NuGet ile eklenebilir)*
- [yt-dlp](https://github.com/yt-dlp/yt-dlp/releases)
- [ffmpeg](https://ffmpeg.org/download.html)

> **Not:** `yt-dlp.exe` ve `ffmpeg.exe` dosyalarını proje ana klasörüne ekleyin.  
> Visual Studio'da **Copy to Output Directory → Copy always** ayarını yapın.

---

## 📂 API Endpoint'leri

### 1️⃣ **Word → PDF (LibreOffice ile)**
**POST**
