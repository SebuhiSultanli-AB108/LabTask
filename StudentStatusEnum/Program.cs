using StudentStatusEnum.Models;

namespace StudentStatusEnum
{
    internal class Program
    {
        static void Main()
        {
            Student Sabuhi = new Student()
            {
                FirstName = "Sabuhi",
                LastName = "Sultanli",
                Email = "sabuhies-ab108@code.edu.az",
                GPA = 100,
                PhoneNumber = "0554652279",
                Major = "Computer Engineering",
                Status = StudentStatus.Active,
            }; Student Sabuhi2 = new Student()
            {
                FirstName = "Sabuhi",
                LastName = "basqa",
                Email = "ignore",
                GPA = 100,
                PhoneNumber = "something",
                Major = "Computer Engineering",
                Status = StudentStatus.Active,
            };
            Student Rick = new Student()
            {
                FirstName = "Rick",
                LastName = "Astley",
                Email = "rickastley@gmail.com",
                GPA = 89.4,
                PhoneNumber = "1234567890",
                Major = "Singing",
                Status = StudentStatus.Graduate,
            };
            Student Osman = new Student()
            {
                FirstName = "Osman",
                LastName = "DaglarOglu",
                Email = "quzukababi@gmail.com",
                GPA = 61.1,
                PhoneNumber = "0555555555",
                Major = "Eating",
                Status = StudentStatus.Pending,
            };


            StudentService Students = new StudentService(0);
            Students.AddStudent(Sabuhi);
            Students.AddStudent(Sabuhi2);
            Students.AddStudent(Rick);
            Students.AddStudent(Osman);

            //Student[] newArr = Students.GetStudentsByName("Sabuhi");
            //foreach (Student student in newArr)
            //{
            //    Console.WriteLine(student.FirstName);
            //}

            //Console.WriteLine(Students.GetStudentById(3).FirstName);

            //Students.UpdateStudent(1, Osman);

            //Students.RemoveStudent(1, false);

            Students.GetAllStudents();
        }
    }
}