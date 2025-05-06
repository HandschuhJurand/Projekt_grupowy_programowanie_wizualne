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
            label_wynik = new Label();
            label_liczba_kart_p1 = new Label();
            label_liczba_kart_p2 = new Label();
            pictureBox_p1 = new PictureBox();
            pictureBox_p2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_p1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_p2).BeginInit();
            SuspendLayout();
            // 
            // button_ruch
            // 
            button_ruch.Location = new Point(531, 52);
            button_ruch.Margin = new Padding(4, 5, 4, 5);
            button_ruch.Name = "button_ruch";
            button_ruch.Size = new Size(214, 67);
            button_ruch.TabIndex = 0;
            button_ruch.Text = "Wykonaj ruch";
            button_ruch.UseVisualStyleBackColor = true;
            button_ruch.Click += button_ruch_Click;
            // 
            // label_wynik
            // 
            label_wynik.AutoSize = true;
            label_wynik.Font = new Font("Segoe UI", 20F);
            label_wynik.Location = new Point(77, 50);
            label_wynik.Margin = new Padding(4, 0, 4, 0);
            label_wynik.Name = "label_wynik";
            label_wynik.Size = new Size(132, 54);
            label_wynik.TabIndex = 3;
            label_wynik.Text = "Wynik";
            // 
            // label_liczba_kart_p1
            // 
            label_liczba_kart_p1.AutoSize = true;
            label_liczba_kart_p1.Location = new Point(77, 200);
            label_liczba_kart_p1.Margin = new Padding(4, 0, 4, 0);
            label_liczba_kart_p1.Name = "label_liczba_kart_p1";
            label_liczba_kart_p1.Size = new Size(81, 25);
            label_liczba_kart_p1.TabIndex = 4;
            label_liczba_kart_p1.Text = "Karty: 26";
            // 
            // label_liczba_kart_p2
            // 
            label_liczba_kart_p2.AutoSize = true;
            label_liczba_kart_p2.Location = new Point(780, 200);
            label_liczba_kart_p2.Margin = new Padding(4, 0, 4, 0);
            label_liczba_kart_p2.Name = "label_liczba_kart_p2";
            label_liczba_kart_p2.Size = new Size(81, 25);
            label_liczba_kart_p2.TabIndex = 5;
            label_liczba_kart_p2.Text = "Karty: 26";
            // 
            // pictureBox_p1
            // 
            pictureBox_p1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_p1.Location = new Point(77, 248);
            pictureBox_p1.Margin = new Padding(4, 5, 4, 5);
            pictureBox_p1.Name = "pictureBox_p1";
            pictureBox_p1.Size = new Size(256, 407);
            pictureBox_p1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_p1.TabIndex = 6;
            pictureBox_p1.TabStop = false;
            pictureBox_p1.Click += pictureBox_p1_Click;
            // 
            // pictureBox_p2
            // 
            pictureBox_p2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_p2.Location = new Point(489, 248);
            pictureBox_p2.Margin = new Padding(4, 5, 4, 5);
            pictureBox_p2.Name = "pictureBox_p2";
            pictureBox_p2.Size = new Size(256, 407);
            pictureBox_p2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_p2.TabIndex = 7;
            pictureBox_p2.TabStop = false;
            // 
            // Wojna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 1050);
            Controls.Add(pictureBox_p2);
            Controls.Add(pictureBox_p1);
            Controls.Add(label_liczba_kart_p2);
            Controls.Add(label_liczba_kart_p1);
            Controls.Add(label_wynik);
            Controls.Add(button_ruch);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Wojna";
            Text = "Wojna";
            Load += Wojna_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_p1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_p2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_ruch;
        private Label label_wynik;
        private Label label_liczba_kart_p1;
        private Label label_liczba_kart_p2;
        private PictureBox pictureBox_p1;
        private PictureBox pictureBox_p2;
    }
}