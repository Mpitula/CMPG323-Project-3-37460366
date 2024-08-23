using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(TechtrendsContext context) : base(context)
        {

        }

        public Client GetClientByEmail(string email)
        {
            var client = _context.Set<Client>().FirstOrDefault(c => c.PrimaryContactEmail == email);
            if (client == null)
            {
                throw new InvalidOperationException($"Client with email {email} was not found.");
            }
            return client;
        }


    }


}
