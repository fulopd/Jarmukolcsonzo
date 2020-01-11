using Jarmu.Models;
using Jarmu.Presenters;
using Jarmu.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarmu.Views
{
    public partial class Jarmukategoria : Form, IDataGridList<jarmukategoria>
    {
        private JarmuKategoriaPresenter presenter;

        public Jarmukategoria()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaPresenter(this);
        }

        public BindingList<jarmukategoria> bindingList {
            get => (BindingList<jarmukategoria>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value; }

        private void Jarmukategoria_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }
    }
}
