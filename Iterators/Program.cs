namespace Iterators;

abstract class Program
{
    private static void Main()
    {
        List<Student> students = [
            new Student { Id = 1, Name = "Josh", Age = 20, Score = 85 },
            new Student { Id = 2, Name = "Jason", Age = 22, Score = 95 },
            new Student { Id = 3, Name = "Maria", Age = 19, Score = 70 },
            new Student { Id = 4, Name = "Victor", Age = 21, Score = 90 },
            new Student { Id = 5, Name = "Joe", Age = 23, Score = 60 }
        ];

        var highScorers = students.Where(s => s.Score > 80);
        foreach (var student in highScorers)
        {
            Console.WriteLine($"{student.Name}, Score: {student.Score}");
        }

        var sortedByAge = students.OrderBy(s => s.Age);
        Console.WriteLine("\nStudents sorted by age:");
        foreach (var student in sortedByAge)
        {
            Console.WriteLine($"{student.Name}, Age: {student.Age}");
        }

        var groupedByAge = students.GroupBy(s => s.Age);
        Console.WriteLine("\nGrouping students by age:");
        foreach (var group in groupedByAge)
        {
            Console.WriteLine($"\nAge: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"{student.Name}");
            }
        }

        var studentNames = students.Select(s => s.Name);
        Console.WriteLine("\nName:");
        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }

        var averageScore = students.Average(s => s.Score);
        Console.WriteLine($"\nAverage score of students: {averageScore}");

        List<Course> courses = new List<Course>()
        {
            new Course { StudentId = 1, CourseName = "Math" },
            new Course { StudentId = 2, CourseName = "Physics" },
            new Course { StudentId = 3, CourseName = "Computer Science" },
            new Course { StudentId = 4, CourseName = "History" },
            new Course { StudentId = 1, CourseName = "English" },
        };

        var studentCourses = from student in students
            join course in courses
                on student.Id equals course.StudentId
            select new { StudentName = student.Name, CourseName = course.CourseName };

        Console.WriteLine("\nStudent list and their courses:");
        foreach (var item in studentCourses)
        {
            Console.WriteLine($"{item.StudentName}: {item.CourseName}");
        }
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Score { get; set; }
}

class Course
{
    public int StudentId { get; set; }
    public string CourseName { get; set; }
}