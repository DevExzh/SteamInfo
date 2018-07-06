using Exzh.UserInterface.UI;
using Exzh.Controls;
using ExzhControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Steam 信息查询工具
 * Copyright © 2018 Exzh_PMGI
 * 授权协议：CC BY-NC-SA Global 4.0
 * 修改程序代码时请保留此信息！谢谢！
*/

namespace SteamInfo
{
    public partial class MainUI : ExzhForm
    {
        public MainUI()
        {
            InitializeComponent();
        }

        public static string ApiKey = string.Empty;//声明一个string类型，用来存储获取到的 Steam Web API Key
        public static int SteamID64V;//声明一个int类型，用来存储获取到的 64位 Steam ID
        public static string cusUrl;//声明一个string类型，用来存储获取到的用户自定义Url
        public static string numUrl;//声明一个string类型，用来存储获取到的用户永久Url

        //使“复制到剪贴板”按钮时刻尾随在SteamNickname后
        private void SetPosition()
        {
            Copy_SteamNickname.Location = new Point(Label_SteamNickname.Location.X + Label_SteamNickname.Width + 3, 17);
        }

        //private delegate void ApiKeyDelegate(string currenturl);

        /*private void CallbackMethod(IAsyncResult ar)
        {
            // Retrieve the delegate.
            ApiKeyDelegate dlgt = (ApiKeyDelegate)ar.AsyncState;

            // Call EndInvoke to retrieve the results.
            dlgt.EndInvoke(ar);
        }*/

        //用户按下“查询”按钮时调用的函数
        private void Info_Submit_Click(object sender, EventArgs e)
        {
            if (Mode_ID.Checked==true)
            {
                if(SteamIDInput.Text.StartsWith("765")==true)
                {
                    SteamIDInput.Enabled = false;
                }
                if (SteamIDInput.Text.StartsWith("STEAM_") == true)
                {
                    SteamIDInput.Enabled = false;
                    SteamIDInput.Text = Convert.ToString(Convert.ToUInt64(SteamIDInput.Text.Replace("STEAM_0", "").Replace(":0:", "").Replace(":1:", "")) * (ulong)2 + (ulong)76561197960265728);
                }
                if (SteamIDInput.Text.StartsWith("[U:1:") == true && SteamIDInput.Text.EndsWith("]")==true)
                {
                    SteamIDInput.Enabled = false;
                    SteamIDInput.Text = Convert.ToString(Convert.ToUInt64(SteamIDInput.Text.Replace("[U:1:", "").Replace("]", "")) + (ulong)76561197960265728);
                }
            }
            NeedAccept accept = new NeedAccept();
            accept.SendKey += new NeedAccept.AcceptHandler(AcceptKey); //利用委托来从NeedAccept窗体获得传入值
            accept.Show();
        }

        private void SetPic(string url)
        {
            WebRequest webreq = System.Net.WebRequest.Create(url);
            WebResponse webres = webreq.GetResponse();
            using (System.IO.Stream stream = webres.GetResponseStream())
            {
                pictureBox1.Image = Image.FromStream(stream);
            }
        }

        private void RequestSteamInfo(string currenturl)
        {
            var steamid32="";
            var y = 0;
            SteamAccount.SetSteamInfo(currenturl);
            Json.GetResultFromJson("https://api.steampowered.com/ISteamUser/GetPlayerBans/v1/?key=" + ApiKey + "&steamids=id" + SteamAccount.SteamID64);
            SetPic(SteamAccount.UserPicUrl);
            Label_SteamNickname.Text = SteamAccount.SteamName;
            SteamID64.Text = SteamAccount.SteamID64;
            Steam3GID.Text =steamid32= "[U:1:" + (Convert.ToUInt64(SteamAccount.SteamID64) - (ulong)76561197960265728) + "]";
            if (Convert.ToUInt64(SteamAccount.SteamID64) % (ulong)2 == 0) y = 0; else y = 1;
            SteamID32.Text = "STEAM_0:" + y + ":" + (Convert.ToUInt64(SteamAccount.SteamID64) - (ulong)76561197960265728) / 2;
            RegisterDate.Text = SteamAccount.memberSince;
            Realname.Text = SteamAccount.RealName;
            Privacy.Text = SteamAccount.privacyState;
            if (SteamAccount.VAC_Banned == true) VAC_Cheats.Text = "是"; else VAC_Cheats.Text = "否";
            if (SteamAccount.TradeBanState == true) Trade_Banned.Text = "是"; else Trade_Banned.Text = "否";
            if (SteamAccount.IsLimitedAccount == true) LimitedAccount.Text = "是"; else LimitedAccount.Text = "否";
            Url_Custom.Text = cusUrl = "https://steamcommunity.com/id/" + SteamAccount.SteamName;
            Url_Numeric.Text = numUrl = "https://steamcommunity.com/profiles/" + SteamAccount.SteamID64;
            if(SteamAccount.OnlineState==true)
            {
                Online_txt.Text = "在线";
                Online_txt.ForeColor = Color.FromArgb(76, 175, 80);
                Online_state.Image = global::SteamInfo.Properties.Resources.btnmin;
            }
            else
            {
                Online_txt.Text = "离线";
                Online_txt.ForeColor = Color.FromArgb(123, 123, 123);
                Online_state.Image = global::SteamInfo.Properties.Resources.btnmax;
            }
            if (Json.CommunityBanned == true) CommunityBanned.Text = "是"; else CommunityBanned.Text = "否";
            VAC_BannedTimes.Text = Json.NumberOfVACBans;
            Games_Banned.Text = Json.NumberOfGameBans;
            DaysSinceLastBan.Text = Json.DaysSinceLastBan;
            SetPosition();
            UserRating();
            InfoPanel.Visible = true;
            SteamIDInput.Enabled = true;
        }

