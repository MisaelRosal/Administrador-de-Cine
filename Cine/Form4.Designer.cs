namespace Cine
{
    partial class Form4
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
            this.salaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineDataSet1 = new Cine.CineDataSet1();
            this.salaTableAdapter = new Cine.CineDataSet1TableAdapters.SalaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAsientosOcu = new System.Windows.Forms.TextBox();
            this.txtAsientosD = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.ID_Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsientosD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsientosO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Sala,
            this.Capacidad,
            this.AsientosD,
            this.AsientosO});
            this.dataGridView1.DataSource = this.salaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(229, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // salaBindingSource
            // 
            this.salaBindingSource.DataMember = "Sala";
            this.salaBindingSource.DataSource = this.cineDataSet1;
            // 
            // cineDataSet1
            // 
            this.cineDataSet1.DataSetName = "CineDataSet1";
            this.cineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaTableAdapter
            // 
            this.salaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 50);
            this.button2.TabIndex = 27;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Asientos disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Asientos ocupados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Capacidad";
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(129, 162);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(94, 50);
            this.Eliminar.TabIndex = 21;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtAsientosOcu
            // 
            this.txtAsientosOcu.Location = new System.Drawing.Point(12, 134);
            this.txtAsientosOcu.Name = "txtAsientosOcu";
            this.txtAsientosOcu.Size = new System.Drawing.Size(211, 22);
            this.txtAsientosOcu.TabIndex = 17;
            // 
            // txtAsientosD
            // 
            this.txtAsientosD.Location = new System.Drawing.Point(12, 78);
            this.txtAsientosD.Name = "txtAsientosD";
            this.txtAsientosD.Size = new System.Drawing.Size(211, 22);
            this.txtAsientosD.TabIndex = 16;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(12, 24);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(211, 22);
            this.txtCapacidad.TabIndex = 15;
            // 
            // ID_Sala
            // 
            this.ID_Sala.DataPropertyName = "ID_Sala";
            this.ID_Sala.HeaderText = "ID_Sala";
            this.ID_Sala.MinimumWidth = 6;
            this.ID_Sala.Name = "ID_Sala";
            this.ID_Sala.Width = 125;
            // 
            // Capacidad
            // 
            this.Capacidad.DataPropertyName = "Capacidad";
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.MinimumWidth = 6;
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Width = 125;
            // 
            // AsientosD
            // 
            this.AsientosD.DataPropertyName = "Asientos disponibles";
            this.AsientosD.HeaderText = "Asientos disponibles";
            this.AsientosD.MinimumWidth = 6;
            this.AsientosD.Name = "AsientosD";
            this.AsientosD.Width = 125;
            // 
            // AsientosO
            // 
            this.AsientosO.DataPropertyName = "Asientos ocupados";
            this.AsientosO.HeaderText = "Asientos ocupados";
            this.AsientosO.MinimumWidth = 6;
            this.AsientosO.Name = "AsientosO";
            this.AsientosO.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAsientosOcu);
            this.Controls.Add(this.txtAsientosD);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Administrador de Salas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CineDataSet1 cineDataSet1;
        private System.Windows.Forms.BindingSource salaBindingSource;
        private CineDataSet1TableAdapters.SalaTableAdapter salaTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAsientosOcu;
        private System.Windows.Forms.TextBox txtAsientosD;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsientosD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsientosO;
    }
}