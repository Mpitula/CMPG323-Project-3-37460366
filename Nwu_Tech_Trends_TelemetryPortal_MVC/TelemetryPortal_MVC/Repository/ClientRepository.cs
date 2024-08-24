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

        public IEnumerable<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.Find(id);
        }

        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        public void DeleteClient(int id)
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }
        public Client GetClientByEmail(string email)
        {
            return _context.Clients.FirstOrDefault(c => c.PrimaryContactEmail == email);
        }
    }
}

