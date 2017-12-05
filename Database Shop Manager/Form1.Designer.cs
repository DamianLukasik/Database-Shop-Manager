namespace Database_Shop_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelLogowania = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.PanelLogowania.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_login
            // 
            this.tbx_login.Location = new System.Drawing.Point(130, 37);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(145, 20);
            this.tbx_login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(130, 63);
            this.tbx_password.MaxLength = 12;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '☺';
            this.tbx_password.Size = new System.Drawing.Size(145, 20);
            this.tbx_password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // PanelLogowania
            // 
            this.PanelLogowania.Controls.Add(this.btn_login);
            this.PanelLogowania.Controls.Add(this.label1);
            this.PanelLogowania.Controls.Add(this.label2);
            this.PanelLogowania.Controls.Add(this.tbx_login);
            this.PanelLogowania.Controls.Add(this.tbx_password);
            this.PanelLogowania.Location = new System.Drawing.Point(12, 12);
            this.PanelLogowania.Name = "PanelLogowania";
            this.PanelLogowania.Size = new System.Drawing.Size(377, 173);
            this.PanelLogowania.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(130, 89);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(145, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 197);
            this.Controls.Add(this.PanelLogowania);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelLogowania.ResumeLayout(false);
            this.PanelLogowania.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelLogowania;
        private System.Windows.Forms.Button btn_login;
    }
}

