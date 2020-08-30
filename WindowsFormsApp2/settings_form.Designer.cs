namespace employee_tracker
{
    partial class settings_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings_form));
            this.startupCheck = new System.Windows.Forms.CheckBox();
            this.loginCheck = new System.Windows.Forms.CheckBox();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startupCheck
            // 
            this.startupCheck.AutoSize = true;
            this.startupCheck.BackColor = System.Drawing.Color.Transparent;
            this.startupCheck.Location = new System.Drawing.Point(13, 13);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(149, 17);
            this.startupCheck.TabIndex = 0;
            this.startupCheck.Text = "Start with windows startup";
            this.startupCheck.UseVisualStyleBackColor = false;
            // 
            // loginCheck
            // 
            this.loginCheck.AutoSize = true;
            this.loginCheck.BackColor = System.Drawing.Color.Transparent;
            this.loginCheck.Location = new System.Drawing.Point(13, 37);
            this.loginCheck.Name = "loginCheck";
            this.loginCheck.Size = new System.Drawing.Size(120, 17);
            this.loginCheck.TabIndex = 1;
            this.loginCheck.Text = "Keep Me Logged In";
            this.loginCheck.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.logout.Location = new System.Drawing.Point(13, 73);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(149, 37);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 212);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.loginCheck);
            this.Controls.Add(this.startupCheck);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startupCheck;
        private System.Windows.Forms.CheckBox loginCheck;
        private System.Windows.Forms.Button logout;
    }
}