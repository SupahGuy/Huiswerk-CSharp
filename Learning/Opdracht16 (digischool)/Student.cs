namespace Learning.Opdracht16__digischool_;

public class Student : User
{
    private int _classCode; // Code of class Student is in.
    private int _studentYear; // Amount of years Student has completed study
    

    public Student(string name, long userID, int classCode, int studentYear)
    {
        Name = name;
        UserType = "Student";
        UserID = userID;
        _classCode = classCode;
        _studentYear = studentYear;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Type: {UserType}\n" +
               $"ID: {UserID}\n" +
               $"ClassCode: {_classCode}\n" +
               $"Year: {_studentYear}";
    }
}