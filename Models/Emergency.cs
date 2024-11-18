using System.ComponentModel.DataAnnotations;

namespace EmployeeDotNet8.Models
{
    public class Emergency
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        public DateOnly Date { get; set; }

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        public TimeOnly Time { get; set; }
        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(500)]
        public string Edit { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        public string Recorder { get; set; } = string.Empty;      
        public string Other { get; set; } = string.Empty;
    }
}
