namespace MeuProjetoWF
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
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            maskedTextBox5 = new MaskedTextBox();
            label5 = new Label();
            maskedTextBox6 = new MaskedTextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(49, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(68, 150);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(244, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(68, 207);
            maskedTextBox2.Mask = "00000-000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(244, 23);
            maskedTextBox2.TabIndex = 2;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(68, 41);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(244, 23);
            maskedTextBox3.TabIndex = 3;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(68, 95);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(244, 23);
            maskedTextBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 23);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 189);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 6;
            label2.Text = "CEP";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(144, 393);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 7;
            button2.Text = "Apagar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 77);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 8;
            label3.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 132);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "CPF";
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Location = new Point(237, 393);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 10;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(68, 268);
            maskedTextBox5.Mask = "00/00/0000";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(244, 23);
            maskedTextBox5.TabIndex = 11;
            maskedTextBox5.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 250);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 12;
            label5.Text = "Data de Nascimento";
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(68, 334);
            maskedTextBox6.Mask = "(99) 0000-000";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(244, 23);
            maskedTextBox6.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 316);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 14;
            label6.Text = "Número de Telefone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(636, 450);
            Controls.Add(label6);
            Controls.Add(maskedTextBox6);
            Controls.Add(label5);
            Controls.Add(maskedTextBox5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Button button3;
        private MaskedTextBox maskedTextBox5;
        private Label label5;
        private MaskedTextBox maskedTextBox6;
        private Label label6;
    }
}