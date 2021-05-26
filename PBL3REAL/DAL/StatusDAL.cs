
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
    public class StatusDAL
    {
        private AppDbContext _appDbContext;
        public StatusDAL()
        {
            _appDbContext = new AppDbContext();
        }
        public List<Status> getAll()
        {
            var result = _appDbContext.Statuses.ToList();
            return result;
        }
    }
}
