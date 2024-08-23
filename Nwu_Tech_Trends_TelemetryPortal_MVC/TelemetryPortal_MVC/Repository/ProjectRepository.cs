using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
        }

        public IEnumerable<Project> GetProjectsByClientId(Guid clientId)
        {
            return _context.Set<Project>().Where(p => p.ClientId == clientId).ToList();
        }
    }

}
