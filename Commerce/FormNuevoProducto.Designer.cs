namespace Commerce
{
    partial class FormNuevoProducto
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.imgCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.imgTitulo = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorDatoObligatorio = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudStockInicial = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatoObligatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pnlSuperior.Controls.Add(this.imgCerrar);
            this.pnlSuperior.Controls.Add(this.lblTituloFormulario);
            this.pnlSuperior.Controls.Add(this.imgTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlSuperior.Size = new System.Drawing.Size(608, 65);
            this.pnlSuperior.TabIndex = 3;
            // 
            // imgCerrar
            // 
            this.imgCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.imgCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.imgCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgCerrar.IconSize = 38;
            this.imgCerrar.Location = new System.Drawing.Point(550, 15);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(40, 38);
            this.imgCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCerrar.TabIndex = 6;
            this.imgCerrar.TabStop = false;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblTituloFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTituloFormulario.Location = new System.Drawing.Point(60, 14);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblTituloFormulario.Size = new System.Drawing.Size(256, 40);
            this.lblTituloFormulario.TabIndex = 3;
            this.lblTituloFormulario.Text = "Nuevo Producto";
            this.lblTituloFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgTitulo
            // 
            this.imgTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.imgTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgTitulo.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.imgTitulo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imgTitulo.IconSize = 40;
            this.imgTitulo.Location = new System.Drawing.Point(14, 14);
            this.imgTitulo.Name = "imgTitulo";
            this.imgTitulo.Size = new System.Drawing.Size(40, 40);
            this.imgTitulo.TabIndex = 2;
            this.imgTitulo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(608, 77);
            this.panel1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(320, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Rotation = 0D;
            this.btnCancelar.Size = new System.Drawing.Size(166, 45);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(132, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Rotation = 0D;
            this.btnGuardar.Size = new System.Drawing.Size(166, 45);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo";
            // 
            // errorDatoObligatorio
            // 
            this.errorDatoObligatorio.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Precio";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(153, 220);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(180, 26);
            this.nudPrecio.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(153, 95);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(178, 26);
            this.txtCodigo.TabIndex = 15;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(153, 138);
            this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(180, 26);
            this.txtCodigoBarra.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(153, 180);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(384, 26);
            this.txtDescripcion.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Codigo de Barra";
            // 
            // nudStockInicial
            // 
            this.nudStockInicial.Location = new System.Drawing.Point(153, 256);
            this.nudStockInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudStockInicial.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudStockInicial.Name = "nudStockInicial";
            this.nudStockInicial.Size = new System.Drawing.Size(180, 26);
            this.nudStockInicial.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Stock Inicial";
            // 
            // FormNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 405);
            this.ControlBox = false;
            this.Controls.Add(this.nudStockInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(608, 360);
            this.Name = "FormNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorDatoObligatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloFormulario;
        private FontAwesome.Sharp.IconPictureBox imgTitulo;
        private FontAwesome.Sharp.IconPictureBox imgCerrar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorDatoObligatorio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.NumericUpDown nudStockInicial;
        private System.Windows.Forms.Label label5;
    }
}