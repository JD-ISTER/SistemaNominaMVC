using System.ComponentModel.DataAnnotations;

namespace SistemaNominaMVC.Models
{
    public class Department
    {
        [Key]
        [StringLength(4)]
        [Display(Name = "Código Departamento")]
        public string dept_no { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Departamento")]
        public string dept_name { get; set; }

        public bool IsActive { get; set; } = true;

        // Propiedades de navegación
        public virtual ICollection<DeptEmp> DeptEmps { get; set; }
        public virtual ICollection<DeptManager> DeptManagers { get; set; }
    }
}