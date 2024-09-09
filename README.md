# Ödev Listesi

Siliconmade Academy Backend kursu süresince yapılan ve bu depoda yer alan ödevlerin listesi ve her birinin kısa açıklamaları aşağıda verilmiştir.

## Görevler

## Görev-1: Temel HTML Sayfası Oluşturma

HTML kullanarak temel bir web sayfası oluşturulmuştur. Sayfa, başlık (title), menü, içerik alanı, tablo, resimler ve footer gibi temel HTML elementlerini içermektedir. Kullanıcılar için toplam 6 menü bağlantısı sağlanmış ve her bir sayfa başlık, paragraf, liste ve resimlerle zenginleştirilmiştir.

## Görev-2: CV Hazırlama Aracı Oluşturma

HTML, CSS, ve JavaScript kullanılarak bir CV hazırlama aracı geliştirilmiştir. Kullanıcı, sol sütundaki metin içeriklerini girerek CV'yi dinamik olarak güncelleyebilir. Renkler, yazı tipleri ve diğer görünüş özellikleri ortadaki sütundan seçilip, CV üzerinde anında uygulanmaktadır. Ayrıca, metinler her bir tuş basımında CV'de canlı olarak güncellenmektedir.

## Görev-3: Bootstrap Modal Kullanarak Resim Galerisi Oluşturma

HTML, CSS, JavaScript, ve Bootstrap kullanılarak bir resim galerisi oluşturulmuştur. Galeri, grid şeklinde görüntülenen resimlerden oluşmakta ve her resme tıklandığında bir Bootstrap modal penceresi ile büyütülerek gösterilmektedir. Ayrıca, GitHub repository'si oluşturulmuş, .gitignore ayarları yapılmış ve GitHub Desktop kullanılarak repo bilgisayara klonlanmıştır.

Bu çalışma, GitHub'da verilen adreste bulunabilir:
https://github.com/kerem-alba/Top-Metal-Albums

## Görev-4: ASP.NET Core WebAPI Projesi

ASP.NET Core WebAPI kullanılarak bir ürün listesi üzerinde temel CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren bir API geliştirilmiştir. Proje, ProductController ile ürün listesini yönetmekte ve gerekli işlemler Swagger üzerinden test edilmektedir. Ürünler, JSON formatında döndürülmekte ve kaydedilmektedir.

## Görev-5: ASP.NET Core WebAPI Blog Uygulaması

ASP.NET Core WebAPI kullanılarak bir blog uygulaması geliştirilmiştir. Projede, makaleler üzerinde temel CRUD (Create, Read, Update, Delete) işlemleri yapılmış ve API endpoint'lerine produce ve consume özellikleri eklenmiştir. Ayrıca, API'yi test etmek için bir Postman Collection oluşturulmuş ve uygulama başarıyla test edilmiştir.

## Görev-6: ASP.NET Core WebAPI Öğrenci Bilgi Sistemi

ASP.NET Core WebAPI kullanılarak bir öğrenci bilgi sistemi geliştirilmiştir. Proje, öğrenci bilgilerini yönetmek için CRUD işlemleri sağlamaktadır. Ayrıca, hem server-side hem de client-side validasyonlar yapılmış, HTML formları ile WebAPI arasındaki ilişki kurulmuştur. JavaScript ile form alanlarının validasyonu da uygulanmıştır.

## Görev-7: Temel e-Ticaret Veritabanı Oluşturulması

İlişkisel bir veritabanı oluşturulmuştur. Veritabanı, User, Role, Category ve Product tablolarından oluşmakta ve tablolar arasında ilişkiler tanımlanmıştır. CRUD işlemleri gerçekleştirilmiş ve gerekli veri kayıtları eklenmiştir. Veritabanı için bir backup dosyası da oluşturulmuştur.

## Görev-8: Veritabanı ve ASP.NET Core WebAPI ile Öğrenci Bilgi Sistemi

ASP.NET Core WebAPI ve EF Core kullanılarak bir öğrenci bilgi sistemi geliştirilmiştir. Öğrenci verileri veritabanında tutulmuş ve CRUD işlemleri EF Core aracılığıyla gerçekleştirilmiştir. Projede, Bogus kütüphanesi ile veri seed işlemi yapılmış ve hem server-side hem de client-side validasyonlar uygulanmıştır

## Görev-9: ASP.NET Core MVC ile Etkinlik Takip Uygulaması

ASP.NET Core MVC kullanılarak bir etkinlik takip uygulaması geliştirilmiştir. Uygulama, etkinlikler üzerinde temel CRUD (Create, Read, Update, Delete) işlemleri sağlamaktadır. Veritabanı yerine statik bir liste kullanılmış ve etkinlikler, detayları ve yönetimi için View yapıları oluşturulmuştur

## Görev 10'dan 16'ya kadar olan süreçte, e-ticaret uygulaması katmanlı bir mimari üzerine inşa edilerek geliştirildi.

## Görev-10: ASP.NET Core MVC ile e-Ticaret Uygulaması Taslağı

