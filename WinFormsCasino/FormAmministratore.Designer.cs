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
            btTurni.Location = new Point(32, 82);
            btTurni.Name = "btTurni";
            btTurni.Size = new Size(267, 34);
            btTurni.TabIndex = 1;
            btTurni.Text = "Gestione Turni";
            btTurni.UseVisualStyleBackColor = true;
            // 
            // btCassa
            // 
            btCassa.Location = new Point(465, 82);
            btCassa.Name = "btCassa";
            btCassa.Size = new Size(267, 34);
            btCassa.TabIndex = 2;
            btCassa.Text = "Gestione cassa";
            btCassa.UseVisualStyleBackColor = true;
            btCassa.Click += btCassa_Click;
            // 
            // btEntrateUscite
            // 
            btEntrateUscite.Location = new Point(32, 232);
            btEntrateUscite.Name = "btEntrateUscite";
            btEntrateUscite.Size = new Size(267, 34);
            btEntrateUscite.TabIndex = 3;
            btEntrateUscite.Text = "Gestione entrate/uscite";
            btEntrateUscite.UseVisualStyleBackColor = true;
            // 
            // btTavoli
            // 
            btTavoli.Location = new Point(465, 232);
            btTavoli.Name = "btTavoli";
            btTavoli.Size = new Size(267, 34);
            btTavoli.TabIndex = 4;
            btTavoli.Text = "Gestione Tavoli";
            btTavoli.UseVisualStyleBackColor = true;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(320, 371);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(112, 34);
            btLogout.TabIndex = 5;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // loginAmministratore1
            // 
            loginAmministratore1.Location = new Point(-1, 1);
            loginAmministratore1.Name = "loginAmministratore1";
            loginAmministratore1.Size = new Size(809, 456);
            loginAmministratore1.TabIndex = 6;
            // 
            // FormAmministratore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginAmministratore1);
            Controls.Add(btLogout);
            Controls.Add(btTavoli);
            Controls.Add(btEntrateUscite);
            Controls.Add(btCassa);
            Controls.Add(btTurni);
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
