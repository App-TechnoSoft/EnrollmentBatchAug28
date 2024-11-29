using EDental.Infrastructure.Data.Models;

namespace EDental.Data.Models;
public class Doctor : Person
{   
    public string NDCNumber { get; set; }
    public string Qualification { get; set; }
    public string Specialization { get; set; }
}
