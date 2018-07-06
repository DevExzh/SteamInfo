namespace SteamInfo
{
    partial class NeedAccept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeedAccept));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SteamWebAPI_Key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SteamWebAPI_Canel = new System.Windows.Forms.Button();
            this.SteamWebAPI_KeyConfirm = new System.Windows.Forms.Button();
            this.SteamWebAPI_GetKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正黑体简体", 20F);
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "需要授权\r\n————";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("方正黑体简体", 10.5F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // SteamWebAPI_Key
            // 
            this.SteamWebAPI_Key.Font = new System.Drawing.Font("方正黑体简体", 22F);
            this.SteamWebAPI_Key.Location = new System.Drawing.Point(23, 202);
            this.SteamWebAPI_Key.Name = "SteamWebAPI_Key";
            this.SteamWebAPI_Key.Size = new System.Drawing.Size(560, 40);
            this.SteamWebAPI_Key.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("方正黑体简体", 12F);
            this.label3.Location = new System.Drawing.Point(21, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Steam Web API 密钥：";
            // 
            // SteamWebAPI_Canel
            // 
            this.SteamWebAPI_Canel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SteamWebAPI_Canel.FlatAppearance.BorderSize = 0;
            this.SteamWebAPI_Canel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteamWebAPI_Canel.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.SteamWebAPI_Canel.ForeColor = System.Drawing.SystemColors.Control;
            this.SteamWebAPI_Canel.Location = new System.Drawing.Point(509, 251);
            this.SteamWebAPI_Canel.Name = "SteamWebAPI_Canel";
            this.SteamWebAPI_Canel.Size = new System.Drawing.Size(74, 28);
            this.SteamWebAPI_Canel.TabIndex = 40;
            this.SteamWebAPI_Canel.Text = "取消";
            this.SteamWebAPI_Canel.UseVisualStyleBackColor = false;
            this.SteamWebAPI_Canel.Click += new System.EventHandler(this.SteamWebAPI_Canel_Click);
            // 
            // SteamWebAPI_KeyConfirm
            // 
            this.SteamWebAPI_KeyConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SteamWebAPI_KeyConfirm.FlatAppearance.BorderSize = 0;
            this.SteamWebAPI_KeyConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteamWebAPI_KeyConfirm.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.SteamWebAPI_KeyConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.SteamWebAPI_KeyConfirm.Location = new System.Drawing.Point(429, 251);
            this.SteamWebAPI_KeyConfirm.Name = "SteamWebAPI_KeyConfirm";
            this.SteamWebAPI_KeyConfirm.Size = new System.Drawing.Size(74, 28);
            this.SteamWebAPI_KeyConfirm.TabIndex = 41;
            this.SteamWebAPI_KeyConfirm.Text = "确认";
            this.SteamWebAPI_KeyConfirm.UseVisualStyleBackColor = false;
            this.SteamWebAPI_KeyConfirm.Click += new System.EventHandler(this.SteamWebAPI_KeyConfirm_Click);
            // 
            // SteamWebAPI_GetKey
            // 
            this.SteamWebAPI_GetKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SteamWebAPI_GetKey.FlatAppearance.BorderSize = 0;
            this.SteamWebAPI_GetKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteamWebAPI_GetKey.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.SteamWebAPI_GetKey.ForeColor = System.Drawing.SystemColors.Control;
            this.SteamWebAPI_GetKey.Location = new System.Drawing.Point(323, 251);
            this.SteamWebAPI_GetKey.Name = "SteamWebAPI_GetKey";
            this.SteamWebAPI_GetKey.Size = new System.Drawing.Size(100, 28);
            this.SteamWebAPI_GetKey.TabIndex = 42;
            this.SteamWebAPI_GetKey.Text = "获取密钥";
            this.SteamWebAPI_GetKey.UseVisualStyleBackColor = false;
            this.SteamWebAPI_GetKey.Click += new System.EventHandler(this.SteamWebAPI_GetKey_Click);
            // 
            // NeedAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 310);
            this.Controls.Add(this.SteamWebAPI_GetKey);
            this.Controls.Add(this.SteamWebAPI_KeyConfirm);
            this.Controls.Add(this.SteamWebAPI_Canel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SteamWebAPI_Key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("方正黑体简体", 9F);
            this.IconLeftMargin = 0;
            this.IconSize = new System.Drawing.Size(0, 0);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(613, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(613, 310);
            this.Name = "NeedAccept";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = " Steam Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SteamWebAPI_Key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SteamWebAPI_Canel;
        private System.Windows.Forms.Button SteamWebAPI_KeyConfirm;
        private System.Windows.Forms.Button SteamWebAPI_GetKey;
    }
}