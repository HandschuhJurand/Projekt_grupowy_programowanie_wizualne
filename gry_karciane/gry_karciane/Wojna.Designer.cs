namespace gry_karciane
{
    partial class Wojna
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
            button_ruch = new Button();
            label_karta_p1 = new Label();
            label_karta_p2 = new Label();
            label_wynik = new Label();
            label_liczba_kart_p1 = new Label();
            label_liczba_kart_p2 = new Label();
            SuspendLayout();
            // 
            // button_ruch
            // 
            button_ruch.Location = new Point(54, 290);
            button_ruch.Name = "button_ruch";
            button_ruch.Size = new Size(150, 40);
            button_ruch.TabIndex = 0;
            button_ruch.Text = "Wykonaj ruch";
            button_ruch.UseVisualStyleBackColor = true;
            button_ruch.Click += button_ruch_Click;
            // 
            // label_karta_p1
            // 
            label_karta_p1.AutoSize = true;
            label_karta_p1.Font = new Font("Segoe UI", 12F);
            label_karta_p1.Location = new Point(54, 195);
            label_karta_p1.Name = "label_karta_p1";
            label_karta_p1.Size = new Size(68, 21);
            label_karta_p1.TabIndex = 1;
            label_karta_p1.Text = "Karta P1";
            // 
            // label_karta_p2
            // 
            label_karta_p2.AutoSize = true;
            label_karta_p2.Font = new Font("Segoe UI", 12F);
            label_karta_p2.Location = new Point(293, 195);
            label_karta_p2.Name = "label_karta_p2";
            label_karta_p2.Size = new Size(68, 21);
            label_karta_p2.TabIndex = 2;
            label_karta_p2.Text = "Karta P2";
            // 
            // label_wynik
            // 
            label_wynik.AutoSize = true;
            label_wynik.Font = new Font("Segoe UI", 20F);
            label_wynik.Location = new Point(54, 30);
            label_wynik.Name = "label_wynik";
            label_wynik.Size = new Size(90, 37);
            label_wynik.TabIndex = 3;
            label_wynik.Text = "Wynik";
            // 
            // label_liczba_kart_p1
            // 
            label_liczba_kart_p1.AutoSize = true;
            label_liczba_kart_p1.Location = new Point(54, 120);
            label_liczba_kart_p1.Name = "label_liczba_kart_p1";
            label_liczba_kart_p1.Size = new Size(52, 15);
            label_liczba_kart_p1.TabIndex = 4;
            label_liczba_kart_p1.Text = "Karty: 26";
            // 
            // label_liczba_kart_p2
            // 
            label_liczba_kart_p2.AutoSize = true;
            label_liczba_kart_p2.Location = new Point(309, 120);
            label_liczba_kart_p2.Name = "label_liczba_kart_p2";
            label_liczba_kart_p2.Size = new Size(52, 15);
            label_liczba_kart_p2.TabIndex = 5;
            label_liczba_kart_p2.Text = "Karty: 26";
            // 
            // Wojna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(label_liczba_kart_p2);
            Controls.Add(label_liczba_kart_p1);
            Controls.Add(label_wynik);
            Controls.Add(label_karta_p2);
            Controls.Add(label_karta_p1);
            Controls.Add(button_ruch);
            Name = "Wojna";
            Text = "Wojna";
            Load += Wojna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_ruch;
        private Label label_karta_p1;
        private Label label_karta_p2;
        private Label label_wynik;
        private Label label_liczba_kart_p1;
        private Label label_liczba_kart_p2;
    }
}