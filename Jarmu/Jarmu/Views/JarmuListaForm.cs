using Jarmu.Models;
using Jarmu.Presenters;
using Jarmu.Properties;
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
    public partial class JarmuListaForm : Form, IJarmuListaView
    {
        private JarmuListaPresenter presenter;
        private DataGridViewComboBoxColumn jkCol;
        private int pageCount;
        private int colIndex;

        public JarmuListaForm()
        {
            InitializeComponent();
            presenter = new JarmuListaPresenter(this);
            jkCol = new DataGridViewComboBoxColumn();
            Init();
        }

        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 10;
            sortBy = "Id";
            ascending = true;
            colIndex = 0;
        }

        public BindingList<jarmu> bindingList {
            get => (BindingList<jarmu>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }

        public List<jarmukategoria> jkLista
        {
            get => (List<jarmukategoria>)jkCol.DataSource;
            set {

                value.Insert(0, new jarmukategoria() { Id = 0 });
                jkCol.DataSource = value;
            } 
        }

        public int pageNumber { get; set ; }
        public int itemsPerPage { get; set; }
        public string search => toolStripTextBox1.Text;
        public string sortBy { get ; set; }
        public bool ascending { get; set; }
        public int totalitems
        {
            set
            {
                pageCount = ((value - 1) / itemsPerPage) + 1;
                pageLabel.Text = pageNumber.ToString() + " / " + pageCount.ToString();
            }
        }

        private void JarmuListaForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();

            //Kiszedi a 3. helyen lévő oszlopot
            dataGridView1.Columns.RemoveAt(2);

            //Járműhöz tartozó érték
            jkCol.DataPropertyName = "kategoriaId";
            //Cioma
            jkCol.HeaderText = "Kategória";
            // Hivatkozási név
            jkCol.Name = "kategoriaId";
            //JK-hoz tartozó megjelenítés és érték kiválasztás
            jkCol.DisplayMember = "kategorianNev";
            jkCol.ValueMember = "Id";
            //Beilleszti az oszlopot a kívánt helyre
            dataGridView1.Columns.Insert(2, jkCol);
        }

        private void toolStripButtonMentes_Click(object sender, EventArgs e)
        {
            presenter.Save();
            
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["kategoriaId"].Value = 0;
        }






        private void searchToolStripButton_Click(object sender, EventArgs e)
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
                    sortBy = "rendszam";
                    break;
                case 2:
                    sortBy = "kategoriaId";
                    break;
                case 3:
                    sortBy = "tipus";
                    break;
                case 4:
                    sortBy = "modell";
                    break;

            }

            colIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                switch (e.ColumnIndex)
                {
                    case 6:
                        MessageBox.Show(Resources.ValosSzam , "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show(e.Exception.Message);
                        break;
                }
            }
        }
    }
}
