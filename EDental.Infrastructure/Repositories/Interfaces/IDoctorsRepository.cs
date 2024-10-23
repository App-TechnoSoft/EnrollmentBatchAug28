using EDental.Data.Models;

namespace EDental.Infrastructure.Repositories.Interfaces;
public interface IDoctorsRepository
{
    public List<Doctor> Get();
    public Doctor Get(int id);
    public int Insert(Doctor doctor);
    public int Edit(Doctor doctor);
    public int Delete(Doctor doctor);
}
