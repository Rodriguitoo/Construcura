
namespace CKE
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cKEDataSet = new CKE.CKEDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new CKE.CKEDataSetTableAdapters.EmpleadoTableAdapter();
            this.numempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cKEDataSet1 = new CKE.CKEDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new CKE.CKEDataSet1TableAdapters.ClienteTableAdapter();
            this.numcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dircliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foncliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cKEDataSet2 = new CKE.CKEDataSet2();
            this.obraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obraTableAdapter = new CKE.CKEDataSet2TableAdapters.ObraTableAdapter();
            this.numobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fteobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciuobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliobrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKEDataSet3 = new CKE.CKEDataSet3();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadTableAdapter = new CKE.CKEDataSet3TableAdapters.CiudadTableAdapter();
            this.numciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomciuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKEDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numempDataGridViewTextBoxColumn,
            this.nomempDataGridViewTextBoxColumn,
            this.rutempDataGridViewTextBoxColumn,
            this.dirempDataGridViewTextBoxColumn,
            this.telempDataGridViewTextBoxColumn,
            this.corempDataGridViewTextBoxColumn,
            this.idcempDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 62);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cKEDataSet
            // 
            this.cKEDataSet.DataSetName = "CKEDataSet";
            this.cKEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.cKEDataSet;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // numempDataGridViewTextBoxColumn
            // 
            this.numempDataGridViewTextBoxColumn.DataPropertyName = "num_emp";
            this.numempDataGridViewTextBoxColumn.HeaderText = "num_emp";
            this.numempDataGridViewTextBoxColumn.Name = "numempDataGridViewTextBoxColumn";
            this.numempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomempDataGridViewTextBoxColumn
            // 
            this.nomempDataGridViewTextBoxColumn.DataPropertyName = "nom_emp";
            this.nomempDataGridViewTextBoxColumn.HeaderText = "nom_emp";
            this.nomempDataGridViewTextBoxColumn.Name = "nomempDataGridViewTextBoxColumn";
            this.nomempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutempDataGridViewTextBoxColumn
            // 
            this.rutempDataGridViewTextBoxColumn.DataPropertyName = "rut_emp";
            this.rutempDataGridViewTextBoxColumn.HeaderText = "rut_emp";
            this.rutempDataGridViewTextBoxColumn.Name = "rutempDataGridViewTextBoxColumn";
            this.rutempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirempDataGridViewTextBoxColumn
            // 
            this.dirempDataGridViewTextBoxColumn.DataPropertyName = "dir_emp";
            this.dirempDataGridViewTextBoxColumn.HeaderText = "dir_emp";
            this.dirempDataGridViewTextBoxColumn.Name = "dirempDataGridViewTextBoxColumn";
            this.dirempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telempDataGridViewTextBoxColumn
            // 
            this.telempDataGridViewTextBoxColumn.DataPropertyName = "tel_emp";
            this.telempDataGridViewTextBoxColumn.HeaderText = "tel_emp";
            this.telempDataGridViewTextBoxColumn.Name = "telempDataGridViewTextBoxColumn";
            this.telempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corempDataGridViewTextBoxColumn
            // 
            this.corempDataGridViewTextBoxColumn.DataPropertyName = "cor_emp";
            this.corempDataGridViewTextBoxColumn.HeaderText = "cor_emp";
            this.corempDataGridViewTextBoxColumn.Name = "corempDataGridViewTextBoxColumn";
            this.corempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcempDataGridViewTextBoxColumn
            // 
            this.idcempDataGridViewTextBoxColumn.DataPropertyName = "idc_emp";
            this.idcempDataGridViewTextBoxColumn.HeaderText = "idc_emp";
            this.idcempDataGridViewTextBoxColumn.Name = "idcempDataGridViewTextBoxColumn";
            this.idcempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado completo de los empleados";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numcliDataGridViewTextBoxColumn,
            this.rutcliDataGridViewTextBoxColumn,
            this.nomcliDataGridViewTextBoxColumn,
            this.dircliDataGridViewTextBoxColumn,
            this.corcliDataGridViewTextBoxColumn,
            this.foncliDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clienteBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 145);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(676, 76);
            this.dataGridView2.TabIndex = 2;
            // 
            // cKEDataSet1
            // 
            this.cKEDataSet1.DataSetName = "CKEDataSet1";
            this.cKEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.cKEDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // numcliDataGridViewTextBoxColumn
            // 
            this.numcliDataGridViewTextBoxColumn.DataPropertyName = "num_cli";
            this.numcliDataGridViewTextBoxColumn.HeaderText = "num_cli";
            this.numcliDataGridViewTextBoxColumn.Name = "numcliDataGridViewTextBoxColumn";
            // 
            // rutcliDataGridViewTextBoxColumn
            // 
            this.rutcliDataGridViewTextBoxColumn.DataPropertyName = "rut_cli";
            this.rutcliDataGridViewTextBoxColumn.HeaderText = "rut_cli";
            this.rutcliDataGridViewTextBoxColumn.Name = "rutcliDataGridViewTextBoxColumn";
            // 
            // nomcliDataGridViewTextBoxColumn
            // 
            this.nomcliDataGridViewTextBoxColumn.DataPropertyName = "nom_cli";
            this.nomcliDataGridViewTextBoxColumn.HeaderText = "nom_cli";
            this.nomcliDataGridViewTextBoxColumn.Name = "nomcliDataGridViewTextBoxColumn";
            // 
            // dircliDataGridViewTextBoxColumn
            // 
            this.dircliDataGridViewTextBoxColumn.DataPropertyName = "dir_cli";
            this.dircliDataGridViewTextBoxColumn.HeaderText = "dir_cli";
            this.dircliDataGridViewTextBoxColumn.Name = "dircliDataGridViewTextBoxColumn";
            // 
            // corcliDataGridViewTextBoxColumn
            // 
            this.corcliDataGridViewTextBoxColumn.DataPropertyName = "cor_cli";
            this.corcliDataGridViewTextBoxColumn.HeaderText = "cor_cli";
            this.corcliDataGridViewTextBoxColumn.Name = "corcliDataGridViewTextBoxColumn";
            // 
            // foncliDataGridViewTextBoxColumn
            // 
            this.foncliDataGridViewTextBoxColumn.DataPropertyName = "fon_cli";
            this.foncliDataGridViewTextBoxColumn.HeaderText = "fon_cli";
            this.foncliDataGridViewTextBoxColumn.Name = "foncliDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listado completo de los clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Listado Completo de la obra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Listado completo de la ciudades";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numobrDataGridViewTextBoxColumn,
            this.nomobrDataGridViewTextBoxColumn,
            this.dirobrDataGridViewTextBoxColumn,
            this.fiobrDataGridViewTextBoxColumn,
            this.ftobrDataGridViewTextBoxColumn,
            this.fteobrDataGridViewTextBoxColumn,
            this.monobrDataGridViewTextBoxColumn,
            this.estobrDataGridViewTextBoxColumn,
            this.ciuobrDataGridViewTextBoxColumn,
            this.cliobrDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.obraBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 263);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1075, 68);
            this.dataGridView3.TabIndex = 6;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numciuDataGridViewTextBoxColumn,
            this.nomciuDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.ciudadBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(16, 403);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(245, 146);
            this.dataGridView4.TabIndex = 7;
            // 
            // cKEDataSet2
            // 
            this.cKEDataSet2.DataSetName = "CKEDataSet2";
            this.cKEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obraBindingSource
            // 
            this.obraBindingSource.DataMember = "Obra";
            this.obraBindingSource.DataSource = this.cKEDataSet2;
            // 
            // obraTableAdapter
            // 
            this.obraTableAdapter.ClearBeforeFill = true;
            // 
            // numobrDataGridViewTextBoxColumn
            // 
            this.numobrDataGridViewTextBoxColumn.DataPropertyName = "num_obr";
            this.numobrDataGridViewTextBoxColumn.HeaderText = "num_obr";
            this.numobrDataGridViewTextBoxColumn.Name = "numobrDataGridViewTextBoxColumn";
            // 
            // nomobrDataGridViewTextBoxColumn
            // 
            this.nomobrDataGridViewTextBoxColumn.DataPropertyName = "nom_obr";
            this.nomobrDataGridViewTextBoxColumn.HeaderText = "nom_obr";
            this.nomobrDataGridViewTextBoxColumn.Name = "nomobrDataGridViewTextBoxColumn";
            // 
            // dirobrDataGridViewTextBoxColumn
            // 
            this.dirobrDataGridViewTextBoxColumn.DataPropertyName = "dir_obr";
            this.dirobrDataGridViewTextBoxColumn.HeaderText = "dir_obr";
            this.dirobrDataGridViewTextBoxColumn.Name = "dirobrDataGridViewTextBoxColumn";
            // 
            // fiobrDataGridViewTextBoxColumn
            // 
            this.fiobrDataGridViewTextBoxColumn.DataPropertyName = "fi_obr";
            this.fiobrDataGridViewTextBoxColumn.HeaderText = "fi_obr";
            this.fiobrDataGridViewTextBoxColumn.Name = "fiobrDataGridViewTextBoxColumn";
            // 
            // ftobrDataGridViewTextBoxColumn
            // 
            this.ftobrDataGridViewTextBoxColumn.DataPropertyName = "ft_obr";
            this.ftobrDataGridViewTextBoxColumn.HeaderText = "ft_obr";
            this.ftobrDataGridViewTextBoxColumn.Name = "ftobrDataGridViewTextBoxColumn";
            // 
            // fteobrDataGridViewTextBoxColumn
            // 
            this.fteobrDataGridViewTextBoxColumn.DataPropertyName = "fte_obr";
            this.fteobrDataGridViewTextBoxColumn.HeaderText = "fte_obr";
            this.fteobrDataGridViewTextBoxColumn.Name = "fteobrDataGridViewTextBoxColumn";
            // 
            // monobrDataGridViewTextBoxColumn
            // 
            this.monobrDataGridViewTextBoxColumn.DataPropertyName = "mon_obr";
            this.monobrDataGridViewTextBoxColumn.HeaderText = "mon_obr";
            this.monobrDataGridViewTextBoxColumn.Name = "monobrDataGridViewTextBoxColumn";
            // 
            // estobrDataGridViewTextBoxColumn
            // 
            this.estobrDataGridViewTextBoxColumn.DataPropertyName = "est_obr";
            this.estobrDataGridViewTextBoxColumn.HeaderText = "est_obr";
            this.estobrDataGridViewTextBoxColumn.Name = "estobrDataGridViewTextBoxColumn";
            // 
            // ciuobrDataGridViewTextBoxColumn
            // 
            this.ciuobrDataGridViewTextBoxColumn.DataPropertyName = "ciu_obr";
            this.ciuobrDataGridViewTextBoxColumn.HeaderText = "ciu_obr";
            this.ciuobrDataGridViewTextBoxColumn.Name = "ciuobrDataGridViewTextBoxColumn";
            // 
            // cliobrDataGridViewTextBoxColumn
            // 
            this.cliobrDataGridViewTextBoxColumn.DataPropertyName = "cli_obr";
            this.cliobrDataGridViewTextBoxColumn.HeaderText = "cli_obr";
            this.cliobrDataGridViewTextBoxColumn.Name = "cliobrDataGridViewTextBoxColumn";
            // 
            // cKEDataSet3
            // 
            this.cKEDataSet3.DataSetName = "CKEDataSet3";
            this.cKEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.cKEDataSet3;
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // numciuDataGridViewTextBoxColumn
            // 
            this.numciuDataGridViewTextBoxColumn.DataPropertyName = "num_ciu";
            this.numciuDataGridViewTextBoxColumn.HeaderText = "num_ciu";
            this.numciuDataGridViewTextBoxColumn.Name = "numciuDataGridViewTextBoxColumn";
            // 
            // nomciuDataGridViewTextBoxColumn
            // 
            this.nomciuDataGridViewTextBoxColumn.DataPropertyName = "nom_ciu";
            this.nomciuDataGridViewTextBoxColumn.HeaderText = "nom_ciu";
            this.nomciuDataGridViewTextBoxColumn.Name = "nomciuDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 561);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Listado Completo";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKEDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CKEDataSet cKEDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private CKEDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcempDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CKEDataSet1 cKEDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private CKEDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dircliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foncliDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private CKEDataSet2 cKEDataSet2;
        private System.Windows.Forms.BindingSource obraBindingSource;
        private CKEDataSet2TableAdapters.ObraTableAdapter obraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fteobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciuobrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliobrDataGridViewTextBoxColumn;
        private CKEDataSet3 cKEDataSet3;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        private CKEDataSet3TableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numciuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomciuDataGridViewTextBoxColumn;
    }
}