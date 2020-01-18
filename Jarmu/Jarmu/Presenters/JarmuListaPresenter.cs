using Jarmu.Models;
using Jarmu.Repositoris;
using Jarmu.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu.Presenters
{
    public class JarmuListaPresenter
    {
        private IJarmuListaView view;
        private JarmuListaRepository repo = new JarmuListaRepository();
        private JarmuKategoriaRepository jkRepo = new JarmuKategoriaRepository();

        public JarmuListaPresenter(IJarmuListaView param)
        {
            view = param;
        }


        public void LoadData()
        {
            view.bindingList = repo.getAllJarmu();

            view.jkLista = jkRepo.getAllKategoriak().ToList();
        }

        public void Save()
        {
            repo.Save();
        }

    }
}
