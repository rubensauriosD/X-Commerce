namespace Commerce
{
    partial class FormEliminarItem
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.imgCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.imgTitulo = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.nudStockInicial = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnlSuperior.Size = new System.Drawing.Size(405, 65);
            this.pnlSuperior.TabIndex = 25;
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
            this.imgCerrar.Location = new System.Drawing.Point(347, 13);
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
            this.lblTituloFormulario.Location = new System.Drawing.Point(60, 12);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblTituloFormulario.Size = new System.Drawing.Size(272, 40);
            this.lblTituloFormulario.TabIndex = 3;
            this.lblTituloFormulario.Text = "Eliminar Items";
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
            this.imgTitulo.Location = new System.Drawing.Point(14, 12);
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
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(405, 77);
            this.panel1.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(211, 17);
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
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(23, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Rotation = 0D;
            this.btnGuardar.Size = new System.Drawing.Size(166, 45);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // nudStockInicial
            // 
            this.nudStockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockInicial.Location = new System.Drawing.Point(177, 86);
            this.nudStockInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudStockInicial.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudStockInicial.Name = "nudStockInicial";
            this.nudStockInicial.Size = new System.Drawing.Size(180, 39);
            this.nudStockInicial.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cantidad";
            // 
            // FormEliminarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 221);
            this.Controls.Add(this.nudStockInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(405, 221);
            this.MinimumSize = new System.Drawing.Size(405, 221);
            this.Name = "FormEliminarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Items";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStockInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private FontAwesome.Sharp.IconPictureBox imgCerrar;
        private System.Windows.Forms.Label lblTituloFormulario;
        private FontAwesome.Sharp.IconPictureBox imgTitulo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.NumericUpDown nudStockInicial;
        private System.Windows.Forms.Label label5;
    }
}