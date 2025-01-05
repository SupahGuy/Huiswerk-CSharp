namespace Learning.Opdracht16__digischool_;

public class Course
{
    private long _courseId;
    private string _courseName;
    private string _courseDescription;

    public Course(long courseId, string courseName, string courseDescription)
    {
        _courseId = courseId;
        _courseName = courseName;
        _courseDescription = courseDescription;
    }

    public override string ToString()
    {
        return $"ID: {_courseId}\n" +
               $"Name: {_courseName}\n" +
               $"Description: {_courseDescription}";
    }
}