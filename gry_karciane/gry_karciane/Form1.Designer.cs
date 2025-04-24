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
            button_gra1.Location = new Point(273, 236);
            button_gra1.Name = "button_gra1";
            button_gra1.Size = new Size(112, 34);
            button_gra1.TabIndex = 0;
            button_gra1.Text = "Olimpia";
            button_gra1.UseVisualStyleBackColor = true;
            // 
            // button_gra3
            // 
            button_gra3.Location = new Point(273, 366);
            button_gra3.Name = "button_gra3";
            button_gra3.Size = new Size(112, 34);
            button_gra3.TabIndex = 1;
            button_gra3.Text = "Grzesiek";
            button_gra3.UseVisualStyleBackColor = true;
            // 
            // button_gra2
            // 
            button_gra2.Location = new Point(273, 300);
            button_gra2.Name = "button_gra2";
            button_gra2.Size = new Size(112, 34);
            button_gra2.TabIndex = 2;
            button_gra2.Text = "Jurand";
            button_gra2.UseVisualStyleBackColor = true;
            // 
            // button_historia
            // 
            button_historia.Location = new Point(276, 443);
            button_historia.Name = "button_historia";
            button_historia.Size = new Size(112, 34);
            button_historia.TabIndex = 3;
            button_historia.Text = "Historia";
            button_historia.UseVisualStyleBackColor = true;
            // 
            // button_dodaj_graczy
            // 
            button_dodaj_graczy.Location = new Point(276, 523);
            button_dodaj_graczy.Name = "button_dodaj_graczy";
            button_dodaj_graczy.Size = new Size(112, 34);
            button_dodaj_graczy.TabIndex = 4;
            button_dodaj_graczy.Text = "Dodaj";
            button_dodaj_graczy.UseVisualStyleBackColor = true;
            // 
            // button_koniec
            // 
            button_koniec.Location = new Point(280, 618);
            button_koniec.Name = "button_koniec";
            button_koniec.Size = new Size(112, 34);
            button_koniec.TabIndex = 5;
            button_koniec.Text = "Zapisz";
            button_koniec.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 1004);
            Controls.Add(button_koniec);
            Controls.Add(button_dodaj_graczy);
            Controls.Add(button_historia);
            Controls.Add(button_gra2);
            Controls.Add(button_gra3);
            Controls.Add(button_gra1);
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
