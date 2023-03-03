using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EduApi.Models {
    [Index("Code", IsUnique = true)]
    public class Major {

        public int Id { get; set; }
        [StringLength(4)]
        public string Code { get; set; } = string.Empty;
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        public int MinSat { get; set; }

        [JsonIgnore]
        public virtual ICollection<Student>? Student { get; set; }

        public static List<Major> SeedMajors { get; set; } = new List<Major>() {
            new Major {Id = 0, Code = "EE", Description = "Electrical Engineering", MinSat = 1400},
            new Major {Id = 0, Code = "CS", Description = "Computer Science", MinSat = 1300},
            new Major {Id = 0, Code = "BF", Description = "Business Finance", MinSat = 1200},
            new Major {Id = 0, Code = "UG", Description = "Urban Geography", MinSat = 1100}
        };
    }
}
