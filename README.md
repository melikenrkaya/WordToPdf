Tamam 👍 senin istediğin format **teknoloji ikonları, klasör yapısı, kurulum adımları, proje açıklaması** gibi düzenli bir şablon.
Aynı mantığı **WordToPdf & Video Downloader** projen için uyarlayıp sana final `README.md`’yi hazırlayacağım.

---

````markdown
# 📄 Word to PDF & 🎥 Video Downloader API

Bu proje, **Word belgelerini PDF formatına dönüştüren** ve **YouTube/desteklenen platformlardan video indiren** bir **ASP.NET Core Web API** uygulamasıdır.  
Videolar `yt-dlp` ile indirilir, **FFmpeg** ile H.264 + AAC formatında encode edilerek **her oynatıcıda sorunsuz çalışır**.

---

## 🔧 Kullanılan Teknolojiler
- **ASP.NET Core Web API**
- **Swagger UI** (API dokümantasyonu ve test arayüzü)
- **Aspose.Words** (Word → PDF dönüşümü)
- **yt-dlp** (Video indirme aracı)
- **FFmpeg** (Video/ses encode)
- **C#**

---

## 📁 Katmanlar ve Klasörler
📦 **WordToPdf-And-YoutubeDownloadVideo**  
 ┣ 📂**Controllers** → API controller dosyaları  
 ┣ 📂**Downloads** → İndirilen videolar  
 ┣ 📂**Properties** → Proje ayarları  
 ┣ **appsettings.json** → Config dosyası  
 ┣ **Program.cs** → Uygulama giriş noktası  
 ┗ **WordToPdf.sln** → Çözüm dosyası  

---

## ⚙️ Kurulum

### 1️⃣ Projeyi Klonlayın
```bash
git clone https://github.com/KULLANICI_ADI/WordToPdf-And-YoutubeDownloadVideo.git
cd WordToPdf-And-YoutubeDownloadVideo
````

### 2️⃣ Gerekli Bağımlılıkları Yükleyin

* **Aspose.Words** (NuGet üzerinden yüklenir)
* **yt-dlp.exe** ve **ffmpeg.exe** dosyalarını proje kök klasörüne ekleyin
* Properties → **Copy to Output Directory** → **Copy always**

### 3️⃣ Uygulamayı Çalıştırın

```bash
dotnet run
```

Tarayıcıda Swagger arayüzüne erişin:
**[http://localhost:5116/index.html](http://localhost:5116/index.html)**

---

## 📌 API Endpoint’leri

### 📄 Word → PDF

```http
POST /Convert/WordToPdf
```

**Form-Data:**

* `file` → Word dosyası (.docx, .doc)

📌 **Dönüş:** PDF dosyası yolu

---

### 🎥 Video İndir

```http
POST /Convert/DownloadVideo
```

**Body (JSON):**

```json
{
  "url": "https://www.youtube.com/watch?v=VIDEO_ID"
}
```

📌 **Dönüş (JSON):**

```json
{
  "message": "Video başarıyla indirildi ve uyumlu MP4 formatına dönüştürüldü",
  "filePath": "C:\\path\\to\\Downloads\\video.mp4",
  "sizeMB": 123.45
}
```

---

## 🧪 Demo / Test

Swagger UI üzerinden API isteklerini kolayca test edebilirsiniz.
Ayrıca video indirme işlemi sonrası `Downloads` klasöründe sonucu görebilirsiniz.

---

## 📌 Notlar

* **Büyük dosyaları** (`*.mp4`, `*.exe`) GitHub’a yüklememek için `.gitignore` kullanın.
* İndirme hızı internet bağlantınıza ve seçilen kaliteye göre değişebilir.
* FFmpeg ve yt-dlp olmadan video indirme çalışmaz.

---

## 👩‍💻 Geliştiren

**Melikenur Kaya**
[LinkedIn](https://www.linkedin.com/) • [GitHub](https://github.com/melikenrkaya)

```

---

Eğer istersen bu README’ye **direkt resim ekleme** (Issues üzerinden yükleme linkleriyle) kısımlarını da hazır bırakabilirim ki sen URL’leri ekleyince görseller direkt çıkar.  
İster misin onu da yapayım?
```
