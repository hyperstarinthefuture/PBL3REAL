using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBL3REAL.DAL
{
    public class RoleDAL
    {
        public static RoleDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RoleDAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private static RoleDAL _Instance;

        public RoleDAL() { }

        public List<Role> getAll()
        {
            var result = AppDbContext.Instance.Roles.AsNoTracking().ToList();
            return result;
        }
    }
}
