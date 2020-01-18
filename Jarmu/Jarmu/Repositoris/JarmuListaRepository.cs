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
    public class JarmuListaRepository
    {
        private JKContext db = new JKContext();

               
        public BindingList<jarmu> getAllJarmu()
        {
            //Tárolja el a memóriba a táblát
            db.jarmu.Load();
            //Adja vissza a memóriában található listát
            return db.jarmu.Local.ToBindingList();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
