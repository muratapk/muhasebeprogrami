using System.ComponentModel.DataAnnotations;

namespace muhasebeprogrami.Models
{
    public class Unvan
    {
        [Key]
        public int Unvan_Id { get; set; }
        public string Unvan_Adi { get; set; }
    }
}
