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
            label1 = new Label();
            skipBtn = new Button();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Location = new Point(196, 228);
            btLogin.Margin = new Padding(2);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(198, 25);
            btLogin.TabIndex = 0;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(205, 105);
            lbUsername.Margin = new Padding(2, 0, 2, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(205, 165);
            lbPassword.Margin = new Padding(2, 0, 2, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(196, 127);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(198, 23);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(196, 182);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(198, 23);
            tbPassword.TabIndex = 4;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // lbErrore
            // 
            lbErrore.AutoSize = true;
            lbErrore.Location = new Point(205, 238);
            lbErrore.Margin = new Padding(2, 0, 2, 0);
            lbErrore.Name = "lbErrore";
            lbErrore.Size = new Size(0, 15);
            lbErrore.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 19);
            label1.Name = "label1";
            label1.Size = new Size(357, 65);
            label1.TabIndex = 6;
            label1.Text = "Gestore Casinò";
            label1.Click += label1_Click;
            // 
            // skipBtn
            // 
            skipBtn.Location = new Point(532, 320);
            skipBtn.Name = "skipBtn";
            skipBtn.Size = new Size(75, 23);
            skipBtn.TabIndex = 7;
            skipBtn.Text = "Skip";
            skipBtn.UseVisualStyleBackColor = true;
            skipBtn.Click += skipBtn_Click;
            // 
            // LoginAmministratore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(skipBtn);
            Controls.Add(label1);
            Controls.Add(lbErrore);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(btLogin);
            Margin = new Padding(2);
            Name = "LoginAmministratore";
            Size = new Size(623, 356);
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
        private Label label1;
        private Button skipBtn;
    }
}
