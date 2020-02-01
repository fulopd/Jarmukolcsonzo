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
    public class JarmuKategoriaPresenter
    {
        private IDataGridList<jarmukategoria> view;
        private JarmuKategoriaRepository repo = new JarmuKategoriaRepository();

        public JarmuKategoriaPresenter(IDataGridList<jarmukategoria> param)
        {
            view = param;
        }

        public void LoadData() {
            view.bindingList = repo.getAllKategoriak(
                view.pageNumber,
                view.itemsPerPage,
                view.search,
                view.sortBy,
                view.ascending);
        }

        public void Save()
        {
            repo.Save();
        }

    }

   
}
