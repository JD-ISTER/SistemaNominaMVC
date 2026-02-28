using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaNominaMVC.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int emp_no { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "CI/NIT")]
        public string ci { get; set; }

        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime birth_date { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Primer Nombre")]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Apellido")]
        public string last_name { get; set; }

        [Required]
        [StringLength(1)]
        [Display(Name = "Género")]
        public string gender { get; set; } // 'M' o 'F'

        [Required]
        [Display(Name = "Fecha de Contratación")]
        [DataType(DataType.Date)]
        public DateTime hire_date { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        [Display(Name = "Correo Electrónico")]
        public string correo { get; set; }

        public bool IsActive { get; set; } = true;

        // Propiedades de navegación
        public virtual ICollection<DeptEmp> DeptEmps { get; set; }
        public virtual ICollection<DeptManager> DeptManagers { get; set; }
        public virtual ICollection<Title> Titles { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual User User { get; set; }
    }
}