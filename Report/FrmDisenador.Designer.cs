namespace Report
{
    partial class FrmDisenador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnDisenar = new System.Windows.Forms.Button();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.ChkParam = new System.Windows.Forms.CheckBox();
            this.TxtQuery = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(13, 34);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(282, 31);
            this.lblTitulo.TabIndex = 126;
            this.lblTitulo.Text = "Diseñador de reportes";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label14.Location = new System.Drawing.Point(4, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1121, 10);
            this.label14.TabIndex = 125;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.TxtDescripcion.Location = new System.Drawing.Point(287, 10);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(352, 29);
            this.TxtDescripcion.TabIndex = 127;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 25);
            this.label6.TabIndex = 132;
            this.label6.Text = "NOMBRE O DESCRIPCIÓN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNuevo);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.BtnVer);
            this.panel1.Controls.Add(this.BtnDisenar);
            this.panel1.Controls.Add(this.TxtClave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 85);
            this.panel1.TabIndex = 133;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNuevo.Location = new System.Drawing.Point(657, 0);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(94, 85);
            this.BtnNuevo.TabIndex = 144;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Location = new System.Drawing.Point(751, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 85);
            this.btnGuardar.TabIndex = 143;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnVer
            // 
            this.BtnVer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnVer.Location = new System.Drawing.Point(845, 0);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(94, 85);
            this.BtnVer.TabIndex = 142;
            this.BtnVer.Text = "&Ver";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnDisenar
            // 
            this.BtnDisenar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDisenar.Location = new System.Drawing.Point(939, 0);
            this.BtnDisenar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDisenar.Name = "BtnDisenar";
            this.BtnDisenar.Size = new System.Drawing.Size(94, 85);
            this.BtnDisenar.TabIndex = 141;
            this.BtnDisenar.Text = "&Diseñar";
            this.BtnDisenar.UseVisualStyleBackColor = true;
            this.BtnDisenar.Click += new System.EventHandler(this.BtnDisenar_Click);
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.SystemColors.Window;
            this.TxtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtClave.Enabled = false;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.ForeColor = System.Drawing.Color.Black;
            this.TxtClave.Location = new System.Drawing.Point(287, 43);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(4);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(352, 29);
            this.TxtClave.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 140;
            this.label1.Text = "SECUENCIA DE CIFRADO";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.Location = new System.Drawing.Point(1033, 0);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(94, 85);
            this.BtnSalir.TabIndex = 136;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ChkParam
            // 
            this.ChkParam.AutoSize = true;
            this.ChkParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkParam.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChkParam.Location = new System.Drawing.Point(74, 77);
            this.ChkParam.Margin = new System.Windows.Forms.Padding(4);
            this.ChkParam.Name = "ChkParam";
            this.ChkParam.Size = new System.Drawing.Size(105, 29);
            this.ChkParam.TabIndex = 135;
            this.ChkParam.Text = "PARAM";
            this.ChkParam.UseVisualStyleBackColor = true;
            // 
            // TxtQuery
            // 
            this.TxtQuery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtQuery.Location = new System.Drawing.Point(0, 112);
            this.TxtQuery.Name = "TxtQuery";
            this.TxtQuery.Size = new System.Drawing.Size(1127, 418);
            this.TxtQuery.TabIndex = 134;
            this.TxtQuery.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 135;
            this.label2.Text = "SQL";
            // 
            // FrmDisenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 615);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtQuery);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ChkParam);
            this.Name = "FrmDisenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisenador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ChkParam;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TxtQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnDisenar;
    }
}