using System.ComponentModel.DataAnnotations;

namespace EmployeeDotNet8.Models
{
    public class Todolist
    {
        [Key]
        public int Id { get; set; }
        public DateOnly Date { get; set; }

        [Required(ErrorMessage ="กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        public string Finish { get; set; } = string.Empty;
        public string Other { get; set; } = string.Empty;
    }
}
