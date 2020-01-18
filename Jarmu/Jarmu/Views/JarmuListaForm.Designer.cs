namespace Jarmu.Views
{
    partial class JarmuListaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JarmuListaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripButtonMentes = new System.Windows.Forms.ToolStripButton();
            this.jarmuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ferohelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogyasztasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elerhetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szervizbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szervizDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muszakiDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beszerzesDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarmukategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarmuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMentes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rendszamDataGridViewTextBoxColumn,
            this.kategoriaIdDataGridViewTextBoxColumn,
            this.tipusDataGridViewTextBoxColumn,
            this.modellDataGridViewTextBoxColumn,
            this.ferohelyDataGridViewTextBoxColumn,
            this.fogyasztasDataGridViewTextBoxColumn,
            this.elerhetoDataGridViewTextBoxColumn,
            this.szervizbeDataGridViewTextBoxColumn,
            this.szervizDatumDataGridViewTextBoxColumn,
            this.muszakiDatumDataGridViewTextBoxColumn,
            this.beszerzesDatumDataGridViewTextBoxColumn,
            this.jarmukategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jarmuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStripButtonMentes
            // 
            this.toolStripButtonMentes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMentes.Image")));
            this.toolStripButtonMentes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMentes.Name = "toolStripButtonMentes";
            this.toolStripButtonMentes.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonMentes.Text = "Mentés";
            // 
            // jarmuBindingSource
            // 
            this.jarmuBindingSource.DataSource = typeof(Jarmu.Models.jarmu);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // rendszamDataGridViewTextBoxColumn
            // 
            this.rendszamDataGridViewTextBoxColumn.DataPropertyName = "rendszam";
            this.rendszamDataGridViewTextBoxColumn.HeaderText = "rendszam";
            this.rendszamDataGridViewTextBoxColumn.Name = "rendszamDataGridViewTextBoxColumn";
            // 
            // kategoriaIdDataGridViewTextBoxColumn
            // 
            this.kategoriaIdDataGridViewTextBoxColumn.DataPropertyName = "kategoriaId";
            this.kategoriaIdDataGridViewTextBoxColumn.HeaderText = "kategoriaId";
            this.kategoriaIdDataGridViewTextBoxColumn.Name = "kategoriaIdDataGridViewTextBoxColumn";
            // 
            // tipusDataGridViewTextBoxColumn
            // 
            this.tipusDataGridViewTextBoxColumn.DataPropertyName = "tipus";
            this.tipusDataGridViewTextBoxColumn.HeaderText = "tipus";
            this.tipusDataGridViewTextBoxColumn.Name = "tipusDataGridViewTextBoxColumn";
            // 
            // modellDataGridViewTextBoxColumn
            // 
            this.modellDataGridViewTextBoxColumn.DataPropertyName = "modell";
            this.modellDataGridViewTextBoxColumn.HeaderText = "modell";
            this.modellDataGridViewTextBoxColumn.Name = "modellDataGridViewTextBoxColumn";
            // 
            // ferohelyDataGridViewTextBoxColumn
            // 
            this.ferohelyDataGridViewTextBoxColumn.DataPropertyName = "ferohely";
            this.ferohelyDataGridViewTextBoxColumn.HeaderText = "ferohely";
            this.ferohelyDataGridViewTextBoxColumn.Name = "ferohelyDataGridViewTextBoxColumn";
            // 
            // fogyasztasDataGridViewTextBoxColumn
            // 
            this.fogyasztasDataGridViewTextBoxColumn.DataPropertyName = "fogyasztas";
            this.fogyasztasDataGridViewTextBoxColumn.HeaderText = "fogyasztas";
            this.fogyasztasDataGridViewTextBoxColumn.Name = "fogyasztasDataGridViewTextBoxColumn";
            // 
            // elerhetoDataGridViewTextBoxColumn
            // 
            this.elerhetoDataGridViewTextBoxColumn.DataPropertyName = "elerheto";
            this.elerhetoDataGridViewTextBoxColumn.HeaderText = "elerheto";
            this.elerhetoDataGridViewTextBoxColumn.Name = "elerhetoDataGridViewTextBoxColumn";
            // 
            // szervizbeDataGridViewTextBoxColumn
            // 
            this.szervizbeDataGridViewTextBoxColumn.DataPropertyName = "szervizbe";
            this.szervizbeDataGridViewTextBoxColumn.HeaderText = "szervizbe";
            this.szervizbeDataGridViewTextBoxColumn.Name = "szervizbeDataGridViewTextBoxColumn";
            // 
            // szervizDatumDataGridViewTextBoxColumn
            // 
            this.szervizDatumDataGridViewTextBoxColumn.DataPropertyName = "szervizDatum";
            this.szervizDatumDataGridViewTextBoxColumn.HeaderText = "szervizDatum";
            this.szervizDatumDataGridViewTextBoxColumn.Name = "szervizDatumDataGridViewTextBoxColumn";
            // 
            // muszakiDatumDataGridViewTextBoxColumn
            // 
            this.muszakiDatumDataGridViewTextBoxColumn.DataPropertyName = "muszakiDatum";
            this.muszakiDatumDataGridViewTextBoxColumn.HeaderText = "muszakiDatum";
            this.muszakiDatumDataGridViewTextBoxColumn.Name = "muszakiDatumDataGridViewTextBoxColumn";
            // 
            // beszerzesDatumDataGridViewTextBoxColumn
            // 
            this.beszerzesDatumDataGridViewTextBoxColumn.DataPropertyName = "beszerzesDatum";
            this.beszerzesDatumDataGridViewTextBoxColumn.HeaderText = "beszerzesDatum";
            this.beszerzesDatumDataGridViewTextBoxColumn.Name = "beszerzesDatumDataGridViewTextBoxColumn";
            // 
            // jarmukategoriaDataGridViewTextBoxColumn
            // 
            this.jarmukategoriaDataGridViewTextBoxColumn.DataPropertyName = "jarmukategoria";
            this.jarmukategoriaDataGridViewTextBoxColumn.HeaderText = "jarmukategoria";
            this.jarmukategoriaDataGridViewTextBoxColumn.Name = "jarmukategoriaDataGridViewTextBoxColumn";
            this.jarmukategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // JarmuListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "JarmuListaForm";
            this.Text = "Jarmulista";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarmuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonMentes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ferohelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fogyasztasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elerhetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szervizbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szervizDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muszakiDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beszerzesDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarmukategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jarmuBindingSource;
    }
}