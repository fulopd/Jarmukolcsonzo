﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu.ViewInterfaces
{
    //Reiter könyv: 174. oldal (Generikusok)
    public interface IDataGridList<G>
    {
        //Oda vissza kapcsolat az adatbázis és a DataGridview között
        BindingList<G> bindingList { get; set; } //kapcsolad BindingList -nél oda vissza működik (modosítások adatbázisban mentődnek)
        int pageNumber { get; set; }
        int itemsPerPage { get; set; }
        string search { get; }
        string sortBy { get; set; }
        bool ascending { get; set; }
        int totalitems { set; }


    }
}
