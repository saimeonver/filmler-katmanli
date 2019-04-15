using FilmlerKatmanli.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmlerKatmanli.BLL.Repositories
{
    public class OyuncularRepository : IRepository<Oyuncular>
    {

        FilmlerDBEntities db = DBTool.DBInstance;
        public List<Oyuncular> SelectAll()
        {
            return db.Oyuncular.ToList();
        }

        public Oyuncular SelectById(int itemId)
        {
            return db.Oyuncular.Find(itemId);
        }

        public void Insert(Oyuncular item)
        {
            db.Oyuncular.Add(item);
            db.SaveChanges();
        }

        public void Update(Oyuncular item)
        {
            Oyuncular updated = db.Oyuncular.Find(item.OyuncuId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void Delete(int itemId)
        {
            db.Oyuncular.Remove(db.Oyuncular.Find(itemId));
            db.SaveChanges();
        }

    }
}
