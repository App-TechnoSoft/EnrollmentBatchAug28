using EDental.Data.Enums;

namespace EDental.Infrastructure.Data.Models;
public class Person
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public Gender Gender { get; set; }
    public DateTime DOB { get; set; }
}
