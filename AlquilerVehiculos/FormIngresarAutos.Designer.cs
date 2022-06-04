namespace AlquilerVehiculos
{
    partial class FormIngresarAutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresarAutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarAuto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKMinicial = new System.Windows.Forms.TextBox();
            this.txtDescripcionAuto = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.btnRegistrarAuto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtKMinicial);
            this.panel1.Controls.Add(this.txtDescripcionAuto);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(41, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 310);
            this.panel1.TabIndex = 2;
            // 
            // btnRegistrarAuto
            // 
            this.btnRegistrarAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAuto.Location = new System.Drawing.Point(557, 254);
            this.btnRegistrarAuto.Name = "btnRegistrarAuto";
            this.btnRegistrarAuto.Size = new System.Drawing.Size(131, 41);
            this.btnRegistrarAuto.TabIndex = 7;
            this.btnRegistrarAuto.Text = "REGISTRAR";
            this.btnRegistrarAuto.UseVisualStyleBackColor = true;
            this.btnRegistrarAuto.Click += new System.EventHandler(this.btnRegistrarAuto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 43);
            this.label5.TabIndex = 6;
            this.label5.Text = "DATOS DEL VEHICULO:";
            // 
            // txtKMinicial
            // 
            this.txtKMinicial.Location = new System.Drawing.Point(264, 265);
            this.txtKMinicial.Name = "txtKMinicial";
            this.txtKMinicial.Size = new System.Drawing.Size(199, 20);
            this.txtKMinicial.TabIndex = 5;
            // 
            // txtDescripcionAuto
            // 
            this.txtDescripcionAuto.Location = new System.Drawing.Point(324, 134);
            this.txtDescripcionAuto.Multiline = true;
            this.txtDescripcionAuto.Name = "txtDescripcionAuto";
            this.txtDescripcionAuto.Size = new System.Drawing.Size(319, 106);
            this.txtDescripcionAuto.TabIndex = 4;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(252, 98);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(164, 20);
            this.txtPlaca.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "KILOMETRAJE INICIAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "DESCRIPCION DEL VEHICULO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLACA DEL VEHICULO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(158, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE VEHICULOS";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(131, 41);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormIngresarAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerVehiculos.Properties.Resources.posters_engranajes_fondo_del_vector_jpg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIngresarAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIngresarAutos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarAuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKMinicial;
        private System.Windows.Forms.TextBox txtDescripcionAuto;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}