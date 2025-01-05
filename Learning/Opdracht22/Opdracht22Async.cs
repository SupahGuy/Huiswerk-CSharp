namespace Learning;
using System.Diagnostics;

public class Opdracht22Async
{
    private List<List<string>> _allNumbers;

    public Opdracht22Async()
    {
        _allNumbers = new List<List<string>>();
    }

    //Adds a List of strings of all numbers in the csv file based on fileNumber used for getting sum of each csv file.
    public async Task GetDataFromCsvAsync(int fileNumber)
    {
        List<string> tempList = new List<string>();
        _allNumbers.Add(tempList);
        
        // Source: https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array 
        using(var reader = new StreamReader($"C:\\Users\\DaanS\\bureablad\\1 - ICT\\ICT\\CSharp\\Huiswerk\\Huiswerk-CSharp\\Learning\\Opdracht22\\C5A_data_{fileNumber}.csv"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                foreach (var value in values)
                {
                    _allNumbers[fileNumber-1].Add(value);
                }
            }
        }
    }
    
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
    
    //Used to list all Sums of every data file.
    public async Task GetSumOfAllFiles(int fileCount) // filecount is the amount of files it needs to read data from.
    {
        //makes a task list so it can check whenever all tasks are over to go further.
        
        var tasks = new List<Task>();

        for (int i = 1; i < fileCount+1; i++)
        {
            //haalt alle data van csv bestand op tegelijkertijd. (hierdoor is runtime lager voor mijn code)
            tasks.Add(GetDataFromCsvAsync(i));
        }

        await Task.WhenAll(tasks);
    }

}