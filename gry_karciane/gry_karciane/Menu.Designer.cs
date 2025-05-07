namespace gry_karciane
{
    partial class Menu
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
            button_gra1 = new Button();
            button_gra3 = new Button();
            button_gra2 = new Button();
            button_historia = new Button();
            button_dodaj_graczy = new Button();
            button_koniec = new Button();
            SuspendLayout();
            // 
            // button_gra1
            // 
            button_gra1.Location = new Point(229, 237);
            button_gra1.Location = new Point(160, 142);
            button_gra1.Margin = new Padding(2);
            button_gra1.Name = "button_gra1";
            button_gra1.Size = new Size(214, 37);
            button_gra1.TabIndex = 0;
            button_gra1.Text = "Oczko";
            button_gra1.UseVisualStyleBackColor = true;
            button_gra1.Click += button_gra1_Click;
            // 
            // button_gra3
            // 
            button_gra3.Location = new Point(229, 367);
            button_gra3.Location = new Point(160, 220);
            button_gra3.Margin = new Padding(2);
            button_gra3.Name = "button_gra3";
            button_gra3.Size = new Size(214, 37);
            button_gra3.TabIndex = 1;
            button_gra3.Text = "Baccarat";
            button_gra3.UseVisualStyleBackColor = true;
            button_gra3.Click += button_gra3_Click;
            // 
            // button_gra2
            // 
            button_gra2.Location = new Point(229, 300);
            button_gra2.Location = new Point(160, 180);
            button_gra2.Margin = new Padding(2);
            button_gra2.Name = "button_gra2";
            button_gra2.Size = new Size(214, 40);
            button_gra2.TabIndex = 2;
            button_gra2.Text = "Wojna";
            button_gra2.UseVisualStyleBackColor = true;
            button_gra2.Click += button_gra2_Click;
            // 
            // button_historia
            // 
            button_historia.Location = new Point(229, 517);
            button_historia.Location = new Point(160, 310);
            button_historia.Margin = new Padding(2);
            button_historia.Name = "button_historia";
            button_historia.Size = new Size(214, 43);
            button_historia.TabIndex = 3;
            button_historia.Text = "Historia";
            button_historia.UseVisualStyleBackColor = true;
            button_historia.Click += button_historia_Click;
            // 
            // button_dodaj_graczy
            // 
            button_dodaj_graczy.Location = new Point(229, 460);
            button_dodaj_graczy.Location = new Point(160, 276);
            button_dodaj_graczy.Margin = new Padding(2);
            button_dodaj_graczy.Name = "button_dodaj_graczy";
            button_dodaj_graczy.Size = new Size(214, 33);
            button_dodaj_graczy.TabIndex = 4;
            button_dodaj_graczy.Text = "Dodaj graczy";
            button_dodaj_graczy.UseVisualStyleBackColor = true;
            button_dodaj_graczy.Click += button_dodaj_graczy_Click;
            // 
            // button_koniec
            // 
            button_koniec.Location = new Point(229, 610);
            button_koniec.Location = new Point(160, 366);
            button_koniec.Margin = new Padding(2);
            button_koniec.Name = "button_koniec";
            button_koniec.Size = new Size(214, 40);
            button_koniec.TabIndex = 5;
            button_koniec.Text = "Koniec";
            button_koniec.UseVisualStyleBackColor = true;
            button_koniec.Click += button_koniec_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 1003);
            Controls.Add(button_koniec);
            Controls.Add(button_dodaj_graczy);
            Controls.Add(button_historia);
            Controls.Add(button_gra2);
            Controls.Add(button_gra3);
            Controls.Add(button_gra1);
            Margin = new Padding(2);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button_gra1;
        private Button button_gra3;
        private Button button_gra2;
        private Button button_historia;
        private Button button_dodaj_graczy;
        private Button button_koniec;
    }
}
