namespace UIWinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonLigar = new System.Windows.Forms.Button();
            this.textBoxImpulso = new System.Windows.Forms.TextBox();
            this.textBoxExibir = new System.Windows.Forms.TextBox();
            this.buttonFrear = new System.Windows.Forms.Button();
            this.buttonTrocarPneu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPneuDianteiroEsquerdo = new System.Windows.Forms.TextBox();
            this.textBoxPneuDianteiroDireito = new System.Windows.Forms.TextBox();
            this.textBoxPneuTraseiroDireito = new System.Windows.Forms.TextBox();
            this.textBoxPneuTraseiroEsquerdo = new System.Windows.Forms.TextBox();
            this.textBoxPneuEstepe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPneu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonAcelerar.Location = new System.Drawing.Point(1047, 149);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(96, 83);
            this.buttonAcelerar.TabIndex = 0;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonLigar
            // 
            this.buttonLigar.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonLigar.Location = new System.Drawing.Point(947, 149);
            this.buttonLigar.Name = "buttonLigar";
            this.buttonLigar.Size = new System.Drawing.Size(94, 83);
            this.buttonLigar.TabIndex = 1;
            this.buttonLigar.Text = "Ligar";
            this.buttonLigar.UseVisualStyleBackColor = true;
            this.buttonLigar.Click += new System.EventHandler(this.buttonLigar_Click);
            // 
            // textBoxImpulso
            // 
            this.textBoxImpulso.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxImpulso.Location = new System.Drawing.Point(970, 104);
            this.textBoxImpulso.Multiline = true;
            this.textBoxImpulso.Name = "textBoxImpulso";
            this.textBoxImpulso.Size = new System.Drawing.Size(125, 34);
            this.textBoxImpulso.TabIndex = 2;
            this.textBoxImpulso.TextChanged += new System.EventHandler(this.textBoxImpulso_TextChanged);
            // 
            // textBoxExibir
            // 
            this.textBoxExibir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxExibir.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxExibir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxExibir.Location = new System.Drawing.Point(247, 25);
            this.textBoxExibir.Multiline = true;
            this.textBoxExibir.Name = "textBoxExibir";
            this.textBoxExibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExibir.Size = new System.Drawing.Size(277, 253);
            this.textBoxExibir.TabIndex = 3;
            this.textBoxExibir.TextChanged += new System.EventHandler(this.textBoxExibir_TextChanged);
            // 
            // buttonFrear
            // 
            this.buttonFrear.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonFrear.Location = new System.Drawing.Point(1149, 149);
            this.buttonFrear.Name = "buttonFrear";
            this.buttonFrear.Size = new System.Drawing.Size(96, 83);
            this.buttonFrear.TabIndex = 0;
            this.buttonFrear.Text = "Frear";
            this.buttonFrear.UseVisualStyleBackColor = true;
            this.buttonFrear.Click += new System.EventHandler(this.buttonFrear_Click);
            // 
            // buttonTrocarPneu
            // 
            this.buttonTrocarPneu.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonTrocarPneu.Location = new System.Drawing.Point(847, 149);
            this.buttonTrocarPneu.Name = "buttonTrocarPneu";
            this.buttonTrocarPneu.Size = new System.Drawing.Size(94, 83);
            this.buttonTrocarPneu.TabIndex = 1;
            this.buttonTrocarPneu.Text = "TrocarPneu";
            this.buttonTrocarPneu.UseVisualStyleBackColor = true;
            this.buttonTrocarPneu.Click += new System.EventHandler(this.buttonTrocarPneu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(1003, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Impulso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Location = new System.Drawing.Point(247, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalhes do carro";
            // 
            // textBoxPneuDianteiroEsquerdo
            // 
            this.textBoxPneuDianteiroEsquerdo.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuDianteiroEsquerdo.Location = new System.Drawing.Point(12, 25);
            this.textBoxPneuDianteiroEsquerdo.Multiline = true;
            this.textBoxPneuDianteiroEsquerdo.Name = "textBoxPneuDianteiroEsquerdo";
            this.textBoxPneuDianteiroEsquerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDianteiroEsquerdo.Size = new System.Drawing.Size(229, 158);
            this.textBoxPneuDianteiroEsquerdo.TabIndex = 3;
            this.textBoxPneuDianteiroEsquerdo.TextChanged += new System.EventHandler(this.textBoxExibir_TextChanged);
            // 
            // textBoxPneuDianteiroDireito
            // 
            this.textBoxPneuDianteiroDireito.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuDianteiroDireito.Location = new System.Drawing.Point(530, 25);
            this.textBoxPneuDianteiroDireito.Multiline = true;
            this.textBoxPneuDianteiroDireito.Name = "textBoxPneuDianteiroDireito";
            this.textBoxPneuDianteiroDireito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDianteiroDireito.Size = new System.Drawing.Size(245, 158);
            this.textBoxPneuDianteiroDireito.TabIndex = 3;
            this.textBoxPneuDianteiroDireito.TextChanged += new System.EventHandler(this.textBoxExibir_TextChanged);
            // 
            // textBoxPneuTraseiroDireito
            // 
            this.textBoxPneuTraseiroDireito.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuTraseiroDireito.Location = new System.Drawing.Point(530, 212);
            this.textBoxPneuTraseiroDireito.Multiline = true;
            this.textBoxPneuTraseiroDireito.Name = "textBoxPneuTraseiroDireito";
            this.textBoxPneuTraseiroDireito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuTraseiroDireito.Size = new System.Drawing.Size(245, 155);
            this.textBoxPneuTraseiroDireito.TabIndex = 3;
            this.textBoxPneuTraseiroDireito.TextChanged += new System.EventHandler(this.textBoxExibir_TextChanged);
            // 
            // textBoxPneuTraseiroEsquerdo
            // 
            this.textBoxPneuTraseiroEsquerdo.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuTraseiroEsquerdo.Location = new System.Drawing.Point(12, 212);
            this.textBoxPneuTraseiroEsquerdo.Multiline = true;
            this.textBoxPneuTraseiroEsquerdo.Name = "textBoxPneuTraseiroEsquerdo";
            this.textBoxPneuTraseiroEsquerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuTraseiroEsquerdo.Size = new System.Drawing.Size(229, 155);
            this.textBoxPneuTraseiroEsquerdo.TabIndex = 3;
            this.textBoxPneuTraseiroEsquerdo.TextChanged += new System.EventHandler(this.textBoxExibir_TextChanged);
            // 
            // textBoxPneuEstepe
            // 
            this.textBoxPneuEstepe.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuEstepe.Location = new System.Drawing.Point(247, 301);
            this.textBoxPneuEstepe.Multiline = true;
            this.textBoxPneuEstepe.Name = "textBoxPneuEstepe";
            this.textBoxPneuEstepe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuEstepe.Size = new System.Drawing.Size(277, 162);
            this.textBoxPneuEstepe.TabIndex = 3;
            this.textBoxPneuEstepe.TextChanged += new System.EventHandler(this.textBoxExibir_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Location = new System.Drawing.Point(247, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "PneuEstepe";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Location = new System.Drawing.Point(530, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "PneuDianteiroDireito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Location = new System.Drawing.Point(12, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "PneuDianteiroEsquerdo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "PneuTraseiroEsquerdo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.No;
            this.label7.Location = new System.Drawing.Point(530, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "PneuTraseiroDireito";
            // 
            // comboBoxPneu
            // 
            this.comboBoxPneu.Cursor = System.Windows.Forms.Cursors.No;
            this.comboBoxPneu.FormattingEnabled = true;
            this.comboBoxPneu.Items.AddRange(new object[] {
            "PneuDianteiroDireito",
            "PneuDianteiroEsquerdo",
            "PneuTraseiroDireito",
            "PneuTraseiroEsquerdo"});
            this.comboBoxPneu.Location = new System.Drawing.Point(847, 238);
            this.comboBoxPneu.Name = "comboBoxPneu";
            this.comboBoxPneu.Size = new System.Drawing.Size(94, 28);
            this.comboBoxPneu.TabIndex = 5;
            this.comboBoxPneu.SelectedIndexChanged += new System.EventHandler(this.comboBoxPneu_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 609);
            this.Controls.Add(this.comboBoxPneu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPneuTraseiroEsquerdo);
            this.Controls.Add(this.textBoxPneuEstepe);
            this.Controls.Add(this.textBoxPneuTraseiroDireito);
            this.Controls.Add(this.textBoxPneuDianteiroDireito);
            this.Controls.Add(this.textBoxPneuDianteiroEsquerdo);
            this.Controls.Add(this.textBoxExibir);
            this.Controls.Add(this.textBoxImpulso);
            this.Controls.Add(this.buttonTrocarPneu);
            this.Controls.Add(this.buttonLigar);
            this.Controls.Add(this.buttonFrear);
            this.Controls.Add(this.buttonAcelerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAcelerar;
        private Button buttonLigar;
        private TextBox textBoxImpulso;
        private TextBox textBoxExibir;
        private Button buttonFrear;
        private Button buttonTrocarPneu;
        private Label label1;
        private Label label2;
        private TextBox textBoxPneuDianteiroEsquerdo;
        private TextBox textBoxPneuDianteiroDireito;
        private TextBox textBoxPneuTraseiroDireito;
        private TextBox textBoxPneuTraseiroEsquerdo;
        private TextBox textBoxPneuEstepe;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxPneu;
    }
}