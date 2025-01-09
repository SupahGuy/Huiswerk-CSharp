namespace Opdracht23;
//Code smell: primitive obsession
public class StaffMember
{
    private string _fullName;
    private int _hours;
    private string _occupation;
    private string _sector;
    private string _date;
    private static List<StaffMember> _staffMembers = new List<StaffMember>();
    
    public StaffMember(string fullname, int hours, string occupation, string sector, string date)
    {
        _fullName = fullname;
        _hours = hours;
        _occupation = occupation;
        _sector = sector;
        _date = date;
        _staffMembers.Add(this);
    }
    
    public static async Task<StaffMember> GetStaffMemberAsync(string fullName)
    {
        
        await Task.Delay(new Random().Next(1000, 5000)); // Random delay van 1 t/m 5 s.
        
        foreach (var staffMember in _staffMembers)
        {
            if (staffMember._fullName == fullName)
            {
                return staffMember;
            }
        }
        return null;
    }

    public override string ToString()
    {
        return $"{_fullName}\n   Age: {_hours}\n   Job: {_occupation}\n   Department: {_sector}\n   Start date: {_date}\n";
    }

}
