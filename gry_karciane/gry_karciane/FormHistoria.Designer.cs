namespace gry_karciane
{
    partial class FormHistoria
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
            dataGridViewHistoria = new DataGridView();
            labelWynikGracz1 = new Label();
            labelWynikGracz2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoria).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistoria
            // 
            dataGridViewHistoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistoria.Location = new Point(28, 33);
            dataGridViewHistoria.Name = "dataGridViewHistoria";
            dataGridViewHistoria.RowHeadersWidth = 72;
            dataGridViewHistoria.Size = new Size(730, 323);
            dataGridViewHistoria.TabIndex = 0;
            dataGridViewHistoria.CellContentClick += dataGridViewHistoria_CellContentClick;
            // 
            // labelWynikGracz1
            // 
            labelWynikGracz1.AutoSize = true;
            labelWynikGracz1.Location = new Point(31, 392);
            labelWynikGracz1.Name = "labelWynikGracz1";
            labelWynikGracz1.Size = new Size(76, 30);
            labelWynikGracz1.TabIndex = 1;
            labelWynikGracz1.Text = "Gracz1";
            labelWynikGracz1.Click += labelWynikGracz1_Click;
            // 
            // labelWynikGracz2
            // 
            labelWynikGracz2.AutoSize = true;
            labelWynikGracz2.Location = new Point(404, 399);
            labelWynikGracz2.Name = "labelWynikGracz2";
            labelWynikGracz2.Size = new Size(76, 30);
            labelWynikGracz2.TabIndex = 2;
            labelWynikGracz2.Text = "Gracz2";
            labelWynikGracz2.Click += labelWynikGracz2_Click;
            // 
            // FormHistoria
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelWynikGracz2);
            Controls.Add(labelWynikGracz1);
            Controls.Add(dataGridViewHistoria);
            Name = "FormHistoria";
            Text = "FormHistoria";
            Load += FormHistoria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHistoria;
        private Label labelWynikGracz1;
        private Label labelWynikGracz2;
    }
}