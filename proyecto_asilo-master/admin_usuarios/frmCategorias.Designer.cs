namespace admin_us
{
    partial class frmCategorias
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
            this.txtAgregar = new System.Windows.Forms.Button();
            this.txtActualizar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_asiloDataSet = new admin_us.db_asiloDataSet();
            this.tb_tipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_tipoTableAdapter();
            this.tableAdapterManager = new admin_us.db_asiloDataSetTableAdapters.TableAdapterManager();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAgregar
            // 
            this.txtAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.txtAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregar.ForeColor = System.Drawing.Color.White;
            this.txtAgregar.Location = new System.Drawing.Point(84, 332);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(150, 47);
            this.txtAgregar.TabIndex = 0;
            this.txtAgregar.Text = "Agregar";
            this.txtAgregar.UseVisualStyleBackColor = false;
            this.txtAgregar.Click += new System.EventHandler(this.txtAgregar_Click);
            // 
            // txtActualizar
            // 
            this.txtActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(199)))), ((int)(((byte)(56)))));
            this.txtActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualizar.ForeColor = System.Drawing.Color.White;
            this.txtActualizar.Location = new System.Drawing.Point(256, 332);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(150, 47);
            this.txtActualizar.TabIndex = 1;
            this.txtActualizar.Text = "Actualizar";
            this.txtActualizar.UseVisualStyleBackColor = false;
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.ForeColor = System.Drawing.Color.White;
            this.txtEliminar.Location = new System.Drawing.Point(426, 332);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(150, 47);
            this.txtEliminar.TabIndex = 2;
            this.txtEliminar.Text = "Eliminar";
            this.txtEliminar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_tipoBindingSource, "nombre", true));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(17, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(458, 23);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Location = new System.Drawing.Point(84, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 54);
            this.panel2.TabIndex = 12;
            // 
            // tb_tipoBindingSource
            // 
            this.tb_tipoBindingSource.DataMember = "tb_tipo";
            this.tb_tipoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // db_asiloDataSet
            // 
            this.db_asiloDataSet.DataSetName = "db_asiloDataSet";
            this.db_asiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_tipoTableAdapter
            // 
            this.tb_tipoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_bodegaTableAdapter = null;
            this.tableAdapterManager.tb_donacionTableAdapter = null;
            this.tableAdapterManager.tb_ingresosTableAdapter = null;
            this.tableAdapterManager.tb_inventarioTableAdapter = null;
            this.tableAdapterManager.tb_objetoTableAdapter = null;
            this.tableAdapterManager.tb_salidasTableAdapter = null;
            this.tableAdapterManager.tb_subtipoTableAdapter = null;
            this.tableAdapterManager.tb_tipoTableAdapter = this.tb_tipoTableAdapter;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = admin_us.db_asiloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.comboBox2);
            this.panel7.Location = new System.Drawing.Point(84, 220);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(492, 54);
            this.panel7.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "usuario";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(45, 10);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(441, 33);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.ValueMember = "usuario";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 426);
            this.ControlBox = false;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtActualizar);
            this.Controls.Add(this.txtAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtAgregar;
        private System.Windows.Forms.Button txtActualizar;
        private System.Windows.Forms.Button txtEliminar;
        private db_asiloDataSet db_asiloDataSet;
        private System.Windows.Forms.BindingSource tb_tipoBindingSource;
        private db_asiloDataSetTableAdapters.tb_tipoTableAdapter tb_tipoTableAdapter;
        private db_asiloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}