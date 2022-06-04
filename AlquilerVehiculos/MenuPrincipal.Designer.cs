namespace AlquilerVehiculos
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresarAuto = new System.Windows.Forms.Button();
            this.btnIngresarPersona = new System.Windows.Forms.Button();
            this.btnEliminarMenu = new System.Windows.Forms.Button();
            this.btnBuscarPlaca = new System.Windows.Forms.Button();
            this.btnCalcularRecibo = new System.Windows.Forms.Button();
            this.btnMesAlquiler = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDprecioKM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDprecioKM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(75, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÚ ALQUILER DE VEHICULOS";
            // 
            // btnIngresarAuto
            // 
            this.btnIngresarAuto.BackColor = System.Drawing.Color.Tan;
            this.btnIngresarAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAuto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresarAuto.Location = new System.Drawing.Point(65, 175);
            this.btnIngresarAuto.Name = "btnIngresarAuto";
            this.btnIngresarAuto.Size = new System.Drawing.Size(150, 84);
            this.btnIngresarAuto.TabIndex = 1;
            this.btnIngresarAuto.Text = "Ingresar Vehiculo";
            this.btnIngresarAuto.UseVisualStyleBackColor = false;
            this.btnIngresarAuto.Click += new System.EventHandler(this.btnIngresarAuto_Click);
            // 
            // btnIngresarPersona
            // 
            this.btnIngresarPersona.BackColor = System.Drawing.Color.Tan;
            this.btnIngresarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPersona.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresarPersona.Location = new System.Drawing.Point(558, 175);
            this.btnIngresarPersona.Name = "btnIngresarPersona";
            this.btnIngresarPersona.Size = new System.Drawing.Size(159, 84);
            this.btnIngresarPersona.TabIndex = 3;
            this.btnIngresarPersona.Text = "Ingreso de Personas";
            this.btnIngresarPersona.UseVisualStyleBackColor = false;
            this.btnIngresarPersona.Click += new System.EventHandler(this.btnIngresarPersona_Click);
            // 
            // btnEliminarMenu
            // 
            this.btnEliminarMenu.BackColor = System.Drawing.Color.Tan;
            this.btnEliminarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarMenu.Location = new System.Drawing.Point(65, 309);
            this.btnEliminarMenu.Name = "btnEliminarMenu";
            this.btnEliminarMenu.Size = new System.Drawing.Size(150, 72);
            this.btnEliminarMenu.TabIndex = 4;
            this.btnEliminarMenu.Text = "Eliminar (personas y vehiculos)";
            this.btnEliminarMenu.UseVisualStyleBackColor = false;
            this.btnEliminarMenu.Click += new System.EventHandler(this.btnEliminarMenu_Click);
            // 
            // btnBuscarPlaca
            // 
            this.btnBuscarPlaca.BackColor = System.Drawing.Color.Tan;
            this.btnBuscarPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPlaca.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarPlaca.Location = new System.Drawing.Point(332, 309);
            this.btnBuscarPlaca.Name = "btnBuscarPlaca";
            this.btnBuscarPlaca.Size = new System.Drawing.Size(147, 72);
            this.btnBuscarPlaca.TabIndex = 5;
            this.btnBuscarPlaca.Text = "Buscar por Placa";
            this.btnBuscarPlaca.UseVisualStyleBackColor = false;
            this.btnBuscarPlaca.Click += new System.EventHandler(this.btnBuscarPlaca_Click);
            // 
            // btnCalcularRecibo
            // 
            this.btnCalcularRecibo.BackColor = System.Drawing.Color.Tan;
            this.btnCalcularRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularRecibo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcularRecibo.Location = new System.Drawing.Point(558, 309);
            this.btnCalcularRecibo.Name = "btnCalcularRecibo";
            this.btnCalcularRecibo.Size = new System.Drawing.Size(159, 81);
            this.btnCalcularRecibo.TabIndex = 6;
            this.btnCalcularRecibo.Text = "Calcular recibo de pago";
            this.btnCalcularRecibo.UseVisualStyleBackColor = false;
            this.btnCalcularRecibo.Click += new System.EventHandler(this.btnCalcularRecibo_Click);
            // 
            // btnMesAlquiler
            // 
            this.btnMesAlquiler.BackColor = System.Drawing.Color.Tan;
            this.btnMesAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesAlquiler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMesAlquiler.Location = new System.Drawing.Point(65, 433);
            this.btnMesAlquiler.Name = "btnMesAlquiler";
            this.btnMesAlquiler.Size = new System.Drawing.Size(150, 73);
            this.btnMesAlquiler.TabIndex = 7;
            this.btnMesAlquiler.Text = "Vehiculos alquilados por mes";
            this.btnMesAlquiler.UseVisualStyleBackColor = false;
            this.btnMesAlquiler.Click += new System.EventHandler(this.btnMesAlquiler_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Tan;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.Location = new System.Drawing.Point(332, 433);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 73);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tan;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(558, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 73);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(311, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "   Ingrese Precio \r\ndel KILOMERTRAJE";
            // 
            // NUDprecioKM
            // 
            this.NUDprecioKM.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDprecioKM.Location = new System.Drawing.Point(332, 239);
            this.NUDprecioKM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDprecioKM.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDprecioKM.Name = "NUDprecioKM";
            this.NUDprecioKM.Size = new System.Drawing.Size(126, 20);
            this.NUDprecioKM.TabIndex = 11;
            this.NUDprecioKM.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerVehiculos.Properties.Resources.posters_engranajes_fondo_del_vector_jpg;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.NUDprecioKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnMesAlquiler);
            this.Controls.Add(this.btnCalcularRecibo);
            this.Controls.Add(this.btnBuscarPlaca);
            this.Controls.Add(this.btnEliminarMenu);
            this.Controls.Add(this.btnIngresarPersona);
            this.Controls.Add(this.btnIngresarAuto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALQUILER DE VEHICULOS";
            ((System.ComponentModel.ISupportInitialize)(this.NUDprecioKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarAuto;
        private System.Windows.Forms.Button btnIngresarPersona;
        private System.Windows.Forms.Button btnEliminarMenu;
        private System.Windows.Forms.Button btnBuscarPlaca;
        private System.Windows.Forms.Button btnCalcularRecibo;
        private System.Windows.Forms.Button btnMesAlquiler;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDprecioKM;
    }
}

