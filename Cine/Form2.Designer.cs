namespace Cine
{
    partial class Form2
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
            this.cineDataSet1 = new Cine.CineDataSet1();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Cine.CineDataSet1TableAdapters.UsuarioTableAdapter();
            this.cineDataSet2 = new Cine.CineDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TiempoInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carteleraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtTiempoInicio = new System.Windows.Forms.TextBox();
            this.txtTiempoFinal = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.carteleraTableAdapter = new Cine.CineDataSet1TableAdapters.CarteleraTableAdapter();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carteleraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cineDataSet1
            // 
            this.cineDataSet1.DataSetName = "CineDataSet1";
            this.cineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.cineDataSet1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cineDataSet2
            // 
            this.cineDataSet2.DataSetName = "CineDataSet";
            this.cineDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TiempoInicio,
            this.TiempoFinal,
            this.Genero});
            this.dataGridView1.DataSource = this.carteleraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(247, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // TiempoInicio
            // 
            this.TiempoInicio.DataPropertyName = "TiempoInicio";
            this.TiempoInicio.HeaderText = "TiempoInicio";
            this.TiempoInicio.MinimumWidth = 6;
            this.TiempoInicio.Name = "TiempoInicio";
            this.TiempoInicio.Width = 125;
            // 
            // TiempoFinal
            // 
            this.TiempoFinal.DataPropertyName = "TiempoFinal";
            this.TiempoFinal.HeaderText = "TiempoFinal";
            this.TiempoFinal.MinimumWidth = 6;
            this.TiempoFinal.Name = "TiempoFinal";
            this.TiempoFinal.Width = 125;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.Width = 125;
            // 
            // carteleraBindingSource
            // 
            this.carteleraBindingSource.DataMember = "Cartelera";
            this.carteleraBindingSource.DataSource = this.cineDataSet1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(12, 79);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(211, 22);
            this.txtDuracion.TabIndex = 2;
            // 
            // txtTiempoInicio
            // 
            this.txtTiempoInicio.Location = new System.Drawing.Point(12, 135);
            this.txtTiempoInicio.Name = "txtTiempoInicio";
            this.txtTiempoInicio.Size = new System.Drawing.Size(211, 22);
            this.txtTiempoInicio.TabIndex = 3;
            // 
            // txtTiempoFinal
            // 
            this.txtTiempoFinal.Location = new System.Drawing.Point(12, 192);
            this.txtTiempoFinal.Name = "txtTiempoFinal";
            this.txtTiempoFinal.Size = new System.Drawing.Size(211, 22);
            this.txtTiempoFinal.TabIndex = 4;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(12, 248);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(211, 22);
            this.txtGenero.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // carteleraTableAdapter
            // 
            this.carteleraTableAdapter.ClearBeforeFill = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(129, 276);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(94, 50);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de la pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hora de finalizar de la pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hora de inicio de la pelicula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Duración de la pelicula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Genero de la pelicula";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTiempoFinal);
            this.Controls.Add(this.txtTiempoInicio);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Administrador de cartelera";
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carteleraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CineDataSet1 cineDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private CineDataSet1TableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private CineDataSet cineDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtTiempoInicio;
        private System.Windows.Forms.TextBox txtTiempoFinal;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource carteleraBindingSource;
        private CineDataSet1TableAdapters.CarteleraTableAdapter carteleraTableAdapter;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
    }
}