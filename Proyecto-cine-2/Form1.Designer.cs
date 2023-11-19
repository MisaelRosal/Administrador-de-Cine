namespace Proyecto_cine_2
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.texUser = new System.Windows.Forms.TextBox();
            this.texPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btIngresar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lberror = new System.Windows.Forms.Label();
            this.Btminizar = new System.Windows.Forms.PictureBox();
            this.Btcerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btminizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(156)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 594);
            this.panel1.TabIndex = 0;
            // 
            // texUser
            // 
            this.texUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.texUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texUser.ForeColor = System.Drawing.Color.DimGray;
            this.texUser.Location = new System.Drawing.Point(522, 109);
            this.texUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.texUser.Multiline = true;
            this.texUser.Name = "texUser";
            this.texUser.Size = new System.Drawing.Size(583, 36);
            this.texUser.TabIndex = 1;
            this.texUser.Text = "Usuario";
            this.texUser.Enter += new System.EventHandler(this.texUser_Enter);
            this.texUser.Leave += new System.EventHandler(this.texUser_Leave);
            // 
            // texPassword
            // 
            this.texPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.texPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texPassword.ForeColor = System.Drawing.Color.DimGray;
            this.texPassword.Location = new System.Drawing.Point(522, 256);
            this.texPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.texPassword.Multiline = true;
            this.texPassword.Name = "texPassword";
            this.texPassword.Size = new System.Drawing.Size(583, 36);
            this.texPassword.TabIndex = 2;
            this.texPassword.Text = "password";
            this.texPassword.Enter += new System.EventHandler(this.texPassword_Enter);
            this.texPassword.Leave += new System.EventHandler(this.texPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(702, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "CINEMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btIngresar.FlatAppearance.BorderSize = 0;
            this.btIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresar.ForeColor = System.Drawing.Color.LightGray;
            this.btIngresar.Location = new System.Drawing.Point(522, 422);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(583, 58);
            this.btIngresar.TabIndex = 3;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(522, 523);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(310, 30);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Conviertete en miembro";
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror.ForeColor = System.Drawing.Color.OrangeRed;
            this.lberror.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lberror.Location = new System.Drawing.Point(522, 339);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(176, 29);
            this.lberror.TabIndex = 10;
            this.lberror.Text = "ErrorMessage";
            this.lberror.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lberror.Visible = false;
            // 
            // Btminizar
            // 
            this.Btminizar.Image = ((System.Drawing.Image)(resources.GetObject("Btminizar.Image")));
            this.Btminizar.Location = new System.Drawing.Point(1070, 8);
            this.Btminizar.Name = "Btminizar";
            this.Btminizar.Size = new System.Drawing.Size(75, 50);
            this.Btminizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btminizar.TabIndex = 9;
            this.Btminizar.TabStop = false;
            this.Btminizar.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Btcerrar
            // 
            this.Btcerrar.Image = global::Proyecto_cine_2.Properties.Resources.cross;
            this.Btcerrar.Location = new System.Drawing.Point(1151, 8);
            this.Btcerrar.Name = "Btcerrar";
            this.Btcerrar.Size = new System.Drawing.Size(75, 50);
            this.Btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btcerrar.TabIndex = 8;
            this.Btcerrar.TabStop = false;
            this.Btcerrar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(522, 300);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(583, 6);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(522, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 6);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1240, 594);
            this.Controls.Add(this.lberror);
            this.Controls.Add(this.Btminizar);
            this.Controls.Add(this.Btcerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texPassword);
            this.Controls.Add(this.texUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-1";
            ((System.ComponentModel.ISupportInitialize)(this.Btminizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox texUser;
        private System.Windows.Forms.TextBox texPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox Btcerrar;
        private System.Windows.Forms.PictureBox Btminizar;
        private System.Windows.Forms.Label lberror;
    }
}

