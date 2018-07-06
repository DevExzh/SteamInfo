using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SteamInfo
{
    public static class SteamIDExists
    {
        /// <summary>
        /// 查询 Steam 是否存在
        /// </summary>
        /// <param name="url">Steam个人资料Url</param>
        /// <returns></returns>
        public static bool SteamAccountExists(string url)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(url);//读取Steam个人资料返回的XML
            XmlNode result = xmldoc.SelectSingleNode(@"//error");//判断Steam个人资料返回的XML是否存在error节点
            return result == null;
        }
    }

    public static class SteamAccount
    {
        public static bool VAC_Banned;
        public static int VAC_BanTimes;
        public static bool TradeBanState;
        public static bool IsLimitedAccount;
        public static string UserPicUrl;
        public static bool OnlineState;
        public static string privacyState;
        public static string SteamID64;
        public static string SteamName;
        public static string Location;
        public static string RealName;
        public static string memberSince;

        public static void SetSteamInfo(string url)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(url);
            XmlNode profile = xml.SelectSingleNode(@"//profile");
            if (profile != null)
            {
                SteamID64 = profile.SelectSingleNode(@"//steamID64").InnerText;
                SteamName = profile.SelectSingleNode(@"//steamID").InnerText.Replace("<![CDATA[ ", "").Replace(" ]]>", "");
                if (profile.SelectSingleNode(@"//onlineState").InnerText == "online") OnlineState = true; else OnlineState = false;
                privacyState = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(profile.SelectSingleNode(@"//privacyState").InnerText);
                UserPicUrl = profile.SelectSingleNode(@"//avatarFull").InnerText.Replace("<![CDATA[ ", "").Replace(" ]]>", "").Replace("\n", "").Replace(" ", "");
                if (profile.SelectSingleNode(@"//vacBanned").InnerText == "0") VAC_Banned = false; else VAC_Banned = true;
                if (profile.SelectSingleNode(@"//tradeBanState").InnerText == "None") TradeBanState = false; else TradeBanState = true;
                if (profile.SelectSingleNode(@"//isLimitedAccount").InnerText == "0") IsLimitedAccount = false; else IsLimitedAccount = true;
                memberSince = profile.SelectSingleNode(@"//memberSince").InnerText;
                Location = profile.SelectSingleNode(@"//location").InnerText.Replace("<![CDATA[ ", "").Replace(" ]]>", "");
                RealName = profile.SelectSingleNode(@"//realname").InnerText.Replace("<![CDATA[ ", "").Replace(" ]]>", "");
            }
        }
    }

    public class WebHelper
    {
        /// <summary>
        /// 获得重定向的Url
        /// </summary>
        /// <param name="originalAddress">原Url</param>
        /// <returns>重定向后的Url</returns>
        public static string GetTheRedirectUrl(string originalAddress)
        {
            string redirectUrl;
            WebRequest myRequest = WebRequest.Create(originalAddress);

            WebResponse myResponse = myRequest.GetResponse();
            redirectUrl = myResponse.ResponseUri.ToString();

            myResponse.Close();
            return redirectUrl;
        }
    }
}
