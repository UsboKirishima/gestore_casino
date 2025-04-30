namespace WinFormsCasino
{
    partial class FormGestioneTurni
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
            dgvTurni = new DataGridView();
            dtpInizio = new DateTimePicker();
            btnAggiungi = new Button();
            btnElimina = new Button();
            btnModifica = new Button();
            dtpFine = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTurni).BeginInit();
            SuspendLayout();
            // 
            // dgvTurni
            // 
            dgvTurni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurni.Location = new Point(34, 143);
            dgvTurni.Name = "dgvTurni";
            dgvTurni.Size = new Size(355, 387);
            dgvTurni.TabIndex = 0;
            // 
            // dtpInizio
            // 
            dtpInizio.Location = new Point(457, 197);
            dtpInizio.Name = "dtpInizio";
            dtpInizio.Size = new Size(200, 23);
            dtpInizio.TabIndex = 1;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(515, 408);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(75, 23);
            btnAggiungi.TabIndex = 2;
            btnAggiungi.Text = "aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(515, 437);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(75, 23);
            btnElimina.TabIndex = 3;
            btnElimina.Text = "elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(515, 466);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(75, 23);
            btnModifica.TabIndex = 4;
            btnModifica.Text = "modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // dtpFine
            // 
            dtpFine.Location = new Point(457, 313);
            dtpFine.Name = "dtpFine";
            dtpFine.Size = new Size(200, 23);
            dtpFine.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(539, 179);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "Inizio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 295);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 7;
            label2.Text = "Fine:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 32);
            label3.Name = "label3";
            label3.Size = new Size(196, 32);
            label3.TabIndex = 8;
            label3.Text = "GESTIONE TURNI";
            // 
            // FormGestioneTurni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 560);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFine);
            Controls.Add(btnModifica);
            Controls.Add(btnElimina);
            Controls.Add(btnAggiungi);
            Controls.Add(dtpInizio);
            Controls.Add(dgvTurni);
            Name = "FormGestioneTurni";
            Text = "FormGestioneTurni";
            ((System.ComponentModel.ISupportInitialize)dgvTurni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTurni;
        private DateTimePicker dtpInizio;
        private Button btnAggiungi;
        private Button btnElimina;
        private Button btnModifica;
        private DateTimePicker dtpFine;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}