using Jarmu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmu.ViewInterfaces
{
    public interface IJarmuListaView : IDataGridList<jarmu>
    {        
        List<jarmukategoria> jkLista { get; set; }

    }
}
