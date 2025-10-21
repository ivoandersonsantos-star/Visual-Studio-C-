namespace internal interface;

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
        panelMenu = new Panel();
        panelLogo = new Panel();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        panelMenu.SuspendLayout();
        SuspendLayout();
        // 
        // panelMenu
        // 
        panelMenu.BackColor = Color.FromArgb(51, 51, 76);
        panelMenu.Controls.Add(button6);
        panelMenu.Controls.Add(button5);
        panelMenu.Controls.Add(button4);
        panelMenu.Controls.Add(button3);
        panelMenu.Controls.Add(button2);
        panelMenu.Controls.Add(button1);
        panelMenu.Controls.Add(panelLogo);
        panelMenu.Dock = DockStyle.Left;
        panelMenu.Location = new Point(0, 0);
        panelMenu.Name = "panelMenu";
        panelMenu.Size = new Size(220, 504);
        panelMenu.TabIndex = 0;
        // 
        // panelLogo
        // 
        panelLogo.BackColor = Color.FromArgb(39, 39, 58);
        panelLogo.Dock = DockStyle.Top;
        panelLogo.Location = new Point(0, 0);
        panelLogo.Name = "panelLogo";
        panelLogo.Size = new Size(220, 80);
        panelLogo.TabIndex = 0;
        // 
        // button1
        // 
        button1.Dock = DockStyle.Top;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.ForeColor = Color.Gainsboro;
        button1.Image = @interface.Properties.Resources.carrinho_de_compras;
        button1.ImageAlign = ContentAlignment.MiddleLeft;
        button1.Location = new Point(0, 80);
        button1.Name = "button1";
        button1.Size = new Size(220, 60);
        button1.TabIndex = 0;
        button1.Text = "Products";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Dock = DockStyle.Top;
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = FlatStyle.Flat;
        button2.ForeColor = Color.Gainsboro;
        button2.Image = @interface.Properties.Resources.icons8_agenda_50;
        button2.ImageAlign = ContentAlignment.MiddleLeft;
        button2.Location = new Point(0, 140);
        button2.Name = "button2";
        button2.Size = new Size(220, 60);
        button2.TabIndex = 1;
        button2.Text = "Orders";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Dock = DockStyle.Top;
        button3.FlatAppearance.BorderSize = 0;
        button3.FlatStyle = FlatStyle.Flat;
        button3.ForeColor = Color.Gainsboro;
        button3.Image = @interface.Properties.Resources.icons8_usuário_de_gênero_neutro_50;
        button3.ImageAlign = ContentAlignment.MiddleLeft;
        button3.Location = new Point(0, 200);
        button3.Name = "button3";
        button3.Size = new Size(220, 60);
        button3.TabIndex = 2;
        button3.Text = "Costumer";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Dock = DockStyle.Top;
        button4.FlatAppearance.BorderSize = 0;
        button4.FlatStyle = FlatStyle.Flat;
        button4.ForeColor = Color.Gainsboro;
        button4.Image = @interface.Properties.Resources.icons8_gráfico_50;
        button4.ImageAlign = ContentAlignment.MiddleLeft;
        button4.Location = new Point(0, 260);
        button4.Name = "button4";
        button4.Size = new Size(220, 60);
        button4.TabIndex = 3;
        button4.Text = "Reporting";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Dock = DockStyle.Top;
        button5.FlatAppearance.BorderSize = 0;
        button5.FlatStyle = FlatStyle.Flat;
        button5.ForeColor = Color.Gainsboro;
        button5.Image = @interface.Properties.Resources.icons8_notificações_64;
        button5.ImageAlign = ContentAlignment.MiddleLeft;
        button5.Location = new Point(0, 320);
        button5.Name = "button5";
        button5.Size = new Size(220, 60);
        button5.TabIndex = 4;
        button5.Text = "Notifications";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Dock = DockStyle.Top;
        button6.FlatAppearance.BorderSize = 0;
        button6.FlatStyle = FlatStyle.Flat;
        button6.ForeColor = Color.Gainsboro;
        button6.Image = @interface.Properties.Resources.icons8_configurações_50;
        button6.ImageAlign = ContentAlignment.MiddleLeft;
        button6.Location = new Point(0, 380);
        button6.Name = "button6";
        button6.Size = new Size(220, 60);
        button6.TabIndex = 5;
        button6.Text = "Setting";
        button6.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 504);
        Controls.Add(panelMenu);
        Name = "Form1";
        Text = " ";
        panelMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelMenu;
    private Button button6;
    private Button button5;
    private Button button4;
    private Button button3;
    private Button button2;
    private Button button1;
    private Panel panelLogo;
}
