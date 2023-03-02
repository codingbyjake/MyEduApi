using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EduApi.Models {
    [Index("Email", IsUnique = true)]
    public class Student {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;
        [StringLength(2)]
        public string StateCode { get; set; } = string.Empty;
        public int? SAT { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal GPA { get; set; }
        [StringLength(40)]
        public string Email { get; set; } = string.Empty;        
        [StringLength(20)]
        public string Password { get; set; } = string.Empty;


        public int MajorId { get; set; }
        public virtual Major? Major { get; set; }
    }
}
