namespace StudentStatusEnum.Models;

public class StudentService : IStudentService
{
    public Student[] Students;

    public StudentService(int length)
    {
        Students = new Student[length];
    }

    public Student this[int index]
    {
        get
        {
            return Students[index];
        }
        set
        {
            if (index < 0 || index > Students.Length - 1) throw new IndexOutOfRangeException();
            Students[index] = value;
        }
    }

    public void AddStudent(Student student)
    {
        bool nullFound = false;
        for (int i = 0; i < Students.Length; i++)
        {
            if (Students[i] == null && !nullFound)
            {
                Students[i] = student;
                nullFound = true;
            }
        }
        if (!nullFound)
        {
            Student[] newArr = new Student[Students.Length + 1];
            for (int i = 0; i < Students.Length; i++)
            {
                newArr[i] = Students[i];
            }
            newArr[newArr.Length - 1] = student;
            Students = newArr;
        }
    }
    public void UpdateStudent(int id, Student student)
    {
        int index = FindStudentById(id);
        if (index != -1)
            Students[index] = student;
        else
            Console.WriteLine("Student couldn't be found!");
    }
    public void RemoveStudent(int id, bool isSoftDelete)
    {
        int index = FindStudentById(id);
        if (isSoftDelete)
            Students[index].Status = StudentStatus.Removed;
        else
        {
            Student[] newArr = new Student[Students.Length - 1];
            int count = 0;
            foreach (Student student in Students)
            {
                if (student != Students[index])
                {
                    newArr[count] = student;
                    count++;
                }
            }
            Students = newArr;
        }
    }
    public Student GetStudentById(int id)
    {
        int index = FindStudentById(id);
        if (index != -1)
            return Students[index];
        else
            return null;
    }
    public Student[] GetStudentsByName(string name)
    {
        int count = 0;
        Student[] newArr = new Student[Students.Length];
        for (int i = 0; i < Students.Length; i++)
        {
            if (Students[i].FirstName == name)
            {
                count++;
                newArr[i] = Students[i];
            }
        }
        Student[] studentsWithGivenName = new Student[count];
        for (int i = 0; i < studentsWithGivenName.Length; i++)
        {
            studentsWithGivenName[i] = newArr[i];
        }
        return studentsWithGivenName;
    }
    private int FindStudentById(int id)
    {
        for (int i = 0; i < Students.Length; i++)
        {
            if (Students[i].Id == id) return i;
        }
        return -1;
    }

    public void GetAllStudents()
    {
        Console.WriteLine("=========================================================STUDENTS=========================================================");
        Console.WriteLine("┌───┬────────────┬───────────────┬────────────────────────────────┬────────────┬─────────────────────────┬──────┬────────┐");
        Console.WriteLine(
            $"│{"Id".PadRight(3, ' ')}│{"FirstName".PadRight(12, ' ')}" +
            $"│{"LastName".PadRight(15, ' ')}│{"Email".PadRight(32, ' ')}" +
            $"│{"PhoneNumber".PadRight(12, ' ')}│{"Major".PadRight(25, ' ')}" +
            $"│{"GPA".PadRight(6, ' ')}│{"Status".PadRight(8, ' ')}│");
        Console.WriteLine("├───┼────────────┼───────────────┼────────────────────────────────┼────────────┼─────────────────────────┼──────┼────────┤");
        int count = 0;
        foreach (Student student in Students)
        {
            count++;
            Console.WriteLine(
                $"│{student.Id.ToString().PadLeft(3, '0')}│{student.FirstName.PadRight(12, ' ')}" +
                $"│{student.LastName.PadRight(15, ' ')}│{student.Email.PadRight(32, ' ')}" +
                $"│{student.PhoneNumber.PadRight(12, ' ')}│{student.Major.PadRight(25, ' ')}" +
                $"│{student.GPA.ToString().PadRight(6, ' ')}│{student.Status.ToString().PadRight(8, ' ')}│");
            if (count < Students.Length) Console.WriteLine("├───┼────────────┼───────────────┼────────────────────────────────┼────────────┼─────────────────────────┼──────┼────────┤");
        }
        Console.WriteLine("└───┴────────────┴───────────────┴────────────────────────────────┴────────────┴─────────────────────────┴──────┴────────┘");
        Console.WriteLine("==========================================================================================================================");

    }
}