        private void UserRating()
        {
            if (SteamAccount.VAC_Banned == false &&
                SteamAccount.TradeBanState == false &&
                SteamAccount.IsLimitedAccount == false &&
                Json.CommunityBanned == false
                )
            {
                Evaluation.ForeColor = Color.FromArgb(76, 175, 80);
                Evaluation.Text = "信誉良好";
            }

            else
            if ((SteamAccount.VAC_Banned == true &&
                SteamAccount.TradeBanState == false &&
                SteamAccount.IsLimitedAccount == false &&
                Json.CommunityBanned == false
                ) ||
                (
                SteamAccount.VAC_Banned == false &&
                SteamAccount.TradeBanState == true &&
                SteamAccount.IsLimitedAccount == false &&
                Json.CommunityBanned == false
                ) ||
                (
                SteamAccount.VAC_Banned == false &&
                SteamAccount.TradeBanState == false &&
                SteamAccount.IsLimitedAccount == true &&
                Json.CommunityBanned == false
                ) ||
                (
                SteamAccount.VAC_Banned == false &&
                SteamAccount.TradeBanState == false &&
                SteamAccount.IsLimitedAccount == false &&
                Json.CommunityBanned == true
                )
          )
            {
                Evaluation.ForeColor = Color.FromArgb(255, 152, 0);
                Evaluation.Text = "需要警惕";
            }

            else
            if ((SteamAccount.VAC_Banned == true &&
                SteamAccount.TradeBanState == true &&
                SteamAccount.IsLimitedAccount == true &&
                Json.CommunityBanned == true
                )||Convert.ToInt32(VAC_BannedTimes)>=2)
            {
                Evaluation.ForeColor = Color.FromArgb(244, 67, 54);
                Evaluation.Text = "信任危机";
            }
        }

        private void GetSteamInfo()
        {
            var currenturl = "";
            if (Mode_ID.Checked==true)//使用SteamID查询
            {
                currenturl = "http://steamcommunity.com/profiles/" + SteamIDInput.Text + "?xml=1";
            }
            else if(Mode_Name.Checked==true)//使用用户名查询
            {
                currenturl = "http://steamcommunity.com/id/" + SteamIDInput.Text + "?xml=1";
            }
            if (SteamIDExists.SteamAccountExists(currenturl) == true)
            {
                //ApiKeyDelegate apiKeyDelegate = new ApiKeyDelegate(RequestSteamInfo);
                //AsyncCallback async = new AsyncCallback(CallbackMethod);
                //IAsyncResult asyncResult = apiKeyDelegate.BeginInvoke(currenturl, async, apiKeyDelegate);
                RequestSteamInfo(currenturl);
            }
            else new Error("程序在向 Valve 服务器提交查询请求过程中发生错误。\r\n错误原因：账号不存在，请检查您输入的信息是否正确！").Show();
        }

        //接收到ApiKey后调用的函数
        private void AcceptKey(string apikey) { ApiKey = apikey; GetSteamInfo(); }

        //清除文本框SteamIDInput的内容
        private void Text_Clear_Click(object sender, EventArgs e) { SteamIDInput.Text = ""; }

        //将Steam昵称复制到剪贴板
        private void Copy_SteamNickname_Click(object sender, EventArgs e)
        {
            if (Label_SteamNickname.Text != "") Clipboard.SetDataObject(Label_SteamNickname.Text);
        }

        //调用方法，开启Steam客户端加好友
        private void Add_SteamFriend_Click(object sender, EventArgs e)
        {
            var AddFriendUrl = "steam://friends/add/" + SteamAccount.SteamID64;
            Process.Start(AddFriendUrl);
        }

        //复制用户自定义的URL
        private void Copy_Custom_URL_Click(object sender, EventArgs e)
        {
            if (cusUrl != "") Clipboard.SetDataObject(cusUrl);
        }

        //复制用户永久URL
        private void Copy_Numeric_URL_Click(object sender, EventArgs e)
        {
            if (numUrl != "") Clipboard.SetDataObject(numUrl);
        }

        //单击“更多...”按钮产生的事件
        private void ForMoreInfo_Click(object sender, EventArgs e)
        {
            new MoreInfo(SteamID64V).Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
