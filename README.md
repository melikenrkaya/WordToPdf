Tamam 👍
O zaman senin bu son eklediğin **MP4 → MP3 dönüştürme** endpoint’ini de içerecek şekilde
mevcut projen için **güncel bir README.md** dosyasını baştan ve düzenli olarak yazayım.

---

## 📌 README.md

```markdown
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
```

/api/convert/word-to-pdf-libreoffice

```
Form-data:
- `file`: `.docx` dosyası

Dönüş: PDF dosyası

---

### 2️⃣ **Word → PDF (Aspose ile)**
**POST**
```

/api/convert/word-to-pdf-aspose

```
Form-data:
- `file`: `.docx` dosyası

Dönüş: PDF dosyası

---

### 3️⃣ **Video İndirme (yt-dlp + ffmpeg)**
**POST**
```

/api/convert/download-video

````
JSON:
```json
{
  "url": "https://www.youtube.com/watch?v=xxxxxxxx"
}
````

Dönüş:

```json
{
  "Message": "Video başarıyla indirildi ve uyumlu hale getirildi",
  "FilePath": "C:\\...\\Downloads\\video.mp4",
  "FileName": "video.mp4",
  "SizeMB": 15.2
}
```

---

### 4️⃣ **MP4 → MP3 Dönüştürme**

**POST**

```
/api/convert/mp4-to-mp3
```

JSON:

```json
{
  "filePath": "C:\\Users\\User\\Downloads\\video.mp4"
}
```

Dönüş:

```json
{
  "Message": "MP4 başarıyla MP3'e dönüştürüldü",
  "Mp3Path": "C:\\Users\\User\\Downloads\\video.mp3",
  "FileName": "video.mp3",
  "SizeMB": 5.3
}
```

---

## ⚙️ Çalıştırma

1. Bağımlılıkları yükleyin (LibreOffice, ffmpeg, yt-dlp)
2. Bu repo'yu indirin
3. Visual Studio'da açın
4. `yt-dlp.exe` ve `ffmpeg.exe` dosyalarını proje ana klasörüne ekleyin
5. Terminalde çalıştırın:

```bash
dotnet run
```

6. Tarayıcı / Postman ile endpoint'leri test edin

---

## 📌 Notlar

* LibreOffice yolu varsayılan olarak `C:\Program Files\LibreOffice\program\soffice.exe` olarak ayarlanmıştır.
  Farklı ise kodda güncelleyin.
* Aspose.Words ücretlidir, deneme sürümünde çıktı dosyasında watermark olabilir.
* Video indirme ve dönüştürme işlemleri `Downloads` klasörüne kaydedilir.
* MP4 → MP3 dönüştürmede dosya yolu JSON ile verilmelidir.

---

```

---

Bu README’yi proje köküne **README.md** olarak koyarsan GitHub’da ve editörde düzenli görünecek.

---

Eğer istersen ben sana **bu API’nin Postman koleksiyonunu** da hazırlayabilirim,  
tek tıklama ile tüm endpoint’leri test edebilirsin.  

Onu da yapayım mı?
```
