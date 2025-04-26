namespace gry_karciane
{
    partial class FormLogin
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
            labelGracz1 = new Label();
            labelGracz2 = new Label();
            labelLogowanie = new Label();
            textBoxGracz1 = new TextBox();
            textBoxGracz2 = new TextBox();
            buttonZapisz = new Button();
            buttonAnuluj = new Button();
            labelLogin = new Label();
            SuspendLayout();
            // 
            // labelGracz1
            // 
            labelGracz1.AutoSize = true;
            labelGracz1.Location = new Point(160, 144);
            labelGracz1.Name = "labelGracz1";
            labelGracz1.Size = new Size(82, 30);
            labelGracz1.TabIndex = 0;
            labelGracz1.Text = "Gracz 1";
            labelGracz1.Click += labelGracz1_Click;
            // 
            // labelGracz2
            // 
            labelGracz2.AutoSize = true;
            labelGracz2.Location = new Point(511, 144);
            labelGracz2.Name = "labelGracz2";
            labelGracz2.Size = new Size(82, 30);
            labelGracz2.TabIndex = 1;
            labelGracz2.Text = "Gracz 2";
            // 
            // labelLogowanie
            // 
            labelLogowanie.AutoSize = true;
            labelLogowanie.Location = new Point(238, 83);
            labelLogowanie.Name = "labelLogowanie";
            labelLogowanie.Size = new Size(249, 30);
            labelLogowanie.TabIndex = 2;
            labelLogowanie.Text = "Logowanie użytkowników";
            // 
            // textBoxGracz1
            // 
            textBoxGracz1.Location = new Point(115, 226);
            textBoxGracz1.Name = "textBoxGracz1";
            textBoxGracz1.Size = new Size(181, 35);
            textBoxGracz1.TabIndex = 3;
            textBoxGracz1.TextChanged += textBoxGracz1_TextChanged;
            // 
            // textBoxGracz2
            // 
            textBoxGracz2.Location = new Point(448, 226);
            textBoxGracz2.Name = "textBoxGracz2";
            textBoxGracz2.Size = new Size(204, 35);
            textBoxGracz2.TabIndex = 4;
            textBoxGracz2.TextChanged += textBoxGracz2_TextChanged;
            // 
            // buttonZapisz
            // 
            buttonZapisz.Location = new Point(177, 449);
            buttonZapisz.Name = "buttonZapisz";
            buttonZapisz.Size = new Size(428, 43);
            buttonZapisz.TabIndex = 5;
            buttonZapisz.Text = "Zapisz";
            buttonZapisz.UseVisualStyleBackColor = true;
            buttonZapisz.Click += buttonZapisz_Click;
            // 
            // buttonAnuluj
            // 
            buttonAnuluj.Location = new Point(183, 526);
            buttonAnuluj.Name = "buttonAnuluj";
            buttonAnuluj.Size = new Size(420, 42);
            buttonAnuluj.TabIndex = 6;
            buttonAnuluj.Text = "Anuluj";
            buttonAnuluj.UseVisualStyleBackColor = true;
            buttonAnuluj.Click += buttonAnuluj_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(12, 229);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(64, 30);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 641);
            Controls.Add(labelLogin);
            Controls.Add(buttonAnuluj);
            Controls.Add(buttonZapisz);
            Controls.Add(textBoxGracz2);
            Controls.Add(textBoxGracz1);
            Controls.Add(labelLogowanie);
            Controls.Add(labelGracz2);
            Controls.Add(labelGracz1);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGracz1;
        private Label labelGracz2;
        private Label labelLogowanie;
        private TextBox textBoxGracz1;
        private TextBox textBoxGracz2;
        private Button buttonZapisz;
        private Button buttonAnuluj;
        private Label labelLogin;
    }
}