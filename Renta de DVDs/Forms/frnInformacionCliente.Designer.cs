namespace Renta_de_DVDs.Forms
{
    partial class frnInformacionCliente
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
            this.btnEliminarCliente = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtDireccion2 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtDireccion1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigoPostal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarCliente.IconColor = System.Drawing.Color.Black;
            this.btnEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.Location = new System.Drawing.Point(429, 601);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(161, 58);
            this.btnEliminarCliente.TabIndex = 90;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarPelicula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 28);
            this.label3.TabIndex = 89;
            this.label3.Text = "Información Cliente";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(441, 425);
            this.txtPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPais.Name = "txtPais";
            this.txtPais.ReadOnly = true;
            this.txtPais.Size = new System.Drawing.Size(381, 32);
            this.txtPais.TabIndex = 88;
            this.txtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(186, 424);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(52, 23);
            this.label41.TabIndex = 87;
            this.label41.Text = "Pais:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(441, 378);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(381, 32);
            this.txtCiudad.TabIndex = 86;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(186, 379);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(88, 23);
            this.label40.TabIndex = 85;
            this.label40.Text = "Ciudad:";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrito.Location = new System.Drawing.Point(441, 331);
            this.txtDistrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.ReadOnly = true;
            this.txtDistrito.Size = new System.Drawing.Size(381, 32);
            this.txtDistrito.TabIndex = 84;
            this.txtDistrito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(186, 334);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(77, 23);
            this.label39.TabIndex = 83;
            this.label39.Text = "Distrito:";
            // 
            // txtDireccion2
            // 
            this.txtDireccion2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion2.Location = new System.Drawing.Point(441, 284);
            this.txtDireccion2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion2.Name = "txtDireccion2";
            this.txtDireccion2.ReadOnly = true;
            this.txtDireccion2.Size = new System.Drawing.Size(381, 32);
            this.txtDireccion2.TabIndex = 82;
            this.txtDireccion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(186, 289);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(123, 23);
            this.label38.TabIndex = 81;
            this.label38.Text = "Dirección 2:";
            // 
            // txtDireccion1
            // 
            this.txtDireccion1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion1.Location = new System.Drawing.Point(441, 237);
            this.txtDireccion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion1.Name = "txtDireccion1";
            this.txtDireccion1.ReadOnly = true;
            this.txtDireccion1.Size = new System.Drawing.Size(381, 32);
            this.txtDireccion1.TabIndex = 80;
            this.txtDireccion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(186, 244);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 23);
            this.label21.TabIndex = 79;
            this.label21.Text = "Dirección 1:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(441, 190);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(381, 32);
            this.txtEmail.TabIndex = 78;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(186, 199);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 23);
            this.label20.TabIndex = 77;
            this.label20.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(441, 103);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(382, 32);
            this.txtNombre.TabIndex = 74;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(189, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 23);
            this.label15.TabIndex = 73;
            this.label15.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(441, 519);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(381, 32);
            this.txtTelefono.TabIndex = 94;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 93;
            this.label2.Text = "Teléfono";
            // 
            // txtcodigoPostal
            // 
            this.txtcodigoPostal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoPostal.Location = new System.Drawing.Point(441, 472);
            this.txtcodigoPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigoPostal.Name = "txtcodigoPostal";
            this.txtcodigoPostal.ReadOnly = true;
            this.txtcodigoPostal.Size = new System.Drawing.Size(381, 32);
            this.txtcodigoPostal.TabIndex = 92;
            this.txtcodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 91;
            this.label4.Text = "Código Postal:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(441, 149);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(382, 32);
            this.txtApellido.TabIndex = 95;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 96;
            this.label1.Text = "Apellido:";
            // 
            // frnInformacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigoPostal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.txtDistrito);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.txtDireccion2);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.txtDireccion1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label15);
            this.Name = "frnInformacionCliente";
            this.Text = "Información Cliente";
            this.Load += new System.EventHandler(this.frnInformacionCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEliminarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtDireccion2;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtDireccion1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigoPostal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
    }
}