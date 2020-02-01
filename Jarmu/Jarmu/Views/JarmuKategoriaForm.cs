﻿using Jarmu.Models;
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

        public JarmuKategoriaForm()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaPresenter(this);
        }

        public BindingList<jarmukategoria> bindingList {
            get => (BindingList<jarmukategoria>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value; }

        public int pageNumber => throw new NotImplementedException();

        public int itemsPerPage => throw new NotImplementedException();

        public string search => throw new NotImplementedException();

        public string sortBy => throw new NotImplementedException();

        public bool ascending => throw new NotImplementedException();

        public int totalitems { set => throw new NotImplementedException(); }

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
