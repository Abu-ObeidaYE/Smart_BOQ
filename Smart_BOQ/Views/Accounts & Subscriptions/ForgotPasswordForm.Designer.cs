using System.Drawing;
using System.Windows.Forms;

namespace Smart_BOQ.Views.AccountsAndSubscriptions
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutRoot;
        private Panel panelCard;
        private TableLayoutPanel layoutCard;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblEmailOrPhone;
        private TextBox txtEmailOrPhone;
        private Label lblCode;
        private TextBox txtCode;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkShowPassword;
        private Button btnSendResetCode;
        private Button btnVerifyCode;
        private Button btnResetPassword;
        private Button btnBack;
        private FlowLayoutPanel rowFooter;
        private LinkLabel linkLogin;
        private Label lblBackToLogin;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblEmailOrPhone = new System.Windows.Forms.Label();
            this.txtEmailOrPhone = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnSendResetCode = new System.Windows.Forms.Button();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rowFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.lblBackToLogin = new System.Windows.Forms.Label();
            this.layoutRoot.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.layoutCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.layoutRoot.Size = new System.Drawing.Size(540, 780);
            this.layoutRoot.TabIndex = 0;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.layoutCard);
            this.panelCard.Location = new System.Drawing.Point(35, 40);
            this.panelCard.Margin = new System.Windows.Forms.Padding(0);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(30);
            this.panelCard.Size = new System.Drawing.Size(470, 700);
            this.panelCard.TabIndex = 0;
            // 
            // layoutCard
            // 
            this.layoutCard.ColumnCount = 1;
            this.layoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCard.Controls.Add(this.picLogo, 0, 0);
            this.layoutCard.Controls.Add(this.lblTitle, 0, 1);
            this.layoutCard.Controls.Add(this.lblSubtitle, 0, 2);
            this.layoutCard.Controls.Add(this.lblEmailOrPhone, 0, 4);
            this.layoutCard.Controls.Add(this.txtEmailOrPhone, 0, 5);
            this.layoutCard.Controls.Add(this.lblCode, 0, 6);
            this.layoutCard.Controls.Add(this.txtCode, 0, 7);
            this.layoutCard.Controls.Add(this.lblNewPassword, 0, 8);
            this.layoutCard.Controls.Add(this.txtNewPassword, 0, 9);
            this.layoutCard.Controls.Add(this.lblConfirmPassword, 0, 10);
            this.layoutCard.Controls.Add(this.txtConfirmPassword, 0, 11);
            this.layoutCard.Controls.Add(this.chkShowPassword, 0, 12);
            this.layoutCard.Controls.Add(this.btnSendResetCode, 0, 14);
            this.layoutCard.Controls.Add(this.btnVerifyCode, 0, 14);
            this.layoutCard.Controls.Add(this.btnResetPassword, 0, 14);
            this.layoutCard.Controls.Add(this.btnBack, 0, 15);
            this.layoutCard.Controls.Add(this.rowFooter, 0, 17);
            this.layoutCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCard.Location = new System.Drawing.Point(30, 30);
            this.layoutCard.Name = "layoutCard";
            this.layoutCard.RowCount = 19;
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCard.Size = new System.Drawing.Size(408, 638);
            this.layoutCard.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(402, 104);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 110);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(402, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "إعادة تعيين كلمة المرور";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(3, 155);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(402, 55);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "أدخل بريدك الإلكتروني أو رقم هاتفك وسنرسل لك رمز إعادة التعيين";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailOrPhone
            // 
            this.lblEmailOrPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmailOrPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailOrPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblEmailOrPhone.Location = new System.Drawing.Point(3, 226);
            this.lblEmailOrPhone.Name = "lblEmailOrPhone";
            this.lblEmailOrPhone.Size = new System.Drawing.Size(402, 26);
            this.lblEmailOrPhone.TabIndex = 3;
            this.lblEmailOrPhone.Text = "البريد الإلكتروني أو رقم الهاتف";
            this.lblEmailOrPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmailOrPhone
            // 
            this.txtEmailOrPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailOrPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailOrPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmailOrPhone.Location = new System.Drawing.Point(3, 252);
            this.txtEmailOrPhone.Name = "txtEmailOrPhone";
            this.txtEmailOrPhone.Size = new System.Drawing.Size(402, 32);
            this.txtEmailOrPhone.TabIndex = 4;
            this.txtEmailOrPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCode
            // 
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCode.Location = new System.Drawing.Point(3, 298);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(402, 26);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "رمز إعادة التعيين";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCode.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCode.Location = new System.Drawing.Point(3, 324);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(402, 32);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCode.Visible = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblNewPassword.Location = new System.Drawing.Point(3, 370);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(402, 26);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "كلمة المرور الجديدة";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNewPassword.Visible = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPassword.Location = new System.Drawing.Point(3, 396);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(402, 32);
            this.txtNewPassword.TabIndex = 8;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNewPassword.Visible = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(3, 442);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(402, 26);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "تأكيد كلمة المرور الجديدة";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConfirmPassword.Visible = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(3, 468);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(402, 32);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConfirmPassword.Visible = false;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.chkShowPassword.Location = new System.Drawing.Point(283, 514);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(122, 30);
            this.chkShowPassword.TabIndex = 11;
            this.chkShowPassword.Text = "إظهار كلمة المرور";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.Visible = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnSendResetCode
            // 
            this.btnSendResetCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnSendResetCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendResetCode.FlatAppearance.BorderSize = 0;
            this.btnSendResetCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendResetCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSendResetCode.ForeColor = System.Drawing.Color.White;
            this.btnSendResetCode.Location = new System.Drawing.Point(3, 560);
            this.btnSendResetCode.Name = "btnSendResetCode";
            this.btnSendResetCode.Size = new System.Drawing.Size(402, 49);
            this.btnSendResetCode.TabIndex = 12;
            this.btnSendResetCode.Text = "إرسال رمز إعادة التعيين";
            this.btnSendResetCode.UseVisualStyleBackColor = false;
            this.btnSendResetCode.Click += new System.EventHandler(this.btnSendResetCode_Click);
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnVerifyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerifyCode.FlatAppearance.BorderSize = 0;
            this.btnVerifyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVerifyCode.ForeColor = System.Drawing.Color.White;
            this.btnVerifyCode.Location = new System.Drawing.Point(3, 560);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(402, 49);
            this.btnVerifyCode.TabIndex = 13;
            this.btnVerifyCode.Text = "التحقق من الرمز";
            this.btnVerifyCode.UseVisualStyleBackColor = false;
            this.btnVerifyCode.Visible = false;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnResetPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(3, 560);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(402, 49);
            this.btnResetPassword.TabIndex = 14;
            this.btnResetPassword.Text = "إعادة تعيين كلمة المرور";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Visible = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnBack.Location = new System.Drawing.Point(3, 615);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(402, 44);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            // 
            // rowFooter
            // 
            this.rowFooter.Controls.Add(this.linkLogin);
            this.rowFooter.Controls.Add(this.lblBackToLogin);
            this.rowFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.rowFooter.Location = new System.Drawing.Point(3, 675);
            this.rowFooter.Name = "rowFooter";
            this.rowFooter.Size = new System.Drawing.Size(402, 46);
            this.rowFooter.TabIndex = 16;
            this.rowFooter.WrapContents = false;
            // 
            // lblBackToLogin
            // 
            this.lblBackToLogin.AutoSize = true;
            this.lblBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBackToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblBackToLogin.Location = new System.Drawing.Point(196, 12);
            this.lblBackToLogin.Margin = new System.Windows.Forms.Padding(0, 12, 8, 0);
            this.lblBackToLogin.Name = "lblBackToLogin";
            this.lblBackToLogin.Size = new System.Drawing.Size(79, 23);
            this.lblBackToLogin.TabIndex = 0;
            this.lblBackToLogin.Text = "تذكرتها؟";
            this.lblBackToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLogin
            // 
            this.linkLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.linkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkLogin.Location = new System.Drawing.Point(0, 12);
            this.linkLogin.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(109, 23);
            this.linkLogin.TabIndex = 1;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "تسجيل الدخول";
            this.linkLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 780);
            this.Controls.Add(this.layoutRoot);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ForgotPasswordForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعادة تعيين كلمة المرور";
            this.layoutRoot.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.layoutCard.ResumeLayout(false);
            this.layoutCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.rowFooter.ResumeLayout(false);
            this.rowFooter.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
