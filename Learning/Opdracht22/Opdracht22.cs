using System.Diagnostics;

namespace Learning;

public class Opdracht22
{
    private List<List<string>> _allNumbers;
    private static int _fileNumber;
    public Opdracht22()
    {
        _allNumbers = new List<List<string>>();
    }

    public void NewList()
    {
        _fileNumber++;
    }

    //makes a new list and puts it into _allNumbers to calculate the sum in CalculateCount 
    public void GetDataFromCsv()
    {
        List<string> tempList = new List<string>();
        _allNumbers.Add(tempList);
        
        // Source: https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array 
        using(var reader = new StreamReader($"C:\\Users\\DaanS\\bureablad\\1 - ICT\\ICT\\CSharp\\Huiswerk\\Huiswerk-CSharp\\Learning\\Opdracht22\\C5A_data_{_fileNumber}.csv"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                foreach (var value in values)
                {
                    _allNumbers[_fileNumber-1].Add(value);
                }
            }
        }
    }
    

    //prints the sum of all numbers in all lists in _allNumbers
    public void CalculateCount()
    {
        int listCount = 0;
        foreach (var currentNumberList in _allNumbers)
        {
            listCount++;
            int totalCount = 0;
            
            foreach (var currentNumber in currentNumberList)
            {
                totalCount += Convert.ToInt32(currentNumber);   
            }

            Console.WriteLine($"List {listCount}: TotalCount: {totalCount}");
        }
    }
}
