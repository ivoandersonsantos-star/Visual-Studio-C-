namespace lista
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 54);
            label1.TabIndex = 0;
            label1.Text = "AÇAÍ";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 226);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "TAMANHO:";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(12, 349);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 285);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "FRUTAS - 3 OPÇÕES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_sorvete_50;
            pictureBox1.Location = new Point(138, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 55);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(250, 117);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(227, 226);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "COMPLEMENTOS - 4 OPÇÕES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 3;
            label2.Text = "PINGUINS";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_pinguin_48;
            pictureBox2.Location = new Point(179, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 55);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(250, 349);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(227, 285);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "COMPLEMENTOS - OPÇÕES";
            // 
            // groupBox5
            // 
            groupBox5.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.ForeColor = SystemColors.ButtonHighlight;
            groupBox5.Location = new Point(509, 117);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(227, 506);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "ADICIONAIS:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(1010, 661);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = Color.SlateBlue;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Label label2;
        private PictureBox pictureBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}