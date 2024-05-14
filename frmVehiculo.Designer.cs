namespace pryEtapa5
{
    partial class frmVehiculo
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
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.pctVehiculo = new System.Windows.Forms.PictureBox();
            this.btnCrearVehiculo = new System.Windows.Forms.Button();
            this.lblNombreVehiculo = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::pryEtapa5.Properties.Resources.logo;
            this.pctLogo.Location = new System.Drawing.Point(220, -11);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(120, 120);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(96, 112);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(377, 42);
            this.lblInstruccion.TabIndex = 1;
            this.lblInstruccion.Text = "Por favor, selecciona la opción Crear Vehiculo \r\npara comenzar a crear vehículos " +
    "aleatoriamente.";
            this.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctVehiculo
            // 
            this.pctVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.pctVehiculo.Location = new System.Drawing.Point(109, 171);
            this.pctVehiculo.Name = "pctVehiculo";
            this.pctVehiculo.Size = new System.Drawing.Size(350, 313);
            this.pctVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVehiculo.TabIndex = 2;
            this.pctVehiculo.TabStop = false;
            // 
            // btnCrearVehiculo
            // 
            this.btnCrearVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVehiculo.Location = new System.Drawing.Point(339, 495);
            this.btnCrearVehiculo.Name = "btnCrearVehiculo";
            this.btnCrearVehiculo.Size = new System.Drawing.Size(120, 33);
            this.btnCrearVehiculo.TabIndex = 3;
            this.btnCrearVehiculo.Text = "Crear Vehiculo";
            this.btnCrearVehiculo.UseVisualStyleBackColor = true;
            this.btnCrearVehiculo.Click += new System.EventHandler(this.btnCrearVehiculo_Click);
            // 
            // lblNombreVehiculo
            // 
            this.lblNombreVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVehiculo.Location = new System.Drawing.Point(106, 487);
            this.lblNombreVehiculo.Name = "lblNombreVehiculo";
            this.lblNombreVehiculo.Size = new System.Drawing.Size(200, 23);
            this.lblNombreVehiculo.TabIndex = 4;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(106, 510);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(200, 23);
            this.lblTipoVehiculo.TabIndex = 5;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEtapa5.Properties.Resources.frmInicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblNombreVehiculo);
            this.Controls.Add(this.btnCrearVehiculo);
            this.Controls.Add(this.pctVehiculo);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.pctLogo);
            this.Location = new System.Drawing.Point(58, 100);
            this.MaximizeBox = false;
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear vehículo aleatoriamente";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.PictureBox pctVehiculo;
        private System.Windows.Forms.Button btnCrearVehiculo;
        private System.Windows.Forms.Label lblNombreVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
    }
}

