namespace ContosoUniversity.Models
{

    //tinfo200:[2021-03-13-alecv-dykstra1] - Contains the grade received in the course

    public enum Grade
    {
        A, B, C, D, F
    }

    //tinfo200:[2021-03-13-alecv-dykstra1] - Enrollment class contains unique student name, grade, enrollment, etc to that student only
    //tinfo200:[2021-03-13-alecv-dykstra1] - Differs from the Students.Enrollments
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}