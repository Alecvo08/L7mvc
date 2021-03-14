using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-alecv-dykstra1] - Contains ID of course as an integer. 
    //tinfo200:[2021-03-13-alecv-dykstra1] - String get set methods for last name and first name of student
    //tinfo200:[2021-03-13-alecv-dykstra1] - DateTime method for exact date of enrollment
    //tinfo200:[2021-03-13-alecv-dykstra1] - ICollection lays out all of these as a list to display
    public class Student
    {
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
