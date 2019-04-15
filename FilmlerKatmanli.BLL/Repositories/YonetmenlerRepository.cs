using FilmlerKatmanli.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmlerKatmanli.BLL.Repositories
{
    public class YonetmenlerRepository : IRepository<Yonetmenler>
    {

        FilmlerDBEntities db = DBTool.DBInstance;
        public List<Yonetmenler> SelectAll()
        {
            return db.Yonetmenler.ToList();
        }

        public Yonetmenler SelectById(int itemId)
        {
            return db.Yonetmenler.Find(itemId);
        }

        public void Insert(Yonetmenler item)
        {
            db.Yonetmenler.Add(item);
            db.SaveChanges();
        }

        public void Update(Yonetmenler item)
        {
            Yonetmenler updated = db.Yonetmenler.Find(item.YonetmenId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void Delete(int itemId)
        {
            db.Yonetmenler.Remove(db.Yonetmenler.Find(itemId));
            db.SaveChanges();
        }

    }
}
