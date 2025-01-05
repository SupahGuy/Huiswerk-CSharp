namespace Learning.Opdracht16__digischool_;

public class Teacher : User
{
    private long _subjectCode; // The code to see which subject the teacher teaches
    private int _weeklyHours; // Amount of hours teacher works within school

    public Teacher(string name, long userID, long subjectCode, int weeklyHours)
    {
        Name = name;
        UserType = "Teacher";
        UserID = userID;
        _subjectCode = subjectCode;
        _weeklyHours = weeklyHours;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Type: {UserType}\n" +
               $"ID: {UserID}\n" +
               $"SubjectCode: {_subjectCode}\n" +
               $"Hours/Week: {_weeklyHours}";
    }

}