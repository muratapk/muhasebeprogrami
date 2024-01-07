using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace muhasebeprogrami.Models
{
    public class Kasaba
    {
        [Key]
        public int Kasaba_Id { get; set; }
        public string Kasaba_Ad { get; set; } = string.Empty;
        [ForeignKey("Sehir")]
        public int Sehir_Id { get; set; }
        public virtual Sehir? Sehir { get; set; }
    }
}
