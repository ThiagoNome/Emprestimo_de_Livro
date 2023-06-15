namespace emprestimolivros.View
{
    partial class FormView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cpfCliente = new System.Windows.Forms.TextBox();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nomeLivro = new System.Windows.Forms.TextBox();
            this.valorLivro = new System.Windows.Forms.TextBox();
            this.anoLivro = new System.Windows.Forms.TextBox();
            this.descontosLivro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_nomeCli = new System.Windows.Forms.Label();
            this.tx_anoLivro = new System.Windows.Forms.Label();
            this.tx_cpfCli = new System.Windows.Forms.Label();
            this.tx_nomeLivro = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano do lançamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Livro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cpfCliente);
            this.groupBox1.Controls.Add(this.nomeCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área do Cliente";
            // 
            // cpfCliente
            // 
            this.cpfCliente.BackColor = System.Drawing.SystemColors.Info;
            this.cpfCliente.Location = new System.Drawing.Point(55, 89);
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.Size = new System.Drawing.Size(152, 23);
            this.cpfCliente.TabIndex = 6;
            // 
            // nomeCliente
            // 
            this.nomeCliente.BackColor = System.Drawing.SystemColors.Info;
            this.nomeCliente.Location = new System.Drawing.Point(68, 49);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(140, 23);
            this.nomeCliente.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nomeLivro);
            this.groupBox2.Controls.Add(this.valorLivro);
            this.groupBox2.Controls.Add(this.anoLivro);
            this.groupBox2.Controls.Add(this.descontosLivro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(283, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 161);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área do Bibliotecário";
            // 
            // nomeLivro
            // 
            this.nomeLivro.BackColor = System.Drawing.SystemColors.Info;
            this.nomeLivro.Location = new System.Drawing.Point(129, 33);
            this.nomeLivro.Name = "nomeLivro";
            this.nomeLivro.Size = new System.Drawing.Size(157, 23);
            this.nomeLivro.TabIndex = 10;
            // 
            // valorLivro
            // 
            this.valorLivro.BackColor = System.Drawing.SystemColors.Info;
            this.valorLivro.Location = new System.Drawing.Point(61, 65);
            this.valorLivro.Name = "valorLivro";
            this.valorLivro.Size = new System.Drawing.Size(93, 23);
            this.valorLivro.TabIndex = 9;
            // 
            // anoLivro
            // 
            this.anoLivro.BackColor = System.Drawing.SystemColors.Info;
            this.anoLivro.Location = new System.Drawing.Point(160, 96);
            this.anoLivro.Name = "anoLivro";
            this.anoLivro.Size = new System.Drawing.Size(126, 23);
            this.anoLivro.TabIndex = 8;
            // 
            // descontosLivro
            // 
            this.descontosLivro.BackColor = System.Drawing.SystemColors.Control;
            this.descontosLivro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descontosLivro.FormattingEnabled = true;
            this.descontosLivro.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%"});
            this.descontosLivro.Location = new System.Drawing.Point(97, 126);
            this.descontosLivro.Name = "descontosLivro";
            this.descontosLivro.Size = new System.Drawing.Size(90, 23);
            this.descontosLivro.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descontos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Enviar dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(197, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Empréstimo de Livro";
            // 
            // tx_nomeCli
            // 
            this.tx_nomeCli.BackColor = System.Drawing.SystemColors.Info;
            this.tx_nomeCli.Location = new System.Drawing.Point(72, 31);
            this.tx_nomeCli.Name = "tx_nomeCli";
            this.tx_nomeCli.Size = new System.Drawing.Size(137, 15);
            this.tx_nomeCli.TabIndex = 13;
            this.tx_nomeCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tx_nomeCli.Click += new System.EventHandler(this.tx_nomeCli_Click);
            // 
            // tx_anoLivro
            // 
            this.tx_anoLivro.BackColor = System.Drawing.SystemColors.Info;
            this.tx_anoLivro.Location = new System.Drawing.Point(410, 61);
            this.tx_anoLivro.Name = "tx_anoLivro";
            this.tx_anoLivro.Size = new System.Drawing.Size(114, 15);
            this.tx_anoLivro.TabIndex = 14;
            this.tx_anoLivro.Click += new System.EventHandler(this.tx_anoLivro_Click);
            // 
            // tx_cpfCli
            // 
            this.tx_cpfCli.BackColor = System.Drawing.SystemColors.Info;
            this.tx_cpfCli.Location = new System.Drawing.Point(72, 61);
            this.tx_cpfCli.Name = "tx_cpfCli";
            this.tx_cpfCli.Size = new System.Drawing.Size(137, 15);
            this.tx_cpfCli.TabIndex = 15;
            this.tx_cpfCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tx_cpfCli.Click += new System.EventHandler(this.tx_cpfCli_Click);
            // 
            // tx_nomeLivro
            // 
            this.tx_nomeLivro.BackColor = System.Drawing.SystemColors.Info;
            this.tx_nomeLivro.Location = new System.Drawing.Point(383, 31);
            this.tx_nomeLivro.Name = "tx_nomeLivro";
            this.tx_nomeLivro.Size = new System.Drawing.Size(141, 15);
            this.tx_nomeLivro.TabIndex = 16;
            this.tx_nomeLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tx_nomeLivro.Click += new System.EventHandler(this.tx_nomeLivro_Click);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.SystemColors.Info;
            this.resultado.Location = new System.Drawing.Point(295, 108);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(59, 15);
            this.resultado.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tx_nomeCli);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.resultado);
            this.groupBox3.Controls.Add(this.asd);
            this.groupBox3.Controls.Add(this.tx_cpfCli);
            this.groupBox3.Controls.Add(this.tx_nomeLivro);
            this.groupBox3.Controls.Add(this.tx_anoLivro);
            this.groupBox3.Location = new System.Drawing.Point(29, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 141);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nota Fiscal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ano de Lançamento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nome do Livro:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "CPF:";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(17, 31);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(43, 15);
            this.asd.TabIndex = 19;
            this.asd.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Valor da Compra:";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 413);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox cpfCliente;
        private TextBox nomeCliente;
        private GroupBox groupBox2;
        private ComboBox descontosLivro;
        private Label label6;
        private TextBox nomeLivro;
        private TextBox valorLivro;
        private TextBox anoLivro;
        private Button button1;
        private Label label7;
        private Label tx_nomeCli;
        private Label tx_anoLivro;
        private Label tx_cpfCli;
        private Label tx_nomeLivro;
        private Label resultado;
        private GroupBox groupBox3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label asd;
        private Label label8;
    }
}