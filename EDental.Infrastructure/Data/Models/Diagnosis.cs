namespace EDental.Data.Models;
public class Diagnosis
{
    public int Id { get; set; } // Primary key
    public string Name { get; set; } // Name of the diagnosis or patient
    public string Procedures { get; set; } // List or description of procedures
    public string Medication { get; set; } // List of generic medications
}
