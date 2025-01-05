namespace Learning.Opdracht16__digischool_;

public class DigitalDocument : Material
{
    private string _fileType;
    private int _fileSizeMB;
    
    public DigitalDocument(string materialType, string materialName, string materialDescription, string fileType ,int fileSizeMB)
    {
        MaterialType = materialType;
        MaterialName = materialName;
        MaterialDescription = materialDescription;
        _fileType = fileType;
        _fileSizeMB = fileSizeMB;
    }

    public override string ToString()
    {
        return $"Material Type: {MaterialType}\n" +
               $"Material Name: {MaterialName}\n" +
               $"Material Description: {MaterialDescription}\n" +
               $"File Type: {_fileType}\n" +
               $"Size in MegaByte(s): {_fileSizeMB}";
    }
}