using Jarmu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu.Repositoris
{
    public class JarmuKategoriaRepository
    {
        private JKContext db = new JKContext();
        private int _totalItems;

       
        public BindingList<jarmukategoria> getAllKategoriak(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            //SQL query-ként kezeli
            IQueryable<jarmukategoria> query = db.jarmukategoria.OrderBy(x => x.Id).AsQueryable();

            //Keresés
            if (!string.IsNullOrWhiteSpace(search)) {

                search = search.ToLower();
                query = query.Where(x => x.kategorianNev.ToLower().Contains(search));
            }

            //Sorbarendezés
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                //meg kell vizsgálni az oszlopkat a sortBy érték alapján
                //még csak 1 oszlopunk van
                if (ascending){
                    query = query.OrderBy(x => x.kategorianNev);
                }
                else {
                    query = query.OrderBy(x => x.kategorianNev);
                }
            }

            //Összes találat
            _totalItems = query.Count();

            //Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                // skip = ugrás a megadott számú elemre
                // take = hátralévő mennyiséget kiveszi (jelenítse meg)
                query = query.Skip((page - 1) * itemsPerPage ).Take(itemsPerPage);

            }

            return new BindingList<jarmukategoria>(query.ToList());
            
            //Tárolja el a memóriba a táblát
            //db.jarmukategoria.Load();
            //Adja vissza a memóriában található listát
            //return db.jarmukategoria.Local.ToBindingList();
        }


        public int Count() {
            return _totalItems;
        }

        public void Save() {
            db.SaveChanges();
        }


    }
}
