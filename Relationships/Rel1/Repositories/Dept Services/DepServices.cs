using Rel1.Models;

namespace Rel1.Repositories.Dept_Services
{
    public class DepServices : IDepServices
    {
        CompanyContext _context;
        public DepServices(CompanyContext context)
        {
            _context = context;
        }
      /*  public async Task<List<Dept>?> GetDepts()
        {
            var total=await _context
        }*/
    }
}
