
using System.ComponentModel.DataAnnotations;

namespace muhasebeprogrami.Models
{
    public class Sehir
    {
        [Key]
        public int Sehir_Id { get; set; }
        public string Sehir_Adi { get; set; }
    }
}
