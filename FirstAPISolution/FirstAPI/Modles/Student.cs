using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstAPI.Modles
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Roll { get; set; }
        public string Name { get; set; }=String.Empty;
        public string City { get; set; } = String.Empty;
        public int Pin { get; set; }
    }
}
