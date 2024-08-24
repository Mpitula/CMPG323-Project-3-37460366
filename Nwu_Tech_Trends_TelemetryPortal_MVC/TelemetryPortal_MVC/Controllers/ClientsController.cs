using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.Repository;

namespace TelemetryPortal_MVC.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            var clients = await Task.Run(() => _clientRepository.GetAll());
            return View(clients);
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await Task.Run(() => _clientRepository.GetById(id.Value));
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientId,ClientName,PrimaryContactEmail,DateOnboarded")] Client client)
        {
            if (ModelState.IsValid)
            {
                client.ClientId = Guid.NewGuid();
                await Task.Run(() => _clientRepository.Add(client));
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }


        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await Task.Run(() => _clientRepository.GetById(id.Value));
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ClientId,ClientName,PrimaryContactEmail,DateOnboarded")] Client client)
        {
            if (id != client.ClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await Task.Run(() => _clientRepository.Update(client));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.ClientId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await Task.Run(() => _clientRepository.GetById(id.Value));
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await Task.Run(() => _clientRepository.GetById(id));
            if (client != null)
            {
                await Task.Run(() => _clientRepository.Delete(id));
            }

            await Task.Run(() => _clientRepository.Delete(id));
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(Guid id)
        {
            return _clientRepository.GetAll().Any(e => e.ClientId == id);
        }
    }
}
