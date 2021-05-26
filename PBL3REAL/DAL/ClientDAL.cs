using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HotelManagement.Extention;

namespace PBL3REAL.DAL
{
    class ClientDAL
    {
        private AppDbContext _appDbContext;
        public ClientDAL()
        {
            _appDbContext = new AppDbContext(); 
        }

        public int add(Client client)
        {
            _appDbContext.Clients.Add(client);
            _appDbContext.SaveChanges();
            return client.IdClient;
        }

        public List<Client> findByProperty(Dictionary<string, string> properties)
        {
            var predicate = PredicateBuilder.True<Client>();
            if (!properties.ContainsKey("name"))
            {
                predicate = predicate.And(x => x.CliName.Contains(properties["name"]));
            }
            if (!properties.ContainsKey("code"))
            {
                predicate = predicate.And(x => x.CliCode == properties["code"]);
            }

            predicate = predicate.And(x => x.CliActiveflag == true);
            List<Client> result = AppDbContext.Instance.Clients
                        .Where(predicate)
                        .ToList();
            return result;
        }

        public List<Client> getAll()
        {
            var list = (from emp in _appDbContext.Clients
                        select new
                        {
                            temp = emp
                        }).ToList();
            List<Client> clis = new List<Client>();
            foreach (var val in list)
            {
                clis.Add(val.temp);
            }
            return clis;
        }
    }
}
