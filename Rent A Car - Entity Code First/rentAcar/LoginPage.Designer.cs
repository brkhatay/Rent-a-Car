namespace rentAcar
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPageUpPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.RPpassPanel = new System.Windows.Forms.Panel();
            this.buttonLog = new panel.cutomButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRGPclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üye Girişi";
            // 
            // LoginPageUpPanel
            // 
            this.LoginPageUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoginPageUpPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.LoginPageUpPanel.Location = new System.Drawing.Point(1, 0);
            this.LoginPageUpPanel.Name = "LoginPageUpPanel";
            this.LoginPageUpPanel.Size = new System.Drawing.Size(455, 25);
            this.LoginPageUpPanel.TabIndex = 29;
            this.LoginPageUpPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginPageUpPanel_MouseMove_1);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Indigo;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.ForeColor = System.Drawing.Color.LightGray;
            this.txtUserName.Location = new System.Drawing.Point(144, 119);
            this.txtUserName.MaxLength = 11;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 17);
            this.txtUserName.TabIndex = 30;
            this.txtUserName.Text = "TC";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(144, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 2);
            this.panel1.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Indigo;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtPassword.Location = new System.Drawing.Point(144, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 17);
            this.txtPassword.TabIndex = 33;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // RPpassPanel
            // 
            this.RPpassPanel.BackColor = System.Drawing.Color.White;
            this.RPpassPanel.Location = new System.Drawing.Point(144, 185);
            this.RPpassPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.RPpassPanel.Name = "RPpassPanel";
            this.RPpassPanel.Size = new System.Drawing.Size(139, 2);
            this.RPpassPanel.TabIndex = 32;
            // 
            // buttonLog
            // 
            this.buttonLog.Angle = 109F;
            this.buttonLog.Anim = true;
            this.buttonLog.BackColor = System.Drawing.Color.Indigo;
            this.buttonLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLog.borderRadius = 45;
            this.buttonLog.c0 = System.Drawing.Color.PaleVioletRed;
            this.buttonLog.c1 = System.Drawing.Color.DeepPink;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLog.ForeColor = System.Drawing.Color.White;
            this.buttonLog.Location = new System.Drawing.Point(162, 216);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(104, 46);
            this.buttonLog.TabIndex = 34;
            this.buttonLog.text = "Giriş";
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(144, 79);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(139, 2);
            this.panel8.TabIndex = 36;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(188, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 16);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::rentAcar.Properties.Resources.admin;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(381, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRGPclose
            // 
            this.buttonRGPclose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRGPclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonRGPclose.BackgroundImage = global::rentAcar.Properties.Resources.close_button_png_24;
            this.buttonRGPclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRGPclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRGPclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonRGPclose.Location = new System.Drawing.Point(430, 0);
            this.buttonRGPclose.Name = "buttonRGPclose";
            this.buttonRGPclose.Size = new System.Drawing.Size(26, 25);
            this.buttonRGPclose.TabIndex = 28;
            this.buttonRGPclose.UseVisualStyleBackColor = false;
            this.buttonRGPclose.Click += new System.EventHandler(this.buttonRGPclose_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(457, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonRGPclose);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.RPpassPanel);
            this.Controls.Add(this.LoginPageUpPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel LoginPageUpPanel;
        private System.Windows.Forms.Button buttonRGPclose;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel RPpassPanel;
        private panel.cutomButton buttonLog;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}