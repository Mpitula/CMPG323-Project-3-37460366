using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        IEnumerable<Project> GetProjectsByClientId(Guid clientId);
    }

}
