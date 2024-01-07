
using System.ComponentModel.DataAnnotations;

namespace muhasebeprogrami.Models
{
    public class Sehir
    {
        [Key]
        public int Sehir_Id { get; set; }
        public string Sehir_Adi { get; set; } = string.Empty;
        public virtual List<Kasaba>? Kasabas { get; set; }
    }
}
