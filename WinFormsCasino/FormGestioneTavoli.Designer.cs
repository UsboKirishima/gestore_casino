namespace WinFormsCasino
{
    partial class FormGestioneTavoli
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
            dgvTavoli = new DataGridView();
            txtGioco = new TextBox();
            nudPosti = new NumericUpDown();
            nudMinBet = new NumericUpDown();
            nudMaxBet = new NumericUpDown();
            cbxCroupier = new CheckBox();
            btnAggiungi = new Button();
            btnElimina = new Button();
            btnModifica = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTavoli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPosti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBet).BeginInit();
            SuspendLayout();
            // 
            // dgvTavoli
            // 
            dgvTavoli.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTavoli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTavoli.Location = new Point(243, 105);
            dgvTavoli.Name = "dgvTavoli";
            dgvTavoli.Size = new Size(345, 356);
            dgvTavoli.TabIndex = 0;
            dgvTavoli.SelectionChanged += dgvTavoli_SelectionChanged;
            // 
            // txtGioco
            // 
            txtGioco.Location = new Point(71, 153);
            txtGioco.Name = "txtGioco";
            txtGioco.Size = new Size(120, 23);
            txtGioco.TabIndex = 1;
            // 
            // nudPosti
            // 
            nudPosti.Location = new Point(69, 220);
            nudPosti.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudPosti.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudPosti.Name = "nudPosti";
            nudPosti.Size = new Size(120, 23);
            nudPosti.TabIndex = 2;
            nudPosti.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // nudMinBet
            // 
            nudMinBet.DecimalPlaces = 2;
            nudMinBet.Location = new Point(69, 289);
            nudMinBet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMinBet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMinBet.Name = "nudMinBet";
            nudMinBet.Size = new Size(120, 23);
            nudMinBet.TabIndex = 3;
            nudMinBet.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // nudMaxBet
            // 
            nudMaxBet.DecimalPlaces = 2;
            nudMaxBet.Location = new Point(69, 360);
            nudMaxBet.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMaxBet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxBet.Name = "nudMaxBet";
            nudMaxBet.Size = new Size(120, 23);
            nudMaxBet.TabIndex = 4;
            nudMaxBet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxCroupier
            // 
            cbxCroupier.AutoSize = true;
            cbxCroupier.Location = new Point(95, 428);
            cbxCroupier.Name = "cbxCroupier";
            cbxCroupier.Size = new Size(72, 19);
            cbxCroupier.TabIndex = 5;
            cbxCroupier.Text = "Croupier";
            cbxCroupier.UseVisualStyleBackColor = true;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(351, 497);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(75, 23);
            btnAggiungi.TabIndex = 6;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(513, 497);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(75, 23);
            btnElimina.TabIndex = 7;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(432, 497);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(75, 23);
            btnModifica.TabIndex = 8;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 34);
            label1.Name = "label1";
            label1.Size = new Size(179, 24);
            label1.TabIndex = 10;
            label1.Text = "GESTIONE TAVOLI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 135);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 11;
            label2.Text = "Tipo Gioco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 202);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 12;
            label3.Text = "Posti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 271);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 13;
            label4.Text = "Min Bet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 342);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 14;
            label5.Text = "Max Bet";
            // 
            // FormGestioneTavoli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 549);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModifica);
            Controls.Add(btnElimina);
            Controls.Add(btnAggiungi);
            Controls.Add(cbxCroupier);
            Controls.Add(nudMaxBet);
            Controls.Add(nudMinBet);
            Controls.Add(nudPosti);
            Controls.Add(txtGioco);
            Controls.Add(dgvTavoli);
            Name = "FormGestioneTavoli";
            Text = "FormGestioneTavoli";
            ((System.ComponentModel.ISupportInitialize)dgvTavoli).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPosti).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTavoli;
        private TextBox txtGioco;
        private NumericUpDown nudPosti;
        private NumericUpDown nudMinBet;
        private NumericUpDown nudMaxBet;
        private CheckBox cbxCroupier;
        private Button btnAggiungi;
        private Button btnElimina;
        private Button btnModifica;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}