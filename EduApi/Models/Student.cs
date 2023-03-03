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

        public Student() { }
        public Student(int id, string name, string statecode, int? sat, decimal gpa, int majorid, string email, string password) {
            Id = 0;
            Name = name;
            StateCode = statecode;
            SAT = sat;
            GPA = gpa;
            MajorId = majorid;
            Email = email;
            Password = password;
         }


        public static Student fred = new Student(0, "Fred", "KY", 1300, 3.2m, 2, "fred@email.com", "password");
        public static Student fran = new Student(0, "Fran", "KY", 1410, 3.4m,2, "fran@email.com", "password");
        public static Student bill = new Student(0, "Bill", "NY", 1580, 4.0m, 1, "bill@email.com", "password");
        public static Student betty = new Student(0, "Betty", "NY", 1607, 3.2m, 1, "betty@email.com", "password");
        public static Student stew = new Student(0, "Stew", "OH", 1420, 3.5m, 3, "stew@email.com", "password");
        public static Student sara = new Student(0, "Sara", "OH", 1419, 3.49m, 4, "sara@email.com", "password");

        public static List<Student> SeedStudents { get; set; } = new List<Student>() { fred!, fran!, bill!, betty!, stew!, sara! };
       //public static List<Student> SeedStudents = new List<Student>();

        

    }
}
