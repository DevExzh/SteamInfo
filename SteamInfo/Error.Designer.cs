namespace SteamInfo
{
    partial class Error
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
            this.Error_Result = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正黑体简体", 20F);
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "发生错误\r\n————";
            // 
            // Error_Result
            // 
            this.Error_Result.Font = new System.Drawing.Font("方正黑体简体", 10.5F);
            this.Error_Result.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Error_Result.Location = new System.Drawing.Point(20, 104);
            this.Error_Result.Name = "Error_Result";
            this.Error_Result.Size = new System.Drawing.Size(578, 185);
            this.Error_Result.TabIndex = 2;
            this.Error_Result.Text = "程序在向 Valve 服务器提交查询请求过程中发生错误。\r\n错误原因：账号不存在，请检查您输入的信息是否正确！";
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("方正黑体简体", 10F);
            this.Confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.Confirm.Location = new System.Drawing.Point(517, 299);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(74, 28);
            this.Confirm.TabIndex = 42;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 347);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Error_Result);
            this.Controls.Add(this.label1);
            this.IconLeftMargin = 0;
            this.IconSize = new System.Drawing.Size(0, 0);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(609, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(609, 347);
            this.Name = "Error";
            this.Resizable = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Error!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Error_Result;
        private System.Windows.Forms.Button Confirm;
    }
}