using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

//Implements all the methods defined in the interface class

namespace TelemetryPortal_MVC.Repositories
{
    public class ClientsRepo : GenericRepo<Client>, IClientsRepo
    {
        public ClientsRepo(TechtrendsContext context) : base(context) { }

       
        public async Task<List<Client>> GetAllClientsAsync()
        {
            return (await GetAllGenericAsync()).ToList();
        }
        public async Task<Client> GetClientsByIdAsync(Guid id)
        {
            var client = await GetGenericByIdAsync(id);

            // if statement throws an exception should a null be a possible return value!
            if(client == null)
            {
                throw new InvalidOperationException($"Client with ID {id} does not exist.");
            }
            return client;
        }

        public async Task AddClientssAsync(Client client)
        {
            await AddGenericAsync(client);
        }

        public async Task UpdateClientsAsync(Client client)
        {
            await UpdateGenericAsync(client);
        }
        public async Task DeleteClientsAsync(Guid id)
        {

            await DeleteGenericAsync(id);
        }
        public async Task<bool> ClientExistsAsync(Guid id)
        {
            return await GenericExistsAsync(id);
        }
    }
}
