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
    public partial class JarmuListaForm : Form, IJarmuListaView
    {
        private JarmuListaPresenter presenter;
        private DataGridViewComboBoxColumn jkCol;

        public JarmuListaForm()
        {
            InitializeComponent();
            presenter = new JarmuListaPresenter(this);
            jkCol = new DataGridViewComboBoxColumn();
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

        public int pageNumber => throw new NotImplementedException();

        public int itemsPerPage => throw new NotImplementedException();

        public string search => throw new NotImplementedException();

        public string sortBy => throw new NotImplementedException();

        public bool ascending => throw new NotImplementedException();

        public int totalitems { set => throw new NotImplementedException(); }

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
    }
}
