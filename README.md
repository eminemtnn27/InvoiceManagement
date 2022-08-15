# InvoiceManagement

```
git clone https://github.com/eminemtnn27/InvoiceManagement.git
```
## Proje Amacı: 
-Bir sitede yöneticisiniz. Sitenizde yer alan dairelerin aidat ve ortak kullanım elektrik, su ve doğalgaz  faturalarının  yönetimini bir sistem üzerinden yapacaksınız.

## Sistemin İşleyişi:

Sistem kullanılmaya başladığında ilk olarak; Yönetici daire bilgilerini girer.
-	Kullanıcı bilgilerini girer.Giriş yapması için otomatik olarak bir şifre oluşturulur.
-	Kullanıcıları dairelere atar
-	Ay bazlı olarak aidat bilgilerini girer.
-	Ay bazlı olarak fatura bilgilerini girer
Arayüz dışında kullanıcıların kredi kartı ile ödeme yapabilmesi için ayrı bir servis yazılacaktır.
-	Bu servisde sistemde ki her bir kullanıcı için banka bilgileri(bakiye, kredi kartı no vb.) kontrol edilerek ödeme yapılması sağlanır.

## Gereksinimler:
-	Web projesi için: .Net 5
-	Sistemin yönetimi/database için MS SQL Server
-	Kredi kartı servisi için. Veriler mongodb de tutuldu. Servis .Net WebApi kullanıldı.

## Veriler için :
-"FinishProject" adında veritabanı oluşturup Script.sql dosyasını çalıştırmanız yeterlidir.

### İki tip kullanıcı var: 
- Admin ve User

<!-- #### For Login Test :
```
- Email: emine@gmail.com 
- Password: Eminem.27
```
*/-->
