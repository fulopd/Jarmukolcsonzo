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
        private int pageCount;
        private int colIndex;


        public JarmuKategoriaForm()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaPresenter(this);
            Init();
        }

        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 25;
            sortBy = "Id";
            ascending = true;
            colIndex = 0;
        }

        public BindingList<jarmukategoria> bindingList
        {
            get => (BindingList<jarmukategoria>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }

        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search => KeresestoolStripTextBox.Text;
        public string sortBy { get; set; }
        public bool ascending { get; set; }

        public int totalitems
        {
            set
            {
                pageCount = ((value - 1) / itemsPerPage) + 1;
                pageLabel.Text = pageNumber.ToString() + " / " + pageCount.ToString();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            presenter.LoadData();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.LoadData();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (pageNumber >= 2)
            {
                pageNumber--;
                presenter.LoadData();
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (pageNumber < pageCount)
            {
                pageNumber++;
                presenter.LoadData();
            }

        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
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

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (colIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                default:
                    sortBy = "Id";
                    break;
                case 1:
                    sortBy = "kategoriaNev";
                    break;
            }
            
            colIndex = e.ColumnIndex;
            presenter.LoadData();
        }
    }
}
