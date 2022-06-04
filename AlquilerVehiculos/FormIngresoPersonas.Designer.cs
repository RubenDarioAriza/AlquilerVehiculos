namespace AlquilerVehiculos
{
    partial class FormIngresoPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoPersonas));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboTipoCliente = new System.Windows.Forms.ComboBox();
            this.btnRegistrarPersonas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombrePropietario = new System.Windows.Forms.TextBox();
            this.txtIDpropietario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(19, 20);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(131, 41);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(165, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "REGISTRO DE PERSONAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.comboTipoCliente);
            this.panel1.Controls.Add(this.btnRegistrarPersonas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNombrePropietario);
            this.panel1.Controls.Add(this.txtIDpropietario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(40, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 289);
            this.panel1.TabIndex = 11;
            // 
            // comboTipoCliente
            // 
            this.comboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCliente.FormattingEnabled = true;
            this.comboTipoCliente.Items.AddRange(new object[] {
            "OCASIONAL",
            "POR CONTRATOS"});
            this.comboTipoCliente.Location = new System.Drawing.Point(165, 188);
            this.comboTipoCliente.Name = "comboTipoCliente";
            this.comboTipoCliente.Size = new System.Drawing.Size(181, 21);
            this.comboTipoCliente.TabIndex = 8;
            // 
            // btnRegistrarPersonas
            // 
            this.btnRegistrarPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPersonas.Location = new System.Drawing.Point(541, 212);
            this.btnRegistrarPersonas.Name = "btnRegistrarPersonas";
            this.btnRegistrarPersonas.Size = new System.Drawing.Size(152, 55);
            this.btnRegistrarPersonas.TabIndex = 7;
            this.btnRegistrarPersonas.Text = "REGISTRAR";
            this.btnRegistrarPersonas.UseVisualStyleBackColor = true;
            this.btnRegistrarPersonas.Click += new System.EventHandler(this.btnRegistrarPersonas_Click);
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
            // txtNombrePropietario
            // 
            this.txtNombrePropietario.Location = new System.Drawing.Point(233, 139);
            this.txtNombrePropietario.Name = "txtNombrePropietario";
            this.txtNombrePropietario.Size = new System.Drawing.Size(230, 20);
            this.txtNombrePropietario.TabIndex = 4;
            // 
            // txtIDpropietario
            // 
            this.txtIDpropietario.Location = new System.Drawing.Point(159, 98);
            this.txtIDpropietario.Name = "txtIDpropietario";
            this.txtIDpropietario.Size = new System.Drawing.Size(164, 20);
            this.txtIDpropietario.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del Propietario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Propietario:";
            // 
            // FormIngresoPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlquilerVehiculos.Properties.Resources.posters_engranajes_fondo_del_vector_jpg;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIngresoPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIngresoPersonas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboTipoCliente;
        private System.Windows.Forms.Button btnRegistrarPersonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombrePropietario;
        private System.Windows.Forms.TextBox txtIDpropietario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}