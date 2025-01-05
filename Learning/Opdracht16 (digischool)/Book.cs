namespace Learning.Opdracht16__digischool_;

public class Book : Material
{
    private string _bookType { get; set; } // Sci-fi, History etc
    private string _authorName { get; set; } //Name of Author

    public Book(string materialType, string materialName, string materialDescription, string bookType,string authorName )
    {
        MaterialType = materialType;
        MaterialName = materialName;
        MaterialDescription = materialDescription;
        _bookType = bookType;
        _authorName = authorName;
    }

    public override string ToString()
    {
        return $"Material Type: {MaterialType}\n" +
               $"Material Name: {MaterialName}\n" +
               $"Material Description: {MaterialDescription}\n" +
               $"Book Type: {_bookType}\n" +
               $"Author Name: {_authorName}";
    }
}