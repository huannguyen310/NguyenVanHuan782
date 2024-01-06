using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenVanHuan782.Models
{
    public class Doituong2
    {
        [Key]
        public string Name { get; set; }
        public string Age { get; set; }
        public string Diachi { get; set; }
        public string StudentID { get; set; }
        [ForeignKey("StudenID")]
        public Student? Student {get; set;}
    }
}