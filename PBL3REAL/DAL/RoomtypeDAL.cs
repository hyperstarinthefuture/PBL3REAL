
using HotelManagement.Extention;
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
   public class RoomtypeDAL 
    {
        private AppDbContext _appDbContext;
        public RoomtypeDAL()
        {
            _appDbContext = new AppDbContext();
        }
        public void Add(RoomType roomType)
        {
            _appDbContext.RoomTypes.Add(roomType);
            _appDbContext.SaveChanges();
        }

        public List<RoomType> findByProperty(string search , string orderby)
        {
            var query = _appDbContext.RoomTypes.Where(x => x.RotyName.Contains(search) || x.RotyCode.Contains(search));
            switch (orderby)
            {
                case "None": break;
                case "Current Price Asc" :  query = query.OrderBy(x => x.RotyCurrentprice); break;
                case "Current Price Desc": query = query.OrderByDescending(x => x.RotyCurrentprice); break;
                default: break;
            }
            List<RoomType> result = query.AsNoTracking().ToList();
            return result;
        }

        public void addRoomtype(RoomType roomType)
        {
            _appDbContext.RoomTypes.Add(roomType);
            _appDbContext.SaveChanges();
        }

        public void deleteRoomtype(int idRoomtype)
        {
            RoomType roomType = _appDbContext.RoomTypes.Find(idRoomtype);
            if(roomType !=null) roomType.RoTyActiveflag = false;
            _appDbContext.Update(roomType);
            _appDbContext.SaveChanges();
        }

        public void updateRoomtype(RoomType roomType)
        {
            _appDbContext.RoomTypes.Update(roomType);
            _appDbContext.SaveChanges();
        }


        public int getnextid()
        {
            int id;
            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT IDENT_CURRENT('room_type')+1";
                _appDbContext.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    result.Read();
                    id = Decimal.ToInt32((decimal)result[0]);
                }
            }
            return id;
        }

        public RoomType findbyid(int id)
        {
            RoomType roomType = (RoomType)_appDbContext.RoomTypes.Where(x => x.IdRoomtype == id).Include(x => x.ImgStorages).SingleOrDefault();
            if (roomType != null) _appDbContext.Entry(roomType).State = EntityState.Detached;
            return roomType;
        }
    }
}

