using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key] 
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }
        public string? NumberPlate { get; set; }
        public string UserRole { get; set; }
        public ICollection<Dues> due { get; set; }
        public ICollection<Invoice> Invoice { get; set; }

        public ICollection<Message> messages { get; set; }
        public ICollection<Flat> flat { get; set; }

    }
}
//       kullanıcı
// kendisine ait fatura ve aidatları görür
//sadece kredi kartı ile ödeme yapabilir
//yöneticiye mesaj gönderebilir



//        admin/yönetici
//daire bilgilerini girebilir
//ikamet eden kullanıcı bilgilerini girer
//daire başına ödenmesi gereken aidat ve fatura bilgilerini girer(aylık olarak).Toplu veya tek tek atama yapabilir
//gelen öödeme bilgilerini görür
//gelen mesajları görür
//mesajların okunmuş/okunmamış/yeni olduğu anlaşılmalı
//aylık olarak borç ve alacak listesini görür
//kişileri listeler,düzenler,siler
//daire bilgilerini listeler,düzenler,siler