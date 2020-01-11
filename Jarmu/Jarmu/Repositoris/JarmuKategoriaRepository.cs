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

        //TODO: Szinkronizálás az adatbázissal
        public BindingList<jarmukategoria> getAllKategoriak() {
            //Tárolja el a memóriba a táblát
            db.jarmukategoria.Load();
            //Adja vissza a memóriában található listát
            return db.jarmukategoria.Local.ToBindingList();
        }

        public void Save() {
            db.SaveChanges();
        }
    }
}
