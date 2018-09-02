namespace TabelaIRPF
{
    partial class FormPrincipal
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.textoFimFaixa1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoAliquotaFaixa1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textoAliquotaFaixa2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoFimFaixa2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textoAliquotaFaixa3 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoFimFaixa3 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textoAliquotaFaixa4 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textoFimFaixa4 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textoAliquotaFaixa5 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textoFimFaixa5 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botaoCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.CausesValidation = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(183, 12);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.ShowCellErrors = false;
            this.grid.ShowEditingIcon = false;
            this.grid.ShowRowErrors = false;
            this.grid.Size = new System.Drawing.Size(839, 639);
            this.grid.TabIndex = 1;
            // 
            // textoFimFaixa1
            // 
            this.textoFimFaixa1.Location = new System.Drawing.Point(6, 37);
            this.textoFimFaixa1.Name = "textoFimFaixa1";
            this.textoFimFaixa1.Size = new System.Drawing.Size(102, 20);
            this.textoFimFaixa1.TabIndex = 2;
            this.textoFimFaixa1.Text = "3000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoAliquotaFaixa1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoFimFaixa1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faixa 1";
            // 
            // textoAliquotaFaixa1
            // 
            this.textoAliquotaFaixa1.Location = new System.Drawing.Point(114, 37);
            this.textoAliquotaFaixa1.Mask = "0.000";
            this.textoAliquotaFaixa1.Name = "textoAliquotaFaixa1";
            this.textoAliquotaFaixa1.Size = new System.Drawing.Size(44, 20);
            this.textoAliquotaFaixa1.TabIndex = 4;
            this.textoAliquotaFaixa1.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alíquota";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textoAliquotaFaixa2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textoFimFaixa2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faixa 2";
            // 
            // textoAliquotaFaixa2
            // 
            this.textoAliquotaFaixa2.Location = new System.Drawing.Point(114, 37);
            this.textoAliquotaFaixa2.Mask = "0.000";
            this.textoAliquotaFaixa2.Name = "textoAliquotaFaixa2";
            this.textoAliquotaFaixa2.Size = new System.Drawing.Size(44, 20);
            this.textoAliquotaFaixa2.TabIndex = 4;
            this.textoAliquotaFaixa2.Text = "0150";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alíquota";
            // 
            // textoFimFaixa2
            // 
            this.textoFimFaixa2.Location = new System.Drawing.Point(6, 37);
            this.textoFimFaixa2.Name = "textoFimFaixa2";
            this.textoFimFaixa2.Size = new System.Drawing.Size(102, 20);
            this.textoFimFaixa2.TabIndex = 2;
            this.textoFimFaixa2.Text = "4000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fim";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textoAliquotaFaixa3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textoFimFaixa3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 64);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faixa 3";
            // 
            // textoAliquotaFaixa3
            // 
            this.textoAliquotaFaixa3.Location = new System.Drawing.Point(114, 37);
            this.textoAliquotaFaixa3.Mask = "0.000";
            this.textoAliquotaFaixa3.Name = "textoAliquotaFaixa3";
            this.textoAliquotaFaixa3.Size = new System.Drawing.Size(44, 20);
            this.textoAliquotaFaixa3.TabIndex = 4;
            this.textoAliquotaFaixa3.Text = "0250";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alíquota";
            // 
            // textoFimFaixa3
            // 
            this.textoFimFaixa3.Location = new System.Drawing.Point(6, 37);
            this.textoFimFaixa3.Name = "textoFimFaixa3";
            this.textoFimFaixa3.Size = new System.Drawing.Size(102, 20);
            this.textoFimFaixa3.TabIndex = 2;
            this.textoFimFaixa3.Text = "5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fim";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textoAliquotaFaixa4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textoFimFaixa4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 64);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Faixa 4";
            // 
            // textoAliquotaFaixa4
            // 
            this.textoAliquotaFaixa4.Location = new System.Drawing.Point(114, 37);
            this.textoAliquotaFaixa4.Mask = "0.000";
            this.textoAliquotaFaixa4.Name = "textoAliquotaFaixa4";
            this.textoAliquotaFaixa4.Size = new System.Drawing.Size(44, 20);
            this.textoAliquotaFaixa4.TabIndex = 4;
            this.textoAliquotaFaixa4.Text = "0300";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Alíquota";
            // 
            // textoFimFaixa4
            // 
            this.textoFimFaixa4.Location = new System.Drawing.Point(6, 37);
            this.textoFimFaixa4.Name = "textoFimFaixa4";
            this.textoFimFaixa4.Size = new System.Drawing.Size(102, 20);
            this.textoFimFaixa4.TabIndex = 2;
            this.textoFimFaixa4.Text = "10000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fim";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textoAliquotaFaixa5);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.textoFimFaixa5);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(12, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 64);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Faixa 5";
            // 
            // textoAliquotaFaixa5
            // 
            this.textoAliquotaFaixa5.Location = new System.Drawing.Point(114, 37);
            this.textoAliquotaFaixa5.Mask = "0.000";
            this.textoAliquotaFaixa5.Name = "textoAliquotaFaixa5";
            this.textoAliquotaFaixa5.Size = new System.Drawing.Size(44, 20);
            this.textoAliquotaFaixa5.TabIndex = 4;
            this.textoAliquotaFaixa5.Text = "0350";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Alíquota";
            // 
            // textoFimFaixa5
            // 
            this.textoFimFaixa5.Location = new System.Drawing.Point(6, 37);
            this.textoFimFaixa5.Name = "textoFimFaixa5";
            this.textoFimFaixa5.Size = new System.Drawing.Size(102, 20);
            this.textoFimFaixa5.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Fim";
            // 
            // botaoCalcular
            // 
            this.botaoCalcular.Location = new System.Drawing.Point(12, 362);
            this.botaoCalcular.Name = "botaoCalcular";
            this.botaoCalcular.Size = new System.Drawing.Size(165, 30);
            this.botaoCalcular.TabIndex = 10;
            this.botaoCalcular.Text = "Calcular";
            this.botaoCalcular.UseVisualStyleBackColor = true;
            this.botaoCalcular.Click += new System.EventHandler(this.botaoCalcular_Click);
            // 
            // FormPrincipal
            // 
            this.AcceptButton = this.botaoCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 663);
            this.Controls.Add(this.botaoCalcular);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "IRPF de Pessoa Física";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.MaskedTextBox textoFimFaixa1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox textoAliquotaFaixa1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox textoAliquotaFaixa2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox textoFimFaixa2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox textoAliquotaFaixa3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox textoFimFaixa3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox textoAliquotaFaixa4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textoFimFaixa4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox textoAliquotaFaixa5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox textoFimFaixa5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botaoCalcular;
    }
}

