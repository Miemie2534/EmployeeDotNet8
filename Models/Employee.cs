using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDotNet8.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        public string Time { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(50)]
        public string Firstname { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(50)]
        public string lastname { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(500)]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        [StringLength(50)]
        public string Hospital { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        public string Rider { get; set; } = string.Empty;

        [Required(ErrorMessage = "กรุณากรอกข้อมูลให้ครบ")]
        public string Recorder { get; set; } =string.Empty;
        }
    }
