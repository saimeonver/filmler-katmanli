using FilmlerKatmanli.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmlerKatmanli.BLL
{
    public class DBTool
    {
        private static FilmlerDBEntities _dbInstance;

        public static FilmlerDBEntities DBInstance
        {
            get
            {
                if (_dbInstance == null)
                    _dbInstance = new FilmlerDBEntities();
                return _dbInstance;
            }
        }

    }
}