ASP.NET Core MVC kullanılarak bir e-Ticaret uygulaması taslağı geliştirilmiştir. Uygulama, hazır e-ticaret sitesi şablonları kullanılarak tasarlanmış, ancak backend mimarisi sıfırdan oluşturulmuştur. Projede, e-Ticaret ve Admin olmak üzere iki farklı MVC projesi bulunmakta ve temel CRUD işlemleri gerçekleştirilmiştir. Ayrıca, kullanıcı dostu URL routing yapıları eklenmiş ve header, footer gibi tekrar eden bölümler layout yapısına entegre edilmiştir.

## Görev-11: Entity Framework Core ile Veri Katmanı Eklenmiş E-Ticaret Uygulaması

ASP.NET Core MVC e-Ticaret uygulamasına Entity Framework Core kullanarak veri katmanı eklenmiştir. App.Data adlı class library ile veritabanı işlemleri yönetilmiş ve tablolar oluşturulmuştur. Veritabanı, seed verileriyle doldurulmuş ve gerekli CRUD işlemleri gerçekleştirilmiştir. Proje, hem e-Ticaret hem de Admin modüllerini içermekte ve iki projeye de veri katmanı eklenmiştir.

## Görev-12: ASP.NET Core MVC ile E-Ticaret Uygulamasına CRUD ve Validasyon Ekleme

ASP.NET Core MVC e-Ticaret uygulamasına, controller, action, view ve entity'ler üzerinde eklemeler yapılarak CRUD işlemleri ve validasyonlar uygulanmıştır. Model binding kullanılarak veri alımı gerçekleştirilmiş ve hem client-side hem de server-side validasyonlar eklenmiştir. Projede, veri işleme sonuçları ViewModel ve DbContext aracılığıyla işlenmiş ve kullanıcıya sonuçlar dinamik olarak gösterilmiştir.

## Görev-13: ASP.NET Core MVC ile E-Ticaret Uygulamasında Kullanıcı ve Sipariş İşlemleri

ASP.NET Core MVC e-Ticaret uygulamasına kullanıcı yönetimi, sepet işlemleri ve sipariş yönetimi gibi eklemeler yapılmıştır. CRUD işlemleri, model binding ve validasyon işlemleri tam olarak uygulanmış, veritabanı ile entegrasyon sağlanmıştır. Kullanıcıdan alınan verilerin hem client-side hem de server-side validasyonları yapılmış ve dinamik olarak gösterilmiştir.

## Görev-14: ASP.NET Core MVC ile Veri Katmanı ve Yetkilendirme Sistemi

Bu görevde, ASP.NET Core MVC e-Ticaret uygulamasına veri işlemleri için ayrı bir veri katmanı (DataRepository) oluşturulmuş ve tüm CRUD işlemleri bu katman üzerinden gerçekleştirilmiştir. Ayrıca, yetkilendirme altyapısı eklenerek kullanıcıların rollerine göre sistemdeki erişim kısıtlamaları sağlanmıştır. Kullanıcıların sadece yetkili oldukları işlemleri yapabildiği bir sistem oluşturulmuştur. Bu işlem için Cookie Authentication kullanılmış ve her role uygun yetkilendirme yapılmıştır.

## Görev-15: Web API ile e-Ticaret ve Dosya Yönetimi

ASP.NET Core Web API kullanılarak iki farklı API projesi oluşturulmuştur:

App.Api.Data: Veritabanı işlemleri ve JWT Authentication işlemlerini yönetir. e-Ticaret ve Admin MVC projeleri, doğrudan veritabanına erişim yerine bu API'yi kullanarak veritabanı işlemlerini gerçekleştirir.
App.Api.File: Dosya yükleme ve indirme işlemlerini yönetir. Ürün görselleri ve dosya işlemleri bu API üzerinden yürütülür.

*JWT Authentication kullanılarak rol bazlı yetkilendirme.
*HttpClient ile MVC projelerinden API'ye istek gönderme.
*Dosya yükleme ve indirme işlemleri için File API'nin kullanılması.
*Token ile yetkilendirilmiş istekler sayesinde güvenli veri işlemleri.

## Görev-16: Modüler Katmanlı Mimari ve Servis Yapısı

Bu görevde, projelerdeki iş mantığını daha modüler ve katmanlı bir yapıya dönüştürmek için servis tabanlı mimari kullanılmıştır. Servisler, DTO modelleri aracılığıyla MVC projeleri ve API projeleri arasında veri aktarımını sağlar.

*App.Services projesi oluşturularak servis işlemleri abstract ve concrete klasörleriyle ayrıştırılmıştır.
*App.Models.DTO projesi ile servisler ve web uygulamaları arasında veri aktarımı DTO modelleri aracılığıyla sağlanmıştır.
*HttpClient kullanımı IHttpClientFactory interface’i ile singleton olarak güncellenmiştir.
*İşlemler Ardalis.Result paketi ile sonuçlandırılmıştır.
Bu mimari, projenin sürdürülebilirliğini artırarak katmanlı bir yapı oluşturmayı ve kod tekrarı problemlerini çözmeyi hedeflemektedir.
