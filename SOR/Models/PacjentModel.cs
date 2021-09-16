using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SOR.Models
{
    [Table("Pacjenci")]
    public class PacjentModel
    {
        [Key]
        public int PacjentId { get; set; }
        [DisplayName("Imię i Nazwisko")]
        [Required(ErrorMessage ="Imię i nazwisko jest wymagane.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Numer PESEL")]
        [Required(ErrorMessage = "Numer PESEL jest wymagany")]
        public long Pesel { get; set; }
        [DisplayName("Wywiad chorobowy")]
        [MaxLength(2000)]
        public string Wywiad { get; set; }
        [DisplayName("Opis badania i zastosowane leczenie")]
        [MaxLength(2000)]
        public string Leczenie { get; set; }
        [MaxLength(50)]
        public string Rozpoznanie { get; set; }
        public bool Szpital { get; set; }

    }
}
