namespace ProyectoFarmacia
{
    partial class IngresarClientes
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
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.BtBuscaSp = new System.Windows.Forms.Button();
            this.BtBusca = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet = new ProyectoFarmacia.proyectoDataSet();
            this.clienteTableAdapter2 = new ProyectoFarmacia.proyectoDataSetTableAdapters.clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(603, 434);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(93, 24);
            this.CheckBox1.TabIndex = 35;
            this.CheckBox1.Text = "Habilitar";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button3.Location = new System.Drawing.Point(369, 610);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(112, 35);
            this.Button3.TabIndex = 34;
            this.Button3.Text = "Eliminar";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(369, 536);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(112, 35);
            this.Button2.TabIndex = 33;
            this.Button2.Text = "Actualizar";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(58, 434);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(21, 20);
            this.Label5.TabIndex = 32;
            this.Label5.Text = "id";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(165, 430);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 26);
            this.txtId.TabIndex = 31;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(369, 476);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(112, 35);
            this.Button1.TabIndex = 30;
            this.Button1.Text = "Guardar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(58, 610);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(26, 20);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "nit";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(58, 574);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 20);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "telefono";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(58, 536);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 20);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Direccion";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(58, 491);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 20);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Nombre";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(165, 605);
            this.txtnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(148, 26);
            this.txtnit.TabIndex = 25;
            this.txtnit.TextChanged += new System.EventHandler(this.txtnit_TextChanged);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(165, 570);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(148, 26);
            this.txttelefono.TabIndex = 24;
            this.txttelefono.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(165, 531);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(148, 26);
            this.txtdireccion.TabIndex = 23;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(165, 491);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 26);
            this.txtnombre.TabIndex = 22;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // BtBuscaSp
            // 
            this.BtBuscaSp.Location = new System.Drawing.Point(691, 30);
            this.BtBuscaSp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtBuscaSp.Name = "BtBuscaSp";
            this.BtBuscaSp.Size = new System.Drawing.Size(112, 35);
            this.BtBuscaSp.TabIndex = 21;
            this.BtBuscaSp.Text = "Buscador SP";
            this.BtBuscaSp.UseVisualStyleBackColor = true;
            // 
            // BtBusca
            // 
            this.BtBusca.Location = new System.Drawing.Point(549, 30);
            this.BtBusca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtBusca.Name = "BtBusca";
            this.BtBusca.Size = new System.Drawing.Size(112, 35);
            this.BtBusca.TabIndex = 20;
            this.BtBusca.Text = "Buscador";
            this.BtBusca.UseVisualStyleBackColor = true;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(369, 30);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(148, 26);
            this.txtbusqueda.TabIndex = 19;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.clienteBindingSource2;
            this.DataGridView1.Location = new System.Drawing.Point(59, 74);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(826, 326);
            this.DataGridView1.TabIndex = 18;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "nit";
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "cliente";
            this.clienteBindingSource2.DataSource = this.proyectoDataSet;
            // 
            // proyectoDataSet
            // 
            this.proyectoDataSet.DataSetName = "proyectoDataSet";
            this.proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter2
            // 
            this.clienteTableAdapter2.ClearBeforeFill = true;
            // 
            // IngresarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 739);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.BtBuscaSp);
            this.Controls.Add(this.BtBusca);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.DataGridView1);
            this.Name = "IngresarClientes";
            this.Text = "IngresarClientes";
            this.Load += new System.EventHandler(this.IngresarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtnit;
        internal System.Windows.Forms.TextBox txttelefono;
        internal System.Windows.Forms.TextBox txtdireccion;
        internal System.Windows.Forms.TextBox txtnombre;
        internal System.Windows.Forms.Button BtBuscaSp;
        internal System.Windows.Forms.Button BtBusca;
        internal System.Windows.Forms.TextBox txtbusqueda;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private proyectoDataSet proyectoDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private proyectoDataSetTableAdapters.clienteTableAdapter clienteTableAdapter2;
    }
}