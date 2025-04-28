namespace WinFormsCasino
{
    partial class FormAmministratore
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
            btTurni = new Button();
            btCassa = new Button();
            btEntrateUscite = new Button();
            btTavoli = new Button();
            btLogout = new Button();
            loginAmministratore1 = new LoginAmministratore();
            SuspendLayout();
            // 
            // btTurni
            // 
            btTurni.Location = new Point(218, 96);
            btTurni.Margin = new Padding(2);
            btTurni.Name = "btTurni";
            btTurni.Size = new Size(187, 34);
            btTurni.TabIndex = 1;
            btTurni.Text = "Gestione Turni";
            btTurni.UseVisualStyleBackColor = true;
            // 
            // btCassa
            // 
            btCassa.Location = new Point(218, 134);
            btCassa.Margin = new Padding(2);
            btCassa.Name = "btCassa";
            btCassa.Size = new Size(187, 34);
            btCassa.TabIndex = 2;
            btCassa.Text = "Gestione cassa";
            btCassa.UseVisualStyleBackColor = true;
            btCassa.Click += btCassa_Click;
            // 
            // btEntrateUscite
            // 
            btEntrateUscite.Location = new Point(218, 172);
            btEntrateUscite.Margin = new Padding(2);
            btEntrateUscite.Name = "btEntrateUscite";
            btEntrateUscite.Size = new Size(187, 34);
            btEntrateUscite.TabIndex = 3;
            btEntrateUscite.Text = "Gestione entrate/uscite";
            btEntrateUscite.UseVisualStyleBackColor = true;
            // 
            // btTavoli
            // 
            btTavoli.Location = new Point(218, 210);
            btTavoli.Margin = new Padding(2);
            btTavoli.Name = "btTavoli";
            btTavoli.Size = new Size(187, 34);
            btTavoli.TabIndex = 4;
            btTavoli.Text = "Gestione Tavoli";
            btTavoli.UseVisualStyleBackColor = true;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(555, 11);
            btLogout.Margin = new Padding(2);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(78, 25);
            btLogout.TabIndex = 5;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // loginAmministratore1
            // 
            loginAmministratore1.Location = new Point(10, 10);
            loginAmministratore1.Margin = new Padding(1);
            loginAmministratore1.Name = "loginAmministratore1";
            loginAmministratore1.Size = new Size(623, 356);
            loginAmministratore1.TabIndex = 6;
            loginAmministratore1.Load += loginAmministratore1_Load;
            // 
            // FormAmministratore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 376);
            Controls.Add(loginAmministratore1);
            Controls.Add(btLogout);
            Controls.Add(btTavoli);
            Controls.Add(btEntrateUscite);
            Controls.Add(btCassa);
            Controls.Add(btTurni);
            Margin = new Padding(2);
            Name = "FormAmministratore";
            Text = "Pannello Amministratore";
            ResumeLayout(false);
        }

        #endregion
        private Button btTurni;
        private Button btCassa;
        private Button btEntrateUscite;
        private Button btTavoli;
        private Button btLogout;
        private LoginAmministratore loginAmministratore1;
    }
}
