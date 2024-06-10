# Emlakçı Uygulaması

Bu proje, C# kullanarak basit bir konsol tabanlı emlakçı uygulaması geliştirmektedir. Uygulama, kullanıcıların kiralık ve satılık evleri kaydetmelerine ve görüntülemelerine olanak tanır. Kullanıcılar, ev bilgilerini girdikten sonra bu bilgileri bir dosyada saklayabilir ve daha sonra görüntüleyebilirler.

## Özellikler

- **Kiralık Ev Yönetimi**: Kiralık evlerin kaydını ve görüntülenmesini sağlar.
- **Satılık Ev Yönetimi**: Satılık evlerin kaydını ve görüntülenmesini sağlar.
- **Aidat Bilgisi**: Hem kiralık hem de satılık evler için aidat bilgisi eklenebilir.
- **Depozito Bilgisi**: Kiralık evler için depozito bilgisi eklenebilir.
- **Verilerin Kalıcı Saklanması**: Ev bilgileri yerel dosyalarda saklanır ve daha sonra okunabilir.

## Proje Yapısı

Proje, iki ana bileşenden oluşur:
1. **EmlakciLibrary**: Emlak işlemleri için kullanılan sınıfları içerir.
2. **EmlakciApp**: Konsol uygulamasının ana giriş noktasıdır ve kullanıcı etkileşimlerini yönetir.

### Sınıflar

- **Ev**: Kiralık ve Satılık evler için ortak özellikleri tanımlar.
- **KiralikEv**: Kiralık evlere özgü özellikleri ve metotları içerir.
- **SatilikEv**: Satılık evlere özgü özellikleri ve metotları içerir.

## Kullanım

1. Uygulamayı başlattığınızda, ana menüden Kiralık veya Satılık ev seçeneklerini seçebilirsiniz.
2. Seçiminize göre, mevcut kayıtlı evleri görüntüleyebilir veya yeni bir ev ekleyebilirsiniz.
3. Yeni ev eklerken, gerekli bilgileri girerek kaydı tamamlayabilirsiniz.
4. Ev bilgileri dosyalara kaydedilir ve daha sonra bu dosyalar okunarak ekrana yazdırılır.

### Kurulum

Projeyi bilgisayarınıza klonlamak için aşağıdaki adımları izleyin:

1. GitHub deposunu klonlayın:
2. Projeyi Visual Studio veya başka bir C# IDE'sinde açın.
3. Projeyi derleyin ve çalıştırın.

### Kullanım Talimatları

1. Uygulamayı başlattıktan sonra, menüden Kiralık veya Satılık Ev seçeneğini seçin.
2. Yeni ev eklemek için ilgili seçeneği seçin ve istenen bilgileri girin.
3. Evleri görüntülemek için ilgili seçeneği seçin; kayıtlı evler ekrana yazdırılacaktır.
4. İşlemleriniz bittiğinde "E" tuşuna basarak uygulamadan çıkabilirsiniz.


