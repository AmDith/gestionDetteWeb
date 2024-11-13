using gestionDetteWeb.Core.Database;
using gestionDette.ism.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestionDette.ism.Repositories.BDEF
{
    public class ClientRepoBd : ClientRepoListInt
    {
        private readonly ApplicationDbContext _context;

        public ClientRepoBd(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Insert(Client entity)
        {
            entity.SetDateCreate(DateTime.Now);
            entity.SetDateUpdate(DateTime.Now);

            _context.Clients.Add(entity);
            _context.SaveChanges();

            Console.WriteLine("Client ajouté avec succès.");
            return entity.Id;
        }

        public void Delete(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();

                Console.WriteLine("Client supprimé avec succès.");
            }
            else
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID {id}.");
            }
        }

        public List<Client> SelectAll()
        {
            return _context.Clients.ToList();
        }

        public Client? SelectById(int id)
        {
            return _context.Clients.FirstOrDefault(c => c.Id == id);
        }

        public Client? SelectByPhone(string phone)
        {
            return _context.Clients.FirstOrDefault(c => c.Tel == phone);
        }

        public Client? SelectBySurname(string val)
        {
            return _context.Clients.FirstOrDefault(c => c.Nom == val);
        }

        public void Update(Client entity)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == entity.Id);
            if (client != null)
            {
                client.Nom = entity.Nom;
                client.Tel = entity.Tel;
                client.Adresse = entity.Adresse;
                client.SetDateUpdate(DateTime.Now);

                _context.SaveChanges();

                Console.WriteLine("Client mis à jour avec succès.");
            }
            else
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID {entity.Id}.");
            }
        }
    }
}
