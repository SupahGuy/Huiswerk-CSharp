namespace Opdracht23;

public class Opdracht23
{
    List<StaffMember> staffMembers = new List<StaffMember> // Geen directe toegang, gebruik een method met delay
    {
        new StaffMember("Alice Andersen", 30, "Software Ontwikkelaar", "IT", "01-03-2015"),
        new StaffMember("Bob Brown", 45, "Project Manager", "Marketing", "15-06-2010"),
        new StaffMember("Charlie Chapman", 28, "Data Analist", "Analyse", "23-09-2018"),
        new StaffMember("Diana Douglas", 35, "HR Manager", "Human Resources", "30-01-2012"),
        new StaffMember("Evan Edwards", 40, "Netwerkbeheerder", "IT", "19-05-2008"),
        new StaffMember("Fiona Fisher", 25, "Marketing Specialist", "Marketing", "01-07-2019"),
        new StaffMember("George Green", 32, "Product Manager", "Productontwikkeling", "17-11-2014"),
        new StaffMember("Hannah Harris", 38, "Sales Manager", "Verkoop", "12-04-2009"),
        new StaffMember("Ian Irving", 29, "Customer Support Medewerker", "Klantenservice", "29-02-2016")
    };
    
    private List<string> staffMemberNames = new()
    {
        "Alice Andersen",
        "Bob Brown",
        "Charlie Chapman",
        "Diana Douglas",
        "Evan Edwards",
        "Fiona Fisher",
        "George Green",
        "Hannah Harris",
        "Ian Irving"
    };
   
    //Maakt tasks om elke data op te halen a.h.v naam,  Wanneer een task klaar is print het deze uit.
    public async Task DisplayAllStaffMembers()
    {
        List<Task<StaffMember>> tasks = new();

        foreach (string staffMemberName in staffMemberNames)
        {
            // Start the tasks asynchronously
            tasks.Add(StaffMember.GetStaffMemberAsync(staffMemberName));
        }
        
        while (tasks.Count > 0)
        {
            var completedTask = await Task.WhenAny(tasks);
            
            tasks.Remove(completedTask);
            
            Console.WriteLine(completedTask.Result.ToString()); // print de staffmember uit.
        }
    }
}