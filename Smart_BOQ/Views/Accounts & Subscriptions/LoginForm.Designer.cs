using System.Drawing;
using System.Windows.Forms;

namespace Smart_BOQ.Views.AccountsAndSubscriptions
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutRoot;
        private Panel panelCard;
        private TableLayoutPanel layoutCard;
        private PictureBox picLogo;
        private Label lblAppName;
        private Label lblSubtitle;
        private Label lblEmailOrPhone;
        private TextBox txtEmailOrPhone;
        private Label lblPassword;
        private TextBox txtPassword;
        private FlowLayoutPanel rowOptions;
        private CheckBox chkRemember;
        private LinkLabel linkForgotPassword;
        private Button btnLogin;
        private Button btnWindowsHello;
        private FlowLayoutPanel rowFooter;
        private Label lblNoAccount;
        private LinkLabel linkCreateAccount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.layoutRoot = new System.Windows.Forms.TableLayoutPanel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.layoutCard = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblEmailOrPhone = new System.Windows.Forms.Label();
            this.txtEmailOrPhone = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rowOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnWindowsHello = new System.Windows.Forms.Button();
            this.rowFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.layoutRoot.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.layoutCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.rowOptions.SuspendLayout();
            this.rowFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutRoot
            // 
            this.layoutRoot.ColumnCount = 1;
            this.layoutRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.Controls.Add(this.panelCard, 0, 0);
            this.layoutRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRoot.Location = new System.Drawing.Point(0, 0);
            this.layoutRoot.Name = "layoutRoot";
            this.layoutRoot.RowCount = 1;
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.Size = new System.Drawing.Size(540, 720);
            this.layoutRoot.TabIndex = 0;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.layoutCard);
            this.panelCard.Location = new System.Drawing.Point(40, 50);
            this.panelCard.Margin = new System.Windows.Forms.Padding(0);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(30);
            this.panelCard.Size = new System.Drawing.Size(460, 620);
            this.panelCard.TabIndex = 0;
            // 
            // layoutCard
            // 
            this.layoutCard.ColumnCount = 1;
            this.layoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCard.Controls.Add(this.picLogo, 0, 0);
            this.layoutCard.Controls.Add(this.lblAppName, 0, 1);
            this.layoutCard.Controls.Add(this.lblSubtitle, 0, 2);
            this.layoutCard.Controls.Add(this.lblEmailOrPhone, 0, 4);
            this.layoutCard.Controls.Add(this.txtEmailOrPhone, 0, 5);
            this.layoutCard.Controls.Add(this.lblPassword, 0, 6);
            this.layoutCard.Controls.Add(this.txtPassword, 0, 7);
            this.layoutCard.Controls.Add(this.rowOptions, 0, 8);
            this.layoutCard.Controls.Add(this.btnLogin, 0, 9);
            this.layoutCard.Controls.Add(this.btnWindowsHello, 0, 10);
            this.layoutCard.Controls.Add(this.rowFooter, 0, 12);
            this.layoutCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCard.Location = new System.Drawing.Point(30, 30);
            this.layoutCard.Name = "layoutCard";
            this.layoutCard.RowCount = 14;
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCard.Size = new System.Drawing.Size(398, 558);
            this.layoutCard.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(392, 114);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblAppName.Location = new System.Drawing.Point(3, 120);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(392, 48);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Smart_BOQ";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(3, 168);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(392, 34);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "سجل دخولك للمتابعة";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailOrPhone
            // 
            this.lblEmailOrPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmailOrPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailOrPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblEmailOrPhone.Location = new System.Drawing.Point(3, 218);
            this.lblEmailOrPhone.Name = "lblEmailOrPhone";
            this.lblEmailOrPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmailOrPhone.Size = new System.Drawing.Size(392, 26);
            this.lblEmailOrPhone.TabIndex = 3;
            this.lblEmailOrPhone.Text = "البريد الإلكتروني أو رقم الهاتف";
            this.lblEmailOrPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailOrPhone
            // 
            this.txtEmailOrPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailOrPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailOrPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmailOrPhone.Location = new System.Drawing.Point(3, 247);
            this.txtEmailOrPhone.Name = "txtEmailOrPhone";
            this.txtEmailOrPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmailOrPhone.Size = new System.Drawing.Size(392, 32);
            this.txtEmailOrPhone.TabIndex = 4;
            this.txtEmailOrPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPassword
            // 
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPassword.Location = new System.Drawing.Point(3, 290);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(392, 26);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "كلمة المرور";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(3, 319);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(392, 32);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // rowOptions
            // 
            this.rowOptions.Controls.Add(this.linkForgotPassword);
            this.rowOptions.Controls.Add(this.chkRemember);
            this.rowOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowOptions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.rowOptions.Location = new System.Drawing.Point(3, 362);
            this.rowOptions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.rowOptions.Name = "rowOptions";
            this.rowOptions.Size = new System.Drawing.Size(392, 42);
            this.rowOptions.TabIndex = 7;
            this.rowOptions.WrapContents = false;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.chkRemember.Location = new System.Drawing.Point(146, 8);
            this.chkRemember.Margin = new System.Windows.Forms.Padding(0, 8, 0, 120);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(82, 27);
            this.chkRemember.TabIndex = 0;
            this.chkRemember.Text = "تذكرني";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.linkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkForgotPassword.Location = new System.Drawing.Point(0, 8);
            this.linkForgotPassword.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(146, 23);
            this.linkForgotPassword.TabIndex = 1;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "نسيت كلمة المرور؟";
            this.linkForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPassword_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.Location = new System.Drawing.Point(3, 406);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(392, 52);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnWindowsHello
            // 
            this.btnWindowsHello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWindowsHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowsHello.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnWindowsHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnWindowsHello.Location = new System.Drawing.Point(3, 462);
            this.btnWindowsHello.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWindowsHello.Name = "btnWindowsHello";
            this.btnWindowsHello.Size = new System.Drawing.Size(392, 52);
            this.btnWindowsHello.TabIndex = 9;
            this.btnWindowsHello.Text = "تسجيل دخول باستخدام Windows Hello";
            this.btnWindowsHello.UseVisualStyleBackColor = true;
            this.btnWindowsHello.Click += new System.EventHandler(this.btnWindowsHello_Click);
            // 
            // rowFooter
            // 
            this.rowFooter.Controls.Add(this.linkCreateAccount);
            this.rowFooter.Controls.Add(this.lblNoAccount);
            this.rowFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.rowFooter.Location = new System.Drawing.Point(3, 526);
            this.rowFooter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.rowFooter.Name = "rowFooter";
            this.rowFooter.Size = new System.Drawing.Size(392, 46);
            this.rowFooter.TabIndex = 10;
            this.rowFooter.WrapContents = false;
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblNoAccount.Location = new System.Drawing.Point(141, 12);
            this.lblNoAccount.Margin = new System.Windows.Forms.Padding(0, 12, 8, 0);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoAccount.Size = new System.Drawing.Size(140, 23);
            this.lblNoAccount.TabIndex = 0;
            this.lblNoAccount.Text = "ليس لديك حساب؟";
            this.lblNoAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNoAccount.Click += new System.EventHandler(this.lblNoAccount_Click);
            // 
            // linkCreateAccount
            // 
            this.linkCreateAccount.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkCreateAccount.AutoSize = true;
            this.linkCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.linkCreateAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkCreateAccount.Location = new System.Drawing.Point(0, 12);
            this.linkCreateAccount.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Size = new System.Drawing.Size(133, 23);
            this.linkCreateAccount.TabIndex = 1;
            this.linkCreateAccount.TabStop = true;
            this.linkCreateAccount.Text = "إنشاء حساب جديد";
            this.linkCreateAccount.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateAccount_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 720);
            this.Controls.Add(this.layoutRoot);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.layoutRoot.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.layoutCard.ResumeLayout(false);
            this.layoutCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.rowOptions.ResumeLayout(false);
            this.rowOptions.PerformLayout();
            this.rowFooter.ResumeLayout(false);
            this.rowFooter.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

