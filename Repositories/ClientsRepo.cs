using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

//Implements all the methods defined in the interface class

namespace TelemetryPortal_MVC.Repositories
{
    public class ClientsRepo : IClientsRepo
    {

        private readonly TechtrendsContext _context;
        public ClientsRepo(TechtrendsContext context)
        {
            _context = context;
        }
        public async Task<List<Client>> GetAllClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }
        public async Task<Client> GetClientsByIdAsync(Guid id)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(m => m.ClientId == id);

            // if statement throws an exception should a null be a possible return value!

            if (client == null)
            {
               
                throw new InvalidOperationException("Client does not exist!");
            }
            return client;
        }
        public async Task AddClientssAsync(Client client)
        {
            client.ClientId = Guid.NewGuid();
            _context.Add(client);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateClientsAsync(Client client)
        {
            _context.Update(client);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteClientsAsync(Guid id)
        {
            var client = await _context.Projects.FindAsync(id);

            if (client != null)
            {
                _context.Projects.Remove(client);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<bool> ClientExistsAsync(Guid id)
        {
            return await _context.Clients.AnyAsync(n => n.ClientId == id);
        }
    }
}
