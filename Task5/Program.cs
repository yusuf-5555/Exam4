
var student = new Student();

System.Console.WriteLine(student.Peek());

public class Student : Stack<Student>
{
    List<Student> _students = new List<Student>();
    public int Id { get; set; }
    public string Name { get; set; }
    public int grade { get; set; }

}
