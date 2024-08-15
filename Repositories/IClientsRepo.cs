using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal_MVC.Models;

// this class defines the interface of the Clients Repository. 
//outlines methods that the repository will use

namespace TelemetryPortal_MVC.Repositories
{
    public interface IClientsRepo
    {
        Task<List<Client>> GetAllClientsAsync();
        Task<Client> GetClientsByIdAsync(Guid id);
        Task AddClientssAsync(Client client);
        Task UpdateClientsAsync(Client client);
        Task DeleteClientsAsync(Guid id);
        Task<bool> ClientExistsAsync(Guid id);
    }
}
