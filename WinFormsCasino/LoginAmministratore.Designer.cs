namespace WinFormsCasino
{
    partial class LoginAmministratore
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            btLogin = new Button();
            lbUsername = new Label();
            lbPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lbErrore = new Label();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Location = new Point(142, 228);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(112, 34);
            btLogin.TabIndex = 0;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(50, 76);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(91, 25);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(50, 153);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(235, 76);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(150, 31);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(235, 153);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(150, 31);
            tbPassword.TabIndex = 4;
            // 
            // lbErrore
            // 
            lbErrore.AutoSize = true;
            lbErrore.Location = new Point(175, 298);
            lbErrore.Name = "lbErrore";
            lbErrore.Size = new Size(0, 25);
            lbErrore.TabIndex = 5;
            // 
            // LoginAmministratore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbErrore);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(btLogin);
            Name = "LoginAmministratore";
            Size = new Size(438, 360);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbErrore;
    }
}
