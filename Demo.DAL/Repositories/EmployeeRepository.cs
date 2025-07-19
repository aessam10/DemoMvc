namespace Demo.DAL.Repositories;
public class EmployeeRepository(ApplicationDbContext context)
        : GenericRepository<Employee>(context)
    , IEmployeeRepository
{
    public IEnumerable<Employee> GetAll(string name)
    {
        throw new NotImplementedException();
    }
}
