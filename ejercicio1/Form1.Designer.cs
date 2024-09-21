﻿namespace valuar_motos
{
    partial class FormPrincipal
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbDepreciacion = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.tbValorFabricacion = new System.Windows.Forms.TextBox();
            this.nupModelo = new System.Windows.Forms.NumericUpDown();
            this.nupAño = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAño)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(131, 175);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 51);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular costo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año a calcular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor de fabricación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tasa de depreciación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vida Útil (años): ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(274, 188);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 24);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(144, 27);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 8;
            // 
            // tbDepreciacion
            // 
            this.tbDepreciacion.Location = new System.Drawing.Point(410, 27);
            this.tbDepreciacion.Name = "tbDepreciacion";
            this.tbDepreciacion.Size = new System.Drawing.Size(100, 20);
            this.tbDepreciacion.TabIndex = 9;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(410, 61);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 20);
            this.tbVidaUtil.TabIndex = 10;
            // 
            // tbValorFabricacion
            // 
            this.tbValorFabricacion.Location = new System.Drawing.Point(144, 129);
            this.tbValorFabricacion.Name = "tbValorFabricacion";
            this.tbValorFabricacion.Size = new System.Drawing.Size(100, 20);
            this.tbValorFabricacion.TabIndex = 11;
            // 
            // nupModelo
            // 
            this.nupModelo.Location = new System.Drawing.Point(144, 62);
            this.nupModelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nupModelo.Name = "nupModelo";
            this.nupModelo.Size = new System.Drawing.Size(59, 20);
            this.nupModelo.TabIndex = 12;
            // 
            // nupAño
            // 
            this.nupAño.Location = new System.Drawing.Point(144, 96);
            this.nupAño.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupAño.Name = "nupAño";
            this.nupAño.Size = new System.Drawing.Size(59, 20);
            this.nupAño.TabIndex = 13;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 238);
            this.Controls.Add(this.nupAño);
            this.Controls.Add(this.nupModelo);
            this.Controls.Add(this.tbValorFabricacion);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbDepreciacion);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FormPrincipal";
            this.Text = "Tasación de motos";
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbDepreciacion;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.TextBox tbValorFabricacion;
        private System.Windows.Forms.NumericUpDown nupModelo;
        private System.Windows.Forms.NumericUpDown nupAño;
    }
}

