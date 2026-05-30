using System.Drawing;
using System.Windows.Forms;

namespace Smart_BOQ.Views.AccountsAndSubscriptions
{
    partial class AccountManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel layoutRoot;
        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnLogout;
        private TabControl tabControl;
        private TabPage tabProfile;
        private TabPage tabSecurity;
        private TabPage tabSubscription;
        private TableLayoutPanel layoutProfile;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblCountry;
        private ComboBox cmbCountry;
        private Button btnSaveProfile;
        private Button btnChangeEmail;
        private Button btnChangePhone;
        private TableLayoutPanel layoutSecurity;
        private GroupBox grpPassword;
        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmNewPassword;
        private TextBox txtConfirmNewPassword;
        private CheckBox chkShowPassword;
        private Button btnChangePassword;
        private GroupBox grpTwoFactor;
        private Label lbl2FAStatus;
        private Button btnEnable2FA;
        private GroupBox grpDevices;
        private Label lblDevices;
        private ListView lstDevices;
        private GroupBox grpDanger;
        private Label lblDeleteAccount;
        private Button btnDeleteAccount;
        private TableLayoutPanel layoutSubscription;
        private Label lblCurrentPlan;
        private Label lblPlanName;
        private Label lblPlanExpiry;
        private Label lblPlanStatus;
        private Button btnViewPlans;
        private Button btnCancelSubscription;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.layoutProfile = new System.Windows.Forms.TableLayoutPanel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnChangePhone = new System.Windows.Forms.Button();
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.layoutSecurity = new System.Windows.Forms.TableLayoutPanel();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.grpTwoFactor = new System.Windows.Forms.GroupBox();
            this.lbl2FAStatus = new System.Windows.Forms.Label();
            this.btnEnable2FA = new System.Windows.Forms.Button();
            this.grpDevices = new System.Windows.Forms.GroupBox();
            this.lblDevices = new System.Windows.Forms.Label();
            this.lstDevices = new System.Windows.Forms.ListView();
            this.grpDanger = new System.Windows.Forms.GroupBox();
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.tabSubscription = new System.Windows.Forms.TabPage();
            this.layoutSubscription = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentPlan = new System.Windows.Forms.Label();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblPlanExpiry = new System.Windows.Forms.Label();
            this.lblPlanStatus = new System.Windows.Forms.Label();
            this.btnViewPlans = new System.Windows.Forms.Button();
            this.btnCancelSubscription = new System.Windows.Forms.Button();
            this.layoutRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.layoutProfile.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.layoutSecurity.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.grpTwoFactor.SuspendLayout();
            this.grpDevices.SuspendLayout();
            this.grpDanger.SuspendLayout();
            this.tabSubscription.SuspendLayout();
            this.layoutSubscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutRoot
            // 
            this.layoutRoot.ColumnCount = 1;
            this.layoutRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.layoutRoot.Controls.Add(this.tabControl, 0, 1);
            this.layoutRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRoot.Location = new System.Drawing.Point(0, 0);
            this.layoutRoot.Name = "layoutRoot";
            this.layoutRoot.RowCount = 2;
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.layoutRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutRoot.Size = new System.Drawing.Size(900, 700);
            this.layoutRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(894, 64);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إدارة الحساب";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(750, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 35);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "تسجيل الخروج";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Controls.Add(this.tabSecurity);
            this.tabControl.Controls.Add(this.tabSubscription);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(3, 73);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(894, 624);
            this.tabControl.TabIndex = 1;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.layoutProfile);
            this.tabProfile.Location = new System.Drawing.Point(4, 32);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(886, 588);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "الملف الشخصي";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // layoutProfile
            // 
            this.layoutProfile.ColumnCount = 2;
            this.layoutProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutProfile.Controls.Add(this.lblFullName, 0, 0);
            this.layoutProfile.Controls.Add(this.txtFullName, 0, 1);
            this.layoutProfile.Controls.Add(this.lblEmail, 1, 0);
            this.layoutProfile.Controls.Add(this.txtEmail, 1, 1);
            this.layoutProfile.Controls.Add(this.lblPhone, 0, 2);
            this.layoutProfile.Controls.Add(this.txtPhone, 0, 3);
            this.layoutProfile.Controls.Add(this.lblCountry, 1, 2);
            this.layoutProfile.Controls.Add(this.cmbCountry, 1, 3);
            this.layoutProfile.Controls.Add(this.btnSaveProfile, 0, 4);
            this.layoutProfile.Controls.Add(this.btnChangeEmail, 1, 4);
            this.layoutProfile.Controls.Add(this.btnChangePhone, 0, 5);
            this.layoutProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutProfile.Location = new System.Drawing.Point(3, 3);
            this.layoutProfile.Name = "layoutProfile";
            this.layoutProfile.Padding = new System.Windows.Forms.Padding(30);
            this.layoutProfile.RowCount = 6;
            this.layoutProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layoutProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layoutProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutProfile.Size = new System.Drawing.Size(880, 582);
            this.layoutProfile.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblFullName.Location = new System.Drawing.Point(409, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(82, 23);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "الاسم الكامل";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFullName.Location = new System.Drawing.Point(409, 68);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(402, 32);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblEmail.Location = new System.Drawing.Point(33, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(124, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "البريد الإلكتروني";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(33, 68);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(402, 32);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblPhone.Location = new System.Drawing.Point(409, 113);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 23);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "رقم الهاتف";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhone.Location = new System.Drawing.Point(409, 151);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(402, 32);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCountry.Location = new System.Drawing.Point(33, 113);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(54, 23);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "البلد";
            // 
            // cmbCountry
            // 
            this.cmbCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(33, 151);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(402, 33);
            this.cmbCountry.TabIndex = 7;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnSaveProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveProfile.FlatAppearance.BorderSize = 0;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(610, 199);
            this.btnSaveProfile.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(201, 44);
            this.btnSaveProfile.TabIndex = 8;
            this.btnSaveProfile.Text = "حفظ التغييرات";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnChangeEmail.Location = new System.Drawing.Point(234, 199);
            this.btnChangeEmail.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(201, 44);
            this.btnChangeEmail.TabIndex = 9;
            this.btnChangeEmail.Text = "تغيير البريد";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // btnChangePhone
            // 
            this.btnChangePhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnChangePhone.Location = new System.Drawing.Point(610, 249);
            this.btnChangePhone.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnChangePhone.Name = "btnChangePhone";
            this.btnChangePhone.Size = new System.Drawing.Size(201, 44);
            this.btnChangePhone.TabIndex = 10;
            this.btnChangePhone.Text = "تغيير رقم الهاتف";
            this.btnChangePhone.UseVisualStyleBackColor = true;
            this.btnChangePhone.Click += new System.EventHandler(this.btnChangePhone_Click);
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.layoutSecurity);
            this.tabSecurity.Location = new System.Drawing.Point(4, 32);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecurity.Size = new System.Drawing.Size(886, 588);
            this.tabSecurity.TabIndex = 1;
            this.tabSecurity.Text = "الأمان";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // layoutSecurity
            // 
            this.layoutSecurity.ColumnCount = 1;
            this.layoutSecurity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSecurity.Controls.Add(this.grpPassword, 0, 0);
            this.layoutSecurity.Controls.Add(this.grpTwoFactor, 0, 1);
            this.layoutSecurity.Controls.Add(this.grpDevices, 0, 2);
            this.layoutSecurity.Controls.Add(this.grpDanger, 0, 3);
            this.layoutSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSecurity.Location = new System.Drawing.Point(3, 3);
            this.layoutSecurity.Name = "layoutSecurity";
            this.layoutSecurity.Padding = new System.Windows.Forms.Padding(30);
            this.layoutSecurity.RowCount = 4;
            this.layoutSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.layoutSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layoutSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutSecurity.Size = new System.Drawing.Size(880, 582);
            this.layoutSecurity.TabIndex = 0;
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.lblCurrentPassword);
            this.grpPassword.Controls.Add(this.txtCurrentPassword);
            this.grpPassword.Controls.Add(this.lblNewPassword);
            this.grpPassword.Controls.Add(this.txtNewPassword);
            this.grpPassword.Controls.Add(this.lblConfirmNewPassword);
            this.grpPassword.Controls.Add(this.txtConfirmNewPassword);
            this.grpPassword.Controls.Add(this.chkShowPassword);
            this.grpPassword.Controls.Add(this.btnChangePassword);
            this.grpPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grpPassword.Location = new System.Drawing.Point(33, 33);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(814, 224);
            this.grpPassword.TabIndex = 0;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "تغيير كلمة المرور";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(580, 35);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(111, 21);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "كلمة المرور الحالية";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCurrentPassword.Location = new System.Drawing.Point(350, 60);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(400, 31);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNewPassword.Location = new System.Drawing.Point(610, 95);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 21);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "كلمة المرور الجديدة";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNewPassword.Location = new System.Drawing.Point(350, 120);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(400, 31);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(550, 155);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(141, 21);
            this.lblConfirmNewPassword.TabIndex = 4;
            this.lblConfirmNewPassword.Text = "تأكيد كلمة المرور الجديدة";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(350, 180);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(400, 31);
            this.txtConfirmNewPassword.TabIndex = 5;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            this.txtConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.Location = new System.Drawing.Point(170, 60);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(140, 24);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "إظهار كلمات المرور";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(30, 170);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(130, 40);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "تغيير كلمة المرور";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // grpTwoFactor
            // 
            this.grpTwoFactor.Controls.Add(this.lbl2FAStatus);
            this.grpTwoFactor.Controls.Add(this.btnEnable2FA);
            this.grpTwoFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTwoFactor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTwoFactor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grpTwoFactor.Location = new System.Drawing.Point(33, 263);
            this.grpTwoFactor.Name = "grpTwoFactor";
            this.grpTwoFactor.Size = new System.Drawing.Size(814, 114);
            this.grpTwoFactor.TabIndex = 1;
            this.grpTwoFactor.TabStop = false;
            this.grpTwoFactor.Text = "التحقق بخطوتين (2FA)";
            // 
            // lbl2FAStatus
            // 
            this.lbl2FAStatus.AutoSize = true;
            this.lbl2FAStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl2FAStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lbl2FAStatus.Location = new System.Drawing.Point(600, 45);
            this.lbl2FAStatus.Name = "lbl2FAStatus";
            this.lbl2FAStatus.Size = new System.Drawing.Size(150, 23);
            this.lbl2FAStatus.TabIndex = 0;
            this.lbl2FAStatus.Text = "الحالة: غير مفعّل";
            // 
            // btnEnable2FA
            // 
            this.btnEnable2FA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnEnable2FA.FlatAppearance.BorderSize = 0;
            this.btnEnable2FA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable2FA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnable2FA.ForeColor = System.Drawing.Color.White;
            this.btnEnable2FA.Location = new System.Drawing.Point(30, 40);
            this.btnEnable2FA.Name = "btnEnable2FA";
            this.btnEnable2FA.Size = new System.Drawing.Size(180, 40);
            this.btnEnable2FA.TabIndex = 1;
            this.btnEnable2FA.Text = "تفعيل التحقق بخطوتين";
            this.btnEnable2FA.UseVisualStyleBackColor = false;
            this.btnEnable2FA.Click += new System.EventHandler(this.btnEnable2FA_Click);
            // 
            // grpDevices
            // 
            this.grpDevices.Controls.Add(this.lblDevices);
            this.grpDevices.Controls.Add(this.lstDevices);
            this.grpDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDevices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grpDevices.Location = new System.Drawing.Point(33, 383);
            this.grpDevices.Name = "grpDevices";
            this.grpDevices.Size = new System.Drawing.Size(814, 144);
            this.grpDevices.TabIndex = 2;
            this.grpDevices.TabStop = false;
            this.grpDevices.Text = "الأجهزة المسجلة";
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblDevices.Location = new System.Drawing.Point(30, 25);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(350, 20);
            this.lblDevices.TabIndex = 0;
            this.lblDevices.Text = "قائمة الأجهزة التي تستخدمها لتسجيل الدخول إلى حسابك";
            // 
            // lstDevices
            // 
            this.lstDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDevices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstDevices.Location = new System.Drawing.Point(30, 50);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(754, 80);
            this.lstDevices.TabIndex = 1;
            this.lstDevices.UseCompatibleStateImageBehavior = false;
            this.lstDevices.View = System.Windows.Forms.View.Details;
            // 
            // grpDanger
            // 
            this.grpDanger.Controls.Add(this.lblDeleteAccount);
            this.grpDanger.Controls.Add(this.btnDeleteAccount);
            this.grpDanger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpDanger.Location = new System.Drawing.Point(33, 533);
            this.grpDanger.Name = "grpDanger";
            this.grpDanger.Size = new System.Drawing.Size(814, 114);
            this.grpDanger.TabIndex = 3;
            this.grpDanger.TabStop = false;
            this.grpDanger.Text = "منطقة الخطر";
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblDeleteAccount.Location = new System.Drawing.Point(450, 45);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(300, 20);
            this.lblDeleteAccount.TabIndex = 0;
            this.lblDeleteAccount.Text = "حذف حسابك سيؤدي إلى فقدان جميع البيانات نهائياً";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(30, 40);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "حذف الحساب";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // tabSubscription
            // 
            this.tabSubscription.Controls.Add(this.layoutSubscription);
            this.tabSubscription.Location = new System.Drawing.Point(4, 32);
            this.tabSubscription.Name = "tabSubscription";
            this.tabSubscription.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubscription.Size = new System.Drawing.Size(886, 588);
            this.tabSubscription.TabIndex = 2;
            this.tabSubscription.Text = "الاشتراك";
            this.tabSubscription.UseVisualStyleBackColor = true;
            // 
            // layoutSubscription
            // 
            this.layoutSubscription.ColumnCount = 1;
            this.layoutSubscription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSubscription.Controls.Add(this.lblCurrentPlan, 0, 0);
            this.layoutSubscription.Controls.Add(this.lblPlanName, 0, 1);
            this.layoutSubscription.Controls.Add(this.lblPlanExpiry, 0, 2);
            this.layoutSubscription.Controls.Add(this.lblPlanStatus, 0, 3);
            this.layoutSubscription.Controls.Add(this.btnViewPlans, 0, 4);
            this.layoutSubscription.Controls.Add(this.btnCancelSubscription, 0, 5);
            this.layoutSubscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSubscription.Location = new System.Drawing.Point(3, 3);
            this.layoutSubscription.Name = "layoutSubscription";
            this.layoutSubscription.Padding = new System.Windows.Forms.Padding(30);
            this.layoutSubscription.RowCount = 6;
            this.layoutSubscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutSubscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutSubscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutSubscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutSubscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutSubscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutSubscription.Size = new System.Drawing.Size(880, 582);
            this.layoutSubscription.TabIndex = 0;
            // 
            // lblCurrentPlan
            // 
            this.lblCurrentPlan.AutoSize = true;
            this.lblCurrentPlan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCurrentPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblCurrentPlan.Location = new System.Drawing.Point(33, 30);
            this.lblCurrentPlan.Name = "lblCurrentPlan";
            this.lblCurrentPlan.Size = new System.Drawing.Size(120, 25);
            this.lblCurrentPlan.TabIndex = 0;
            this.lblCurrentPlan.Text = "خطتك الحالية";
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPlanName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.lblPlanName.Location = new System.Drawing.Point(33, 70);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(150, 41);
            this.lblPlanName.TabIndex = 1;
            this.lblPlanName.Text = "الخطة المجانية";
            // 
            // lblPlanExpiry
            // 
            this.lblPlanExpiry.AutoSize = true;
            this.lblPlanExpiry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPlanExpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblPlanExpiry.Location = new System.Drawing.Point(33, 120);
            this.lblPlanExpiry.Name = "lblPlanExpiry";
            this.lblPlanExpiry.Size = new System.Drawing.Size(250, 23);
            this.lblPlanExpiry.TabIndex = 2;
            this.lblPlanExpiry.Text = "تاريخ انتهاء الاشتراك: لا ينتهي";
            // 
            // lblPlanStatus
            // 
            this.lblPlanStatus.AutoSize = true;
            this.lblPlanStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPlanStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.lblPlanStatus.Location = new System.Drawing.Point(33, 160);
            this.lblPlanStatus.Name = "lblPlanStatus";
            this.lblPlanStatus.Size = new System.Drawing.Size(70, 23);
            this.lblPlanStatus.TabIndex = 3;
            this.lblPlanStatus.Text = "الحالة: نشط";
            // 
            // btnViewPlans
            // 
            this.btnViewPlans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnViewPlans.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewPlans.FlatAppearance.BorderSize = 0;
            this.btnViewPlans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPlans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewPlans.ForeColor = System.Drawing.Color.White;
            this.btnViewPlans.Location = new System.Drawing.Point(33, 203);
            this.btnViewPlans.Name = "btnViewPlans";
            this.btnViewPlans.Size = new System.Drawing.Size(200, 44);
            this.btnViewPlans.TabIndex = 4;
            this.btnViewPlans.Text = "عرض خطط الترقية";
            this.btnViewPlans.UseVisualStyleBackColor = false;
            this.btnViewPlans.Click += new System.EventHandler(this.btnViewPlans_Click);
            // 
            // btnCancelSubscription
            // 
            this.btnCancelSubscription.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSubscription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelSubscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelSubscription.Location = new System.Drawing.Point(33, 253);
            this.btnCancelSubscription.Name = "btnCancelSubscription";
            this.btnCancelSubscription.Size = new System.Drawing.Size(200, 44);
            this.btnCancelSubscription.TabIndex = 5;
            this.btnCancelSubscription.Text = "إلغاء الاشتراك";
            this.btnCancelSubscription.UseVisualStyleBackColor = true;
            this.btnCancelSubscription.Click += new System.EventHandler(this.btnCancelSubscription_Click);
            // 
            // AccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.layoutRoot);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AccountManagementForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الحساب";
            this.layoutRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.layoutProfile.ResumeLayout(false);
            this.layoutProfile.PerformLayout();
            this.tabSecurity.ResumeLayout(false);
            this.layoutSecurity.ResumeLayout(false);
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.grpTwoFactor.ResumeLayout(false);
            this.grpTwoFactor.PerformLayout();
            this.grpDevices.ResumeLayout(false);
            this.grpDevices.PerformLayout();
            this.grpDanger.ResumeLayout(false);
            this.grpDanger.PerformLayout();
            this.tabSubscription.ResumeLayout(false);
            this.layoutSubscription.ResumeLayout(false);
            this.layoutSubscription.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
