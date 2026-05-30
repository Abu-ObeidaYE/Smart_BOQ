using System.Drawing;
using System.Windows.Forms;

namespace Smart_BOQ.Views.AccountsAndSubscriptions
{
    partial class TwoFactorForm
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutRoot;
        private Panel panelCard;
        private TableLayoutPanel layoutCard;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblEmail;
        private TextBox txtCode1;
        private TextBox txtCode2;
        private TextBox txtCode3;
        private TextBox txtCode4;
        private TextBox txtCode5;
        private TextBox txtCode6;
        private FlowLayoutPanel pnlCode;
        private Button btnVerify;
        private LinkLabel linkResend;
        private Label lblResend;
        private LinkLabel linkBack;
        private Label lblBack;
        private FlowLayoutPanel rowResend;
        private FlowLayoutPanel rowBack;

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
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlCode = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCode1 = new System.Windows.Forms.TextBox();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.txtCode3 = new System.Windows.Forms.TextBox();
            this.txtCode4 = new System.Windows.Forms.TextBox();
            this.txtCode5 = new System.Windows.Forms.TextBox();
            this.txtCode6 = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.rowResend = new System.Windows.Forms.FlowLayoutPanel();
            this.linkResend = new System.Windows.Forms.LinkLabel();
            this.lblResend = new System.Windows.Forms.Label();
            this.rowBack = new System.Windows.Forms.FlowLayoutPanel();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.lblBack = new System.Windows.Forms.Label();
            this.layoutRoot.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.layoutCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlCode.SuspendLayout();
            this.rowResend.SuspendLayout();
            this.rowBack.SuspendLayout();
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
            this.layoutRoot.Size = new System.Drawing.Size(540, 700);
            this.layoutRoot.TabIndex = 0;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.layoutCard);
            this.panelCard.Location = new System.Drawing.Point(40, 45);
            this.panelCard.Margin = new System.Windows.Forms.Padding(0);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(30);
            this.panelCard.Size = new System.Drawing.Size(460, 610);
            this.panelCard.TabIndex = 0;
            // 
            // layoutCard
            // 
            this.layoutCard.ColumnCount = 1;
            this.layoutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCard.Controls.Add(this.picLogo, 0, 0);
            this.layoutCard.Controls.Add(this.lblTitle, 0, 1);
            this.layoutCard.Controls.Add(this.lblSubtitle, 0, 2);
            this.layoutCard.Controls.Add(this.lblEmail, 0, 3);
            this.layoutCard.Controls.Add(this.pnlCode, 0, 4);
            this.layoutCard.Controls.Add(this.btnVerify, 0, 6);
            this.layoutCard.Controls.Add(this.rowResend, 0, 8);
            this.layoutCard.Controls.Add(this.rowBack, 0, 10);
            this.layoutCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCard.Location = new System.Drawing.Point(30, 30);
            this.layoutCard.Name = "layoutCard";
            this.layoutCard.RowCount = 12;
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCard.Size = new System.Drawing.Size(398, 548);
            this.layoutCard.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(392, 94);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "التحقق بخطوتين";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitle.Location = new System.Drawing.Point(3, 148);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(392, 30);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "أدخل الرمز المرسل إلى";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblEmail.Location = new System.Drawing.Point(3, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(392, 30);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "user@example.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCode
            // 
            this.pnlCode.Controls.Add(this.txtCode1);
            this.pnlCode.Controls.Add(this.txtCode2);
            this.pnlCode.Controls.Add(this.txtCode3);
            this.pnlCode.Controls.Add(this.txtCode4);
            this.pnlCode.Controls.Add(this.txtCode5);
            this.pnlCode.Controls.Add(this.txtCode6);
            this.pnlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCode.Location = new System.Drawing.Point(3, 208);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(392, 64);
            this.pnlCode.TabIndex = 4;
            this.pnlCode.WrapContents = false;
            // 
            // txtCode1
            // 
            this.txtCode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtCode1.Location = new System.Drawing.Point(309, 12);
            this.txtCode1.Margin = new System.Windows.Forms.Padding(12, 12, 6, 12);
            this.txtCode1.MaxLength = 1;
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.Size = new System.Drawing.Size(50, 47);
            this.txtCode1.TabIndex = 0;
            this.txtCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCode2
            // 
            this.txtCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtCode2.Location = new System.Drawing.Point(249, 12);
            this.txtCode2.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtCode2.MaxLength = 1;
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(50, 47);
            this.txtCode2.TabIndex = 1;
            this.txtCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCode3
            // 
            this.txtCode3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtCode3.Location = new System.Drawing.Point(189, 12);
            this.txtCode3.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtCode3.MaxLength = 1;
            this.txtCode3.Name = "txtCode3";
            this.txtCode3.Size = new System.Drawing.Size(50, 47);
            this.txtCode3.TabIndex = 2;
            this.txtCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCode4
            // 
            this.txtCode4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtCode4.Location = new System.Drawing.Point(129, 12);
            this.txtCode4.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtCode4.MaxLength = 1;
            this.txtCode4.Name = "txtCode4";
            this.txtCode4.Size = new System.Drawing.Size(50, 47);
            this.txtCode4.TabIndex = 3;
            this.txtCode4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCode5
            // 
            this.txtCode5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtCode5.Location = new System.Drawing.Point(69, 12);
            this.txtCode5.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtCode5.MaxLength = 1;
            this.txtCode5.Name = "txtCode5";
            this.txtCode5.Size = new System.Drawing.Size(50, 47);
            this.txtCode5.TabIndex = 4;
            this.txtCode5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCode6
            // 
            this.txtCode6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtCode6.Location = new System.Drawing.Point(9, 12);
            this.txtCode6.Margin = new System.Windows.Forms.Padding(6, 12, 12, 12);
            this.txtCode6.MaxLength = 1;
            this.txtCode6.Name = "txtCode6";
            this.txtCode6.Size = new System.Drawing.Size(50, 47);
            this.txtCode6.TabIndex = 5;
            this.txtCode6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnVerify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(3, 298);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(392, 49);
            this.btnVerify.TabIndex = 5;
            this.btnVerify.Text = "التحقق";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // rowResend
            // 
            this.rowResend.Controls.Add(this.linkResend);
            this.rowResend.Controls.Add(this.lblResend);
            this.rowResend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowResend.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.rowResend.Location = new System.Drawing.Point(3, 373);
            this.rowResend.Name = "rowResend";
            this.rowResend.Size = new System.Drawing.Size(392, 34);
            this.rowResend.TabIndex = 6;
            this.rowResend.WrapContents = false;
            // 
            // lblResend
            // 
            this.lblResend.AutoSize = true;
            this.lblResend.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblResend.Location = new System.Drawing.Point(221, 5);
            this.lblResend.Margin = new System.Windows.Forms.Padding(0, 5, 8, 0);
            this.lblResend.Name = "lblResend";
            this.lblResend.Size = new System.Drawing.Size(127, 23);
            this.lblResend.TabIndex = 0;
            this.lblResend.Text = "لم تتسلم الرمز؟";
            this.lblResend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkResend
            // 
            this.linkResend.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkResend.AutoSize = true;
            this.linkResend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.linkResend.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkResend.Location = new System.Drawing.Point(0, 5);
            this.linkResend.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.linkResend.Name = "linkResend";
            this.linkResend.Size = new System.Drawing.Size(142, 23);
            this.linkResend.TabIndex = 1;
            this.linkResend.TabStop = true;
            this.linkResend.Text = "إعادة الإرسال";
            this.linkResend.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkResend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkResend_LinkClicked);
            // 
            // rowBack
            // 
            this.rowBack.Controls.Add(this.linkBack);
            this.rowBack.Controls.Add(this.lblBack);
            this.rowBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowBack.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.rowBack.Location = new System.Drawing.Point(3, 423);
            this.rowBack.Name = "rowBack";
            this.rowBack.Size = new System.Drawing.Size(392, 34);
            this.rowBack.TabIndex = 7;
            this.rowBack.WrapContents = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblBack.Location = new System.Drawing.Point(185, 5);
            this.lblBack.Margin = new System.Windows.Forms.Padding(0, 5, 8, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(163, 23);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "تسجيل الدخول بطريقة أخرى؟";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkBack
            // 
            this.linkBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.linkBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkBack.Location = new System.Drawing.Point(0, 5);
            this.linkBack.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(52, 23);
            this.linkBack.TabIndex = 1;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "رجوع";
            this.linkBack.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // TwoFactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 700);
            this.Controls.Add(this.layoutRoot);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TwoFactorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التحقق بخطوتين";
            this.layoutRoot.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.layoutCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlCode.ResumeLayout(false);
            this.pnlCode.PerformLayout();
            this.rowResend.ResumeLayout(false);
            this.rowResend.PerformLayout();
            this.rowBack.ResumeLayout(false);
            this.rowBack.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
