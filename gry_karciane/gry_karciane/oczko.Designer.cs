namespace gry_karciane
{
    partial class oczko
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
            label_tura = new Label();
            label_wartosc_kart = new Label();
            button_dobierz = new Button();
            pictureBox_o1 = new PictureBox();
            label_dobrana_karta = new Label();
            button_zakoncz = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_o1).BeginInit();
            SuspendLayout();
            // 
            // label_tura
            // 
            label_tura.AutoSize = true;
            label_tura.Font = new Font("Segoe UI", 20F);
            label_tura.Location = new Point(13, 27);
            label_tura.Margin = new Padding(4, 0, 4, 0);
            label_tura.Name = "label_tura";
            label_tura.Size = new Size(195, 54);
            label_tura.TabIndex = 4;
            label_tura.Text = "Gracz: xyz";
            // 
            // label_wartosc_kart
            // 
            label_wartosc_kart.AutoSize = true;
            label_wartosc_kart.Location = new Point(13, 113);
            label_wartosc_kart.Margin = new Padding(4, 0, 4, 0);
            label_wartosc_kart.Name = "label_wartosc_kart";
            label_wartosc_kart.Size = new Size(406, 25);
            label_wartosc_kart.TabIndex = 5;
            label_wartosc_kart.Text = "Suma wynikająca z wszystkich posiadanych kart: 0";
            // 
            // button_dobierz
            // 
            button_dobierz.Location = new Point(532, 254);
            button_dobierz.Name = "button_dobierz";
            button_dobierz.Size = new Size(212, 39);
            button_dobierz.TabIndex = 9;
            button_dobierz.Text = "Dobierz kartę";
            button_dobierz.UseVisualStyleBackColor = true;
            button_dobierz.Click += button_dobierz_Click;
            // 
            // pictureBox_o1
            // 
            pictureBox_o1.Location = new Point(13, 236);
            pictureBox_o1.Name = "pictureBox_o1";
            pictureBox_o1.Size = new Size(304, 385);
            pictureBox_o1.TabIndex = 10;
            pictureBox_o1.TabStop = false;
            // 
            // label_dobrana_karta
            // 
            label_dobrana_karta.AutoSize = true;
            label_dobrana_karta.Location = new Point(13, 195);
            label_dobrana_karta.Margin = new Padding(4, 0, 4, 0);
            label_dobrana_karta.Name = "label_dobrana_karta";
            label_dobrana_karta.Size = new Size(198, 25);
            label_dobrana_karta.TabIndex = 12;
            label_dobrana_karta.Text = "Ostatnia dobrana karta:";
            // 
            // button_zakoncz
            // 
            button_zakoncz.AccessibleRole = AccessibleRole.RowHeader;
            button_zakoncz.Location = new Point(532, 372);
            button_zakoncz.Name = "button_zakoncz";
            button_zakoncz.Size = new Size(212, 39);
            button_zakoncz.TabIndex = 11;
            button_zakoncz.Text = "Zakończ dobieranie";
            button_zakoncz.UseVisualStyleBackColor = true;
            button_zakoncz.Click += button_zakoncz_Click;
            // 
            // oczko
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 752);
            Controls.Add(label_dobrana_karta);
            Controls.Add(button_zakoncz);
            Controls.Add(pictureBox_o1);
            Controls.Add(button_dobierz);
            Controls.Add(label_wartosc_kart);
            Controls.Add(label_tura);
            Name = "oczko";
            Text = "Oczko";
            Load += oczko_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_o1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_tura;
        private Label label_wartosc_kart;
        private Button button_dobierz;
        private PictureBox pictureBox_o1;
        private Label label_dobrana_karta;
        private Button button_zakoncz;
    }
}