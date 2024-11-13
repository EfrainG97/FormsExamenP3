namespace FormsExamenP3
{
    partial class Form1
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
            this.DGVViedo = new System.Windows.Forms.DataGridView();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.TBGenero = new System.Windows.Forms.TextBox();
            this.TBPlataforma = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.TBID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViedo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVViedo
            // 
            this.DGVViedo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViedo.Location = new System.Drawing.Point(288, 25);
            this.DGVViedo.Name = "DGVViedo";
            this.DGVViedo.RowHeadersWidth = 51;
            this.DGVViedo.RowTemplate.Height = 24;
            this.DGVViedo.Size = new System.Drawing.Size(660, 441);
            this.DGVViedo.TabIndex = 0;
            // 
            // TBTitulo
            // 
            this.TBTitulo.Location = new System.Drawing.Point(30, 47);
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.Size = new System.Drawing.Size(196, 22);
            this.TBTitulo.TabIndex = 1;
            // 
            // TBGenero
            // 
            this.TBGenero.Location = new System.Drawing.Point(30, 108);
            this.TBGenero.Name = "TBGenero";
            this.TBGenero.Size = new System.Drawing.Size(196, 22);
            this.TBGenero.TabIndex = 2;
            // 
            // TBPlataforma
            // 
            this.TBPlataforma.Location = new System.Drawing.Point(30, 168);
            this.TBPlataforma.Name = "TBPlataforma";
            this.TBPlataforma.Size = new System.Drawing.Size(196, 22);
            this.TBPlataforma.TabIndex = 3;
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(30, 227);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(196, 22);
            this.TBPrecio.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(40, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Plataforma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 24);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(147, 281);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 24);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(153, 366);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(116, 43);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar Videojuego";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(23, 366);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(105, 43);
            this.BtnCargar.TabIndex = 15;
            this.BtnCargar.Text = "Cargar Videojuego";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(53, 338);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(162, 22);
            this.TBID.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Actualizar Tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.TBPlataforma);
            this.Controls.Add(this.TBGenero);
            this.Controls.Add(this.TBTitulo);
            this.Controls.Add(this.DGVViedo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVViedo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVViedo;
        private System.Windows.Forms.TextBox TBTitulo;
        private System.Windows.Forms.TextBox TBGenero;
        private System.Windows.Forms.TextBox TBPlataforma;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Button button1;
    }
}

