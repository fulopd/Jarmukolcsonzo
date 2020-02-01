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
    public partial class JarmuKategoriaForm : Form, IDataGridList<jarmukategoria>
    {
        private JarmuKategoriaPresenter presenter;
        private int perPage = 10, page = 1, pageCount;


        public JarmuKategoriaForm()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaPresenter(this);
        }

        public BindingList<jarmukategoria> bindingList {
            get => (BindingList<jarmukategoria>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value; }

        public int pageNumber => page;

        public int itemsPerPage => perPage;

        public string search => KeresestoolStripTextBox.Text;

        public string sortBy => null;

        public bool ascending => true;

        public int totalitems {

            set
            {
                pageCount = ((value -1) / perPage) + 1;
                pageLabel.Text = page.ToString() + " / " + pageCount.ToString();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            presenter.LoadData();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            page = 1;
            presenter.LoadData();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (page>=2)
            {
                page--;
                presenter.LoadData();
            }
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (page < pageCount)
            {
                page++;
                presenter.LoadData();
            }
            
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            page = pageCount;
            presenter.LoadData();
        }

        private void Jarmukategoria_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
    }
}
