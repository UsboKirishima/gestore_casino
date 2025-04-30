namespace WinFormsCasino
{
    partial class FormGestioneTransazioni
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
            dgvTransazioni = new DataGridView();
            txtFiches = new TextBox();
            txtContanti = new TextBox();
            btnAggiungi = new Button();
            btnElimina = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransazioni).BeginInit();
            SuspendLayout();
            // 
            // dgvTransazioni
            // 
            dgvTransazioni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransazioni.Location = new Point(129, 105);
            dgvTransazioni.Name = "dgvTransazioni";
            dgvTransazioni.Size = new Size(475, 209);
            dgvTransazioni.TabIndex = 0;
            // 
            // txtFiches
            // 
            txtFiches.Location = new Point(142, 374);
            txtFiches.Name = "txtFiches";
            txtFiches.Size = new Size(100, 23);
            txtFiches.TabIndex = 1;
            // 
            // txtContanti
            // 
            txtContanti.Location = new Point(273, 374);
            txtContanti.Name = "txtContanti";
            txtContanti.Size = new Size(100, 23);
            txtContanti.TabIndex = 2;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(400, 374);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(75, 23);
            btnAggiungi.TabIndex = 3;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(503, 374);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(75, 23);
            btnElimina.TabIndex = 4;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += btnElimina_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 356);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Denaro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 356);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Fiches";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(255, 28);
            label3.Name = "label3";
            label3.Size = new Size(222, 25);
            label3.TabIndex = 7;
            label3.Text = "GESTIONE TRANSAZIONI";
            // 
            // FormGestioneTransazioni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 459);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnElimina);
            Controls.Add(btnAggiungi);
            Controls.Add(txtContanti);
            Controls.Add(txtFiches);
            Controls.Add(dgvTransazioni);
            Name = "FormGestioneTransazioni";
            Text = "FormGestioneTransizioni";
            ((System.ComponentModel.ISupportInitialize)dgvTransazioni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTransazioni;
        private TextBox txtFiches;
        private TextBox txtContanti;
        private Button btnAggiungi;
        private Button btnElimina;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}