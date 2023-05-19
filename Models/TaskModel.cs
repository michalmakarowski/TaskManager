using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskMenager.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskID { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage ="Pole jest wymagane")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Opis")]
        [MaxLength(2000)]
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
