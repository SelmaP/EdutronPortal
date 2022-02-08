using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdutronPortal.Models
{
    public class EgitimTanim
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Lütfen Kategori Seçiniz..!")]
        public string Kategori { get; set; }

        [Required(ErrorMessage ="Lütfen Eğitmen Bilgisi Seçiniz ..!")]
        public string EgitmenBilgisi { get; set; }

        [Required(ErrorMessage ="Lütfen Kontenan Sayisi Giriniz..!")]
        public int KontenjanSayisi { get; set; }

        [Required(ErrorMessage ="Lütfen maliyet giriniz..!")]
        public string Maliyet { get; set; }

        [Required(ErrorMessage ="Lütfen Süre Bilgisi Giriniz..!")]
        public string SureBilgileri { get; set; }

    }
}
