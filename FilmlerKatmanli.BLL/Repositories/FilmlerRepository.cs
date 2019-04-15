using FilmlerKatmanli.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmlerKatmanli.BLL.Repositories
{
    public class FilmlerRepository : IRepository<Filmler>
    {
        FilmlerDBEntities db = DBTool.DBInstance;
        public void Insert(Filmler item)
        {
            db.Filmler.Add(item);
            db.SaveChanges();
        }

        public void Update(Filmler item)
        {
            Filmler updated = db.Filmler.Find(item.FilmId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void Delete(int itemId)
        {
            db.Filmler.Remove(db.Filmler.Find(itemId));
            db.SaveChanges();
        }

        public List<Filmler> SelectAll()
        {
            return db.Filmler.ToList();
        }

        public Filmler SelectById(int itemId)
        {
            return db.Filmler.Find(itemId);
        }
    }
}
