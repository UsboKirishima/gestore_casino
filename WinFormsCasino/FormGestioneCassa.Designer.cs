namespace WinFormsCasino
{
    partial class FormGestioneCassa
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
            dgvCassa = new DataGridView();
            lbTransazione = new Label();
            btEseguiTransazione = new Button();
            tbTransazione = new TextBox();
            dgvTransazione = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCassa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransazione).BeginInit();
            SuspendLayout();
            // 
            // dgvCassa
            // 
            dgvCassa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCassa.Location = new Point(470, 11);
            dgvCassa.Margin = new Padding(2);
            dgvCassa.Name = "dgvCassa";
            dgvCassa.RowHeadersWidth = 62;
            dgvCassa.Size = new Size(255, 378);
            dgvCassa.TabIndex = 0;
            // 
            // lbTransazione
            // 
            lbTransazione.AutoSize = true;
            lbTransazione.Location = new Point(20, 175);
            lbTransazione.Margin = new Padding(2, 0, 2, 0);
            lbTransazione.Name = "lbTransazione";
            lbTransazione.Size = new Size(68, 15);
            lbTransazione.TabIndex = 1;
            lbTransazione.Text = "Transazione";
            // 
            // btEseguiTransazione
            // 
            btEseguiTransazione.Location = new Point(325, 170);
            btEseguiTransazione.Margin = new Padding(2);
            btEseguiTransazione.Name = "btEseguiTransazione";
            btEseguiTransazione.Size = new Size(132, 25);
            btEseguiTransazione.TabIndex = 2;
            btEseguiTransazione.Text = "Esegui Transazione";
            btEseguiTransazione.UseVisualStyleBackColor = true;
            btEseguiTransazione.Click += btEseguiTransazione_Click;
            // 
            // tbTransazione
            // 
            tbTransazione.Location = new Point(92, 172);
            tbTransazione.Margin = new Padding(2);
            tbTransazione.Name = "tbTransazione";
            tbTransazione.Size = new Size(229, 23);
            tbTransazione.TabIndex = 3;
            // 
            // dgvTransazione
            // 
            dgvTransazione.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransazione.Location = new Point(11, 11);
            dgvTransazione.Margin = new Padding(2);
            dgvTransazione.Name = "dgvTransazione";
            dgvTransazione.RowHeadersWidth = 62;
            dgvTransazione.Size = new Size(446, 147);
            dgvTransazione.TabIndex = 4;
            // 
            // FormGestioneCassa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 400);
            Controls.Add(dgvTransazione);
            Controls.Add(tbTransazione);
            Controls.Add(btEseguiTransazione);
            Controls.Add(lbTransazione);
            Controls.Add(dgvCassa);
            Margin = new Padding(2);
            Name = "FormGestioneCassa";
            Text = "FormGestioneCassa";
            ((System.ComponentModel.ISupportInitialize)dgvCassa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransazione).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCassa;
        private Label lbTransazione;
        private Button btEseguiTransazione;
        private TextBox tbTransazione;
        private DataGridView dgvTransazione;
    }
}