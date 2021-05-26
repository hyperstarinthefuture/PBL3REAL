
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
    public class ImgStorageDAL
    {
        private AppDbContext _appDbContext;
        public ImgStorageDAL()
        {
            _appDbContext = new AppDbContext();

        }
        public void delete(List<int> listdel)
        {
            List<ImgStorage> list = new List<ImgStorage>();
            foreach(int id in listdel)
            {
                ImgStorage imgStorage = _appDbContext.ImgStorages.Find(id);
                _appDbContext.Entry(imgStorage).State = EntityState.Detached;
                if (imgStorage != null) list.Add(imgStorage);
            }
            
            _appDbContext.ImgStorages.RemoveRange(list);
            _appDbContext.SaveChanges();
        }
        public void add(List<ImgStorage> listadd)
        {

                _appDbContext.ImgStorages.AddRange(listadd);
                _appDbContext.SaveChanges();

        }

        public List<ImgStorage> findByIDRoomtype(int id)
        {
            List< ImgStorage> result = _appDbContext.ImgStorages.Where(x => x.ImgstoIdrootyp ==id).ToList();
            return result;
        }
    }
}

