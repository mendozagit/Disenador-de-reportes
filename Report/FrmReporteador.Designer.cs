namespace Report
{
    partial class FrmReporteador
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnDisenar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.CboReporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.TxtQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(678, 471);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 47);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(519, 32);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(98, 25);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnDisenar
            // 
            this.BtnDisenar.Location = new System.Drawing.Point(415, 31);
            this.BtnDisenar.Name = "BtnDisenar";
            this.BtnDisenar.Size = new System.Drawing.Size(98, 25);
            this.BtnDisenar.TabIndex = 2;
            this.BtnDisenar.Text = "Diseñar";
            this.BtnDisenar.UseVisualStyleBackColor = true;
            this.BtnDisenar.Click += new System.EventHandler(this.BtnDisenar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(311, 31);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(98, 26);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Crear Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // CboReporte
            // 
            this.CboReporte.FormattingEnabled = true;
            this.CboReporte.Location = new System.Drawing.Point(15, 33);
            this.CboReporte.Name = "CboReporte";
            this.CboReporte.Size = new System.Drawing.Size(293, 24);
            this.CboReporte.TabIndex = 4;
            this.CboReporte.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "REPORTE";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(574, 471);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(98, 47);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.Location = new System.Drawing.Point(15, 129);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(293, 22);
            this.TxtDescrip.TabIndex = 7;
            // 
            // TxtQuery
            // 
            this.TxtQuery.Location = new System.Drawing.Point(12, 177);
            this.TxtQuery.Multiline = true;
            this.TxtQuery.Name = "TxtQuery";
            this.TxtQuery.Size = new System.Drawing.Size(296, 194);
            this.TxtQuery.TabIndex = 8;
            this.TxtQuery.Text = "select * from Producto where Precio1 =@precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "SQL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "CLAVE";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(15, 80);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(293, 22);
            this.TxtClave.TabIndex = 15;
            // 
            // FrmReporteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtQuery);
            this.Controls.Add(this.TxtDescrip);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboReporte);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnDisenar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnSalir);
            this.Name = "FrmReporteador";
            this.Text = "FrmReporteador";
            this.Load += new System.EventHandler(this.FrmReporteador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnDisenar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.ComboBox CboReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.TextBox TxtQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtClave;
    }
}