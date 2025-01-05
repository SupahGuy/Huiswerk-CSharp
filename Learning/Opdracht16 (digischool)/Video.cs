namespace Learning.Opdracht16__digischool_;

public class Video : Material
{
    private decimal _lengthInSeconds;
    private bool _subtitlesEnabled;


    public Video(string materialType, string materialName, string materialDescription, decimal lengthInSeconds , bool subtitlesEnabled)
    {
        MaterialType = materialType;
        MaterialName = materialName;
        MaterialDescription = materialDescription;
        _lengthInSeconds = lengthInSeconds;
        _subtitlesEnabled = subtitlesEnabled;
    }

    public override string ToString()
    {
        return $"Material Type: {MaterialType}\n" +
               $"Material Name: {MaterialName}\n" +
               $"Material Description: {MaterialDescription}\n" +
               $"Length (s): {_lengthInSeconds}\n" +
               $"Subtitles: {_subtitlesEnabled}";
    }
}