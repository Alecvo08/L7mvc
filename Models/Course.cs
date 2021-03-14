using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-alecv-dykstra1] - Course class features a DatabaseGenerated attribute which lets 
    //tinfo200:[2021-03-13-alecv-dykstra1] - the pk of a course be entered instead of it being generated straight from the database
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
