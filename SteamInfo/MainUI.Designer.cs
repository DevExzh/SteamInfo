namespace SteamInfo
{
    partial class MainUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.SteamIDInput = new System.Windows.Forms.TextBox();
            this.Info_Submit = new System.Windows.Forms.Button();
            this.Text_Clear = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.ForMoreInfo = new System.Windows.Forms.Button();
            this.Online_txt = new System.Windows.Forms.Label();
            this.Privacy = new System.Windows.Forms.Label();
            this.Realname = new System.Windows.Forms.Label();
            this.RegisterDate = new System.Windows.Forms.Label();
            this.Url_Numeric = new System.Windows.Forms.TextBox();
            this.Url_Custom = new System.Windows.Forms.TextBox();
            this.Steam3GID = new System.Windows.Forms.TextBox();
            this.SteamID32 = new System.Windows.Forms.TextBox();
            this.SteamID64 = new System.Windows.Forms.TextBox();
            this.LimitedAccount = new System.Windows.Forms.Label();
            this.Trade_Banned = new System.Windows.Forms.Label();
            this.Games_Banned = new System.Windows.Forms.Label();
            this.VAC_BannedTimes = new System.Windows.Forms.Label();
            this.VAC_Cheats = new System.Windows.Forms.Label();
            this.Copy_SteamNickname = new System.Windows.Forms.Button();
            this.Copy_Numeric_URL = new System.Windows.Forms.Button();
            this.Copy_Custom_URL = new System.Windows.Forms.Button();
            this.Evaluation = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Add_SteamFriend = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_SteamNickname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoSearchMode = new System.Windows.Forms.Panel();
            this.Mode_ID = new System.Windows.Forms.RadioButton();
            this.Mode_Name = new System.Windows.Forms.RadioButton();
            this.CommunityBanned = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DaysSinceLastBan = new System.Windows.Forms.Label();
            this.About_Start = new System.Windows.Forms.Button();
            this.Online_state = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.advTabControl1 = new SteamInfo.Controls.AdvTabControl();
            this.SteamInfo = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.InfoPanel.SuspendLayout();
            this.InfoSearchMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Online_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.advTabControl1.SuspendLayout();
            this.SteamInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // SteamIDInput
            // 
            this.SteamIDInput.Font = new System.Drawing.Font("方正黑体简体", 14F);
            this.SteamIDInput.Location = new System.Drawing.Point(137, 15);
            this.SteamIDInput.Name = "SteamIDInput";
            this.SteamIDInput.Size = new System.Drawing.Size(548, 28);
            this.SteamIDInput.TabIndex = 1;
            // 
            // Info_Submit
            // 
            this.Info_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Info_Submit.FlatAppearance.BorderSize = 0;
            this.Info_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info_Submit.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.Info_Submit.ForeColor = System.Drawing.SystemColors.Control;
            this.Info_Submit.Location = new System.Drawing.Point(691, 15);
            this.Info_Submit.Name = "Info_Submit";
            this.Info_Submit.Size = new System.Drawing.Size(54, 28);
            this.Info_Submit.TabIndex = 2;
            this.Info_Submit.Text = "查询";
            this.Info_Submit.UseVisualStyleBackColor = false;
            this.Info_Submit.Click += new System.EventHandler(this.Info_Submit_Click);
            // 
            // Text_Clear
            // 
            this.Text_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text_Clear.FlatAppearance.BorderSize = 0;
            this.Text_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text_Clear.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.Text_Clear.ForeColor = System.Drawing.SystemColors.Control;
            this.Text_Clear.Location = new System.Drawing.Point(749, 15);
            this.Text_Clear.Name = "Text_Clear";
            this.Text_Clear.Size = new System.Drawing.Size(54, 28);
            this.Text_Clear.TabIndex = 3;
            this.Text_Clear.Text = "清除";
            this.Text_Clear.UseVisualStyleBackColor = false;
            this.Text_Clear.Click += new System.EventHandler(this.Text_Clear_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Controls.Add(this.About_Start);
            this.InfoPanel.Controls.Add(this.DaysSinceLastBan);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.CommunityBanned);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.Copy_Numeric_URL);
            this.InfoPanel.Controls.Add(this.ForMoreInfo);
            this.InfoPanel.Controls.Add(this.Online_txt);
            this.InfoPanel.Controls.Add(this.Online_state);
            this.InfoPanel.Controls.Add(this.Privacy);
            this.InfoPanel.Controls.Add(this.Realname);
            this.InfoPanel.Controls.Add(this.RegisterDate);
            this.InfoPanel.Controls.Add(this.Url_Numeric);
            this.InfoPanel.Controls.Add(this.Url_Custom);
            this.InfoPanel.Controls.Add(this.Steam3GID);
            this.InfoPanel.Controls.Add(this.SteamID32);
            this.InfoPanel.Controls.Add(this.SteamID64);
            this.InfoPanel.Controls.Add(this.LimitedAccount);
            this.InfoPanel.Controls.Add(this.Trade_Banned);
            this.InfoPanel.Controls.Add(this.Games_Banned);
            this.InfoPanel.Controls.Add(this.VAC_BannedTimes);
            this.InfoPanel.Controls.Add(this.VAC_Cheats);
            this.InfoPanel.Controls.Add(this.Copy_SteamNickname);
            this.InfoPanel.Controls.Add(this.Copy_Custom_URL);
            this.InfoPanel.Controls.Add(this.Evaluation);
            this.InfoPanel.Controls.Add(this.label19);
            this.InfoPanel.Controls.Add(this.label18);
            this.InfoPanel.Controls.Add(this.label17);
            this.InfoPanel.Controls.Add(this.label16);
            this.InfoPanel.Controls.Add(this.label15);
            this.InfoPanel.Controls.Add(this.label14);
            this.InfoPanel.Controls.Add(this.label13);
            this.InfoPanel.Controls.Add(this.label12);
            this.InfoPanel.Controls.Add(this.label11);
            this.InfoPanel.Controls.Add(this.label10);
            this.InfoPanel.Controls.Add(this.Add_SteamFriend);
            this.InfoPanel.Controls.Add(this.label9);
            this.InfoPanel.Controls.Add(this.label8);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.Label_SteamNickname);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(3, 61);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(815, 385);
            this.InfoPanel.TabIndex = 4;
            this.InfoPanel.Visible = false;
            // 
            // ForMoreInfo
            // 
            this.ForMoreInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ForMoreInfo.FlatAppearance.BorderSize = 0;
            this.ForMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForMoreInfo.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.ForMoreInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.ForMoreInfo.Location = new System.Drawing.Point(590, 343);
            this.ForMoreInfo.Name = "ForMoreInfo";
            this.ForMoreInfo.Size = new System.Drawing.Size(73, 28);
            this.ForMoreInfo.TabIndex = 39;
            this.ForMoreInfo.Text = "更多...";
            this.ForMoreInfo.UseVisualStyleBackColor = false;
            this.ForMoreInfo.Click += new System.EventHandler(this.ForMoreInfo_Click);
            // 
            // Online_txt
            // 
            this.Online_txt.AutoSize = true;
            this.Online_txt.Font = new System.Drawing.Font("方正黑体简体", 14F);
            this.Online_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.Online_txt.Location = new System.Drawing.Point(630, 19);
            this.Online_txt.Name = "Online_txt";
            this.Online_txt.Size = new System.Drawing.Size(48, 21);
            this.Online_txt.TabIndex = 38;
            this.Online_txt.Text = "在线";
            // 
            // Privacy
            // 
            this.Privacy.AutoSize = true;
            this.Privacy.Font = new System.Drawing.Font("方正黑体简体", 9.5F);
            this.Privacy.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Privacy.Location = new System.Drawing.Point(465, 93);
            this.Privacy.Name = "Privacy";
            this.Privacy.Size = new System.Drawing.Size(33, 15);
            this.Privacy.TabIndex = 36;
            this.Privacy.Text = "公开";
            // 
            // Realname
            // 
            this.Realname.AutoSize = true;
            this.Realname.Font = new System.Drawing.Font("方正黑体简体", 9.5F);
            this.Realname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Realname.Location = new System.Drawing.Point(465, 71);
            this.Realname.Name = "Realname";
            this.Realname.Size = new System.Drawing.Size(53, 15);
            this.Realname.TabIndex = 35;
            this.Realname.Text = "Unkown";
            // 
            // RegisterDate
            // 
            this.RegisterDate.AutoSize = true;
            this.RegisterDate.Font = new System.Drawing.Font("方正黑体简体", 9.5F);
            this.RegisterDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RegisterDate.Location = new System.Drawing.Point(488, 50);
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.Size = new System.Drawing.Size(111, 15);
            this.RegisterDate.TabIndex = 34;
            this.RegisterDate.Text = "January 31 , 2000";
            // 
            // Url_Numeric
            // 
            this.Url_Numeric.BackColor = System.Drawing.Color.White;
            this.Url_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Url_Numeric.Font = new System.Drawing.Font("方正黑体简体", 9.5F);
            this.Url_Numeric.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Url_Numeric.HideSelection = false;
            this.Url_Numeric.Location = new System.Drawing.Point(409, 264);
            this.Url_Numeric.Multiline = true;
            this.Url_Numeric.Name = "Url_Numeric";
            this.Url_Numeric.ReadOnly = true;
            this.Url_Numeric.Size = new System.Drawing.Size(393, 42);
            this.Url_Numeric.TabIndex = 33;
            this.Url_Numeric.Text = "Steam Account Profile Numeric URL\r\n(exg: https://steamcommunity.com/profiles/7656" +
    "1198305549160)";
            // 
            // Url_Custom
            // 
            this.Url_Custom.BackColor = System.Drawing.Color.White;
            this.Url_Custom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Url_Custom.Font = new System.Drawing.Font("方正黑体简体", 9.5F);
            this.Url_Custom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Url_Custom.HideSelection = false;
            this.Url_Custom.Location = new System.Drawing.Point(409, 182);
            this.Url_Custom.Multiline = true;
            this.Url_Custom.Name = "Url_Custom";
            this.Url_Custom.ReadOnly = true;
            this.Url_Custom.Size = new System.Drawing.Size(393, 42);
            this.Url_Custom.TabIndex = 32;
            this.Url_Custom.Text = "Steam Account Profile Custom URL\r\n(exg: https://steamcommunity.com/id/Exzh_PMGI/)" +
    "";
            // 
            // Steam3GID
            // 
            this.Steam3GID.BackColor = System.Drawing.Color.White;
            this.Steam3GID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Steam3GID.Font = new System.Drawing.Font("方正黑体简体", 9.5F);
            this.Steam3GID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Steam3GID.HideSelection = false;
            this.Steam3GID.Location = new System.Drawing.Point(221, 92);
            this.Steam3GID.Name = "Steam3GID";
            this.Steam3GID.ReadOnly = true;
            this.Steam3GID.Size = new System.Drawing.Size(162, 15);
            this.Steam3GID.TabIndex = 31;
            this.Steam3GID.Text = "Steam3GID";
            // 
            // SteamID32
            // 
            this.SteamID32.BackColor = System.Drawing.Color.White;
            this.SteamID32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SteamID32.Font = new System.Drawing.Font("方正黑体简体", 9.5F);
            this.SteamID32.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SteamID32.HideSelection = false;
            this.SteamID32.Location = new System.Drawing.Point(208, 71);
            this.SteamID32.Name = "SteamID32";
            this.SteamID32.ReadOnly = true;
            this.SteamID32.Size = new System.Drawing.Size(174, 15);
            this.SteamID32.TabIndex = 30;
            this.SteamID32.Text = "SteamID32";
            // 
            // SteamID64
            // 
            this.SteamID64.BackColor = System.Drawing.Color.White;
            this.SteamID64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SteamID64.Font = new System.Drawing.Font("方正黑体简体", 9.5F);
            this.SteamID64.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SteamID64.HideSelection = false;
            this.SteamID64.Location = new System.Drawing.Point(208, 51);
            this.SteamID64.Name = "SteamID64";
            this.SteamID64.ReadOnly = true;
            this.SteamID64.Size = new System.Drawing.Size(174, 15);
            this.SteamID64.TabIndex = 29;
            this.SteamID64.Text = "SteamID64";
            // 
            // LimitedAccount
            // 
            this.LimitedAccount.AutoSize = true;
            this.LimitedAccount.Font = new System.Drawing.Font("方正黑体简体", 16F);
            this.LimitedAccount.Location = new System.Drawing.Point(245, 207);
            this.LimitedAccount.Name = "LimitedAccount";
            this.LimitedAccount.Size = new System.Drawing.Size(49, 25);
            this.LimitedAccount.TabIndex = 28;
            this.LimitedAccount.Text = "N/A";
            this.LimitedAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Trade_Banned
            // 
            this.Trade_Banned.AutoSize = true;
            this.Trade_Banned.Font = new System.Drawing.Font("方正黑体简体", 16F);
            this.Trade_Banned.Location = new System.Drawing.Point(245, 182);
            this.Trade_Banned.Name = "Trade_Banned";
            this.Trade_Banned.Size = new System.Drawing.Size(49, 25);
            this.Trade_Banned.TabIndex = 27;
            this.Trade_Banned.Text = "N/A";
            this.Trade_Banned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Games_Banned
            // 
            this.Games_Banned.AutoSize = true;
            this.Games_Banned.Font = new System.Drawing.Font("方正黑体简体", 16F);
            this.Games_Banned.Location = new System.Drawing.Point(249, 279);
            this.Games_Banned.Name = "Games_Banned";
            this.Games_Banned.Size = new System.Drawing.Size(49, 25);
            this.Games_Banned.TabIndex = 26;
            this.Games_Banned.Text = "N/A";
            this.Games_Banned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VAC_BannedTimes
            // 
            this.VAC_BannedTimes.AutoSize = true;
            this.VAC_BannedTimes.Font = new System.Drawing.Font("方正黑体简体", 16F);
            this.VAC_BannedTimes.Location = new System.Drawing.Point(249, 254);
            this.VAC_BannedTimes.Name = "VAC_BannedTimes";
            this.VAC_BannedTimes.Size = new System.Drawing.Size(49, 25);
            this.VAC_BannedTimes.TabIndex = 25;
            this.VAC_BannedTimes.Text = "N/A";
            this.VAC_BannedTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VAC_Cheats
            // 
            this.VAC_Cheats.AutoSize = true;
            this.VAC_Cheats.Font = new System.Drawing.Font("方正黑体简体", 16F);
            this.VAC_Cheats.Location = new System.Drawing.Point(245, 157);
            this.VAC_Cheats.Name = "VAC_Cheats";
            this.VAC_Cheats.Size = new System.Drawing.Size(49, 25);
            this.VAC_Cheats.TabIndex = 24;
            this.VAC_Cheats.Text = "N/A";
            this.VAC_Cheats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Copy_SteamNickname
            // 
            this.Copy_SteamNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Copy_SteamNickname.FlatAppearance.BorderSize = 0;
            this.Copy_SteamNickname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_SteamNickname.Font = new System.Drawing.Font("方正黑体简体", 14F);
            this.Copy_SteamNickname.ForeColor = System.Drawing.SystemColors.Control;
            this.Copy_SteamNickname.Location = new System.Drawing.Point(353, 17);
            this.Copy_SteamNickname.Name = "Copy_SteamNickname";
            this.Copy_SteamNickname.Size = new System.Drawing.Size(30, 30);
            this.Copy_SteamNickname.TabIndex = 23;
            this.Copy_SteamNickname.Text = "✂";
            this.Copy_SteamNickname.UseVisualStyleBackColor = false;
            this.Copy_SteamNickname.Click += new System.EventHandler(this.Copy_SteamNickname_Click);
            // 
            // Copy_Numeric_URL
            // 
            this.Copy_Numeric_URL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Copy_Numeric_URL.FlatAppearance.BorderSize = 0;
            this.Copy_Numeric_URL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_Numeric_URL.Font = new System.Drawing.Font("方正黑体简体", 9F);
            this.Copy_Numeric_URL.ForeColor = System.Drawing.SystemColors.Control;
            this.Copy_Numeric_URL.Location = new System.Drawing.Point(709, 232);
            this.Copy_Numeric_URL.Name = "Copy_Numeric_URL";
            this.Copy_Numeric_URL.Size = new System.Drawing.Size(93, 28);
            this.Copy_Numeric_URL.TabIndex = 22;
            this.Copy_Numeric_URL.Text = "复制到剪贴板";
            this.Copy_Numeric_URL.UseVisualStyleBackColor = false;
            this.Copy_Numeric_URL.Click += new System.EventHandler(this.Copy_Numeric_URL_Click);
            // 
            // Copy_Custom_URL
            // 
            this.Copy_Custom_URL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Copy_Custom_URL.FlatAppearance.BorderSize = 0;
            this.Copy_Custom_URL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_Custom_URL.Font = new System.Drawing.Font("方正黑体简体", 9F);
            this.Copy_Custom_URL.ForeColor = System.Drawing.SystemColors.Control;
            this.Copy_Custom_URL.Location = new System.Drawing.Point(709, 150);
            this.Copy_Custom_URL.Name = "Copy_Custom_URL";
            this.Copy_Custom_URL.Size = new System.Drawing.Size(93, 28);
            this.Copy_Custom_URL.TabIndex = 21;
            this.Copy_Custom_URL.Text = "复制到剪贴板";
            this.Copy_Custom_URL.UseVisualStyleBackColor = false;
            this.Copy_Custom_URL.Click += new System.EventHandler(this.Copy_Custom_URL_Click);
            // 
            // Evaluation
            // 
            this.Evaluation.AutoSize = true;
            this.Evaluation.Font = new System.Drawing.Font("方正黑体简体", 22F);
            this.Evaluation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.Evaluation.Location = new System.Drawing.Point(81, 337);
            this.Evaluation.Name = "Evaluation";
            this.Evaluation.Size = new System.Drawing.Size(135, 34);
            this.Evaluation.TabIndex = 20;
            this.Evaluation.Text = "信誉良好";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 349);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 14);
            this.label19.TabIndex = 19;
            this.label19.Text = "总体评价：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(406, 247);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 14);
            this.label18.TabIndex = 18;
            this.label18.Text = "Steam 个人资料永久 URL ：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(406, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 14);
            this.label17.TabIndex = 17;
            this.label17.Text = "Steam 个人资料自定义 URL ：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("方正黑体简体", 14F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label16.Location = new System.Drawing.Point(405, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 42);
            this.label16.TabIndex = 16;
            this.label16.Text = "Steam 个人资料页\r\n————————";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 14);
            this.label15.TabIndex = 15;
            this.label15.Text = "游戏内被踢出的次数：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 14);
            this.label14.TabIndex = 14;
            this.label14.Text = "Valve Anti-Cheat (VAC) 被踢出的次数：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 14);
            this.label13.TabIndex = 13;
            this.label13.Text = "是否是受限制的账户：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 14);
            this.label12.TabIndex = 12;
            this.label12.Text = "Steam 交易封禁：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valve Anti-Cheat (VAC) 封禁：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("方正黑体简体", 14F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(18, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 42);
            this.label10.TabIndex = 10;
            this.label10.Text = "信誉\r\n——";
            // 
            // Add_SteamFriend
            // 
            this.Add_SteamFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_SteamFriend.FlatAppearance.BorderSize = 0;
            this.Add_SteamFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_SteamFriend.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.Add_SteamFriend.ForeColor = System.Drawing.SystemColors.Control;
            this.Add_SteamFriend.Location = new System.Drawing.Point(684, 16);
            this.Add_SteamFriend.Name = "Add_SteamFriend";
            this.Add_SteamFriend.Size = new System.Drawing.Size(118, 28);
            this.Add_SteamFriend.TabIndex = 9;
            this.Add_SteamFriend.Text = "+ Steam 好友";
            this.Add_SteamFriend.UseVisualStyleBackColor = false;
            this.Add_SteamFriend.Click += new System.EventHandler(this.Add_SteamFriend_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "隐私设定：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "真实姓名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "账户注册时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Steam 第三代ID：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Steam ID (32)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Steam ID (64)：";
            // 
            // Label_SteamNickname
            // 
            this.Label_SteamNickname.AutoSize = true;
            this.Label_SteamNickname.Font = new System.Drawing.Font("方正黑体简体", 15F);
            this.Label_SteamNickname.Location = new System.Drawing.Point(191, 23);
            this.Label_SteamNickname.Name = "Label_SteamNickname";
            this.Label_SteamNickname.Size = new System.Drawing.Size(156, 22);
            this.Label_SteamNickname.TabIndex = 2;
            this.Label_SteamNickname.Text = "SteamNickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Steam 名称：";
            // 
            // InfoSearchMode
            // 
            this.InfoSearchMode.Controls.Add(this.Mode_Name);
            this.InfoSearchMode.Controls.Add(this.Mode_ID);
            this.InfoSearchMode.Location = new System.Drawing.Point(13, 8);
            this.InfoSearchMode.Name = "InfoSearchMode";
            this.InfoSearchMode.Size = new System.Drawing.Size(118, 44);
            this.InfoSearchMode.TabIndex = 5;
            // 
            // Mode_ID
            // 
            this.Mode_ID.AutoSize = true;
            this.Mode_ID.Checked = true;
            this.Mode_ID.Location = new System.Drawing.Point(6, 5);
            this.Mode_ID.Name = "Mode_ID";
            this.Mode_ID.Size = new System.Drawing.Size(75, 18);
            this.Mode_ID.TabIndex = 0;
            this.Mode_ID.TabStop = true;
            this.Mode_ID.Text = "Steam ID";
            this.Mode_ID.UseVisualStyleBackColor = true;
            // 
            // Mode_Name
            // 
            this.Mode_Name.AutoSize = true;
            this.Mode_Name.Location = new System.Drawing.Point(6, 24);
            this.Mode_Name.Name = "Mode_Name";
            this.Mode_Name.Size = new System.Drawing.Size(99, 18);
            this.Mode_Name.TabIndex = 1;
            this.Mode_Name.Text = "Steam 用户名";
            this.Mode_Name.UseVisualStyleBackColor = true;
            // 
            // CommunityBanned
            // 
            this.CommunityBanned.AutoSize = true;
            this.CommunityBanned.Font = new System.Drawing.Font("方正黑体简体", 16F);
            this.CommunityBanned.Location = new System.Drawing.Point(245, 232);
            this.CommunityBanned.Name = "CommunityBanned";
            this.CommunityBanned.Size = new System.Drawing.Size(49, 25);
            this.CommunityBanned.TabIndex = 41;
            this.CommunityBanned.Text = "N/A";
            this.CommunityBanned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 40;
            this.label3.Text = "Steam 社区封禁：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 14);
            this.label1.TabIndex = 42;
            this.label1.Text = "距上次被系统踢出的天数：";
            // 
            // DaysSinceLastBan
            // 
            this.DaysSinceLastBan.AutoSize = true;
            this.DaysSinceLastBan.Font = new System.Drawing.Font("方正黑体简体", 16F);
            this.DaysSinceLastBan.Location = new System.Drawing.Point(249, 304);
            this.DaysSinceLastBan.Name = "DaysSinceLastBan";
            this.DaysSinceLastBan.Size = new System.Drawing.Size(49, 25);
            this.DaysSinceLastBan.TabIndex = 43;
            this.DaysSinceLastBan.Text = "N/A";
            this.DaysSinceLastBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About_Start
            // 
            this.About_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.About_Start.FlatAppearance.BorderSize = 0;
            this.About_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_Start.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.About_Start.ForeColor = System.Drawing.SystemColors.Control;
            this.About_Start.Location = new System.Drawing.Point(668, 343);
            this.About_Start.Name = "About_Start";
            this.About_Start.Size = new System.Drawing.Size(134, 28);
            this.About_Start.TabIndex = 44;
            this.About_Start.Text = "关于这个程序...";
            this.About_Start.UseVisualStyleBackColor = false;
            this.About_Start.Click += new System.EventHandler(this.About_Click);
            // 
            // Online_state
            // 
            this.Online_state.Image = global::SteamInfo.Properties.Resources.btnmin;
            this.Online_state.Location = new System.Drawing.Point(611, 22);
            this.Online_state.Name = "Online_state";
            this.Online_state.Size = new System.Drawing.Size(16, 16);
            this.Online_state.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Online_state.TabIndex = 37;
            this.Online_state.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SteamInfo.Properties.Resources._25_avatar_middle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // advTabControl1
            // 
            this.advTabControl1.Controls.Add(this.SteamInfo);
            this.advTabControl1.Controls.Add(this.tabPage2);
            this.advTabControl1.Controls.Add(this.tabPage1);
            this.advTabControl1.Controls.Add(this.tabPage3);
            this.advTabControl1.Controls.Add(this.tabPage4);
            this.advTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTabControl1.Location = new System.Drawing.Point(1, 31);
            this.advTabControl1.Name = "advTabControl1";
            this.advTabControl1.SelectedIndex = 0;
            this.advTabControl1.Size = new System.Drawing.Size(821, 468);
            this.advTabControl1.TabIndex = 6;
            // 
            // SteamInfo
            // 
            this.SteamInfo.BackColor = System.Drawing.SystemColors.Control;
            this.SteamInfo.Controls.Add(this.InfoSearchMode);
            this.SteamInfo.Controls.Add(this.Text_Clear);
            this.SteamInfo.Controls.Add(this.InfoPanel);
            this.SteamInfo.Controls.Add(this.Info_Submit);
            this.SteamInfo.Controls.Add(this.SteamIDInput);
            this.SteamInfo.Location = new System.Drawing.Point(0, 19);
            this.SteamInfo.Name = "SteamInfo";
            this.SteamInfo.Padding = new System.Windows.Forms.Padding(3);
            this.SteamInfo.Size = new System.Drawing.Size(821, 449);
            this.SteamInfo.TabIndex = 0;
            this.SteamInfo.Text = "Steam 玩家查询";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 19);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Steam 游戏查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 449);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Key 批量激活";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 19);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(821, 449);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Steam 集换式卡牌";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 19);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(821, 449);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "福利放送";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 500);
            this.Controls.Add(this.advTabControl1);
            this.Font = new System.Drawing.Font("方正黑体简体", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(823, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(823, 500);
            this.Name = "MainUI";
            this.Resizable = false;
            this.Text = "Steam Info";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.InfoSearchMode.ResumeLayout(false);
            this.InfoSearchMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Online_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.advTabControl1.ResumeLayout(false);
            this.SteamInfo.ResumeLayout(false);
            this.SteamInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox SteamIDInput;
        private System.Windows.Forms.Button Info_Submit;
        private System.Windows.Forms.Button Text_Clear;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.PictureBox Online_state;
        private System.Windows.Forms.Label Privacy;
        private System.Windows.Forms.Label Realname;
        private System.Windows.Forms.Label RegisterDate;
        private System.Windows.Forms.TextBox Url_Numeric;
        private System.Windows.Forms.TextBox Url_Custom;
        private System.Windows.Forms.TextBox Steam3GID;
        private System.Windows.Forms.TextBox SteamID32;
        private System.Windows.Forms.TextBox SteamID64;
        private System.Windows.Forms.Label LimitedAccount;
        private System.Windows.Forms.Label Trade_Banned;
        private System.Windows.Forms.Label Games_Banned;
        private System.Windows.Forms.Label VAC_BannedTimes;
        private System.Windows.Forms.Label VAC_Cheats;
        private System.Windows.Forms.Button Copy_SteamNickname;
        private System.Windows.Forms.Button Copy_Numeric_URL;
        private System.Windows.Forms.Button Copy_Custom_URL;
        private System.Windows.Forms.Label Evaluation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Add_SteamFriend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_SteamNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Online_txt;
        private System.Windows.Forms.Button ForMoreInfo;
        private System.Windows.Forms.Panel InfoSearchMode;
        private System.Windows.Forms.RadioButton Mode_Name;
        private System.Windows.Forms.RadioButton Mode_ID;
        private System.Windows.Forms.Label CommunityBanned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DaysSinceLastBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button About_Start;
        private Controls.AdvTabControl advTabControl1;
        private System.Windows.Forms.TabPage SteamInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

