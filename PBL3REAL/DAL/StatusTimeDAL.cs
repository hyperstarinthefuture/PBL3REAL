using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PBL3REAL.Model;

namespace HotelManagement.DAL.Impl
{
    public class StatusTimeDAL 
    {
            private AppDbContext _appDbContext;
            public StatusTimeDAL(){
                _appDbContext = new AppDbContext();
            }

        public void add(List<StatusTime> listadd)
        {
            try{
                _appDbContext.StatusTimes.AddRange(listadd);
                _appDbContext.SaveChanges();
            }catch(Exception e){
                throw ;
            }

        }
       

        public List<StatusTime> findByIdRoom(int idroom)
        {
            return _appDbContext.StatusTimes.Where(x => x.StatimIdroom == idroom).AsNoTracking().ToList();
        }
        public void delete(List<int> listdel)
        {
            List<StatusTime>list = new List<StatusTime>();
            foreach(int id in listdel){
                StatusTime statusTime = _appDbContext.StatusTimes.Find(id);
                _appDbContext.Entry(statusTime).State = EntityState.Detached;
                if(statusTime !=null) list.Add(statusTime);
            }
            _appDbContext.RemoveRange(list);
            _appDbContext.SaveChanges();
        }

        public void update(List<StatusTime>listedit){
//             foreach (var entityEntry in _appDbContext.ChangeTracker.Entries())
// {
//     Console.WriteLine(entityEntry);
// }
_appDbContext.ChangeTracker.DetectChanges();
Console.WriteLine(_appDbContext.ChangeTracker.DebugView.LongView);
        //   var transaction = _appDbContext.Database.UseTransaction(_appDbContext.transaction.GetDbTransaction());
            try{
                _appDbContext.StatusTimes.UpdateRange(listedit);
                _appDbContext.SaveChanges();
                // _appDbContext.transaction.Commit();
            }catch(Exception e){
                throw ;
                // _appDbContext.transaction.RollbackToSavepoint("Before update StatusTime");
            }
        }
    }
}