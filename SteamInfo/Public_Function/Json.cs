using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Xml;

namespace SteamInfo
{
    public static class Json
    {
        public static string getHtml(string html)//传入网址
        {
            string pageHtml = "";
            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            Byte[] pageData = MyWebClient.DownloadData(html); //从指定网站下载数据
            MemoryStream ms = new MemoryStream(pageData);
            using (StreamReader sr = new StreamReader(ms, Encoding.GetEncoding("GB2312")))
            {
                pageHtml = sr.ReadLine();
            }
            return pageHtml;
        }

        public static string NumberOfVACBans;
        public static string NumberOfGameBans;
        public static bool CommunityBanned;
        public static string DaysSinceLastBan;

        public static void GetResult(string json)
        {
            XmlDocument xml = JsonConvert.DeserializeXmlNode(json);
            XmlNode profile = xml.SelectSingleNode(@"//players");
            if (profile != null)
            {
                NumberOfVACBans = profile.SelectSingleNode(@"//NumberOfVACBans").InnerText;
                NumberOfGameBans = profile.SelectSingleNode(@"//NumberOfGameBans").InnerText;
                if (profile.SelectSingleNode(@"//CommunityBanned").InnerText == "true") CommunityBanned = true; else CommunityBanned = false;
                DaysSinceLastBan = profile.SelectSingleNode(@"//DaysSinceLastBan").InnerText;
            }
        }

        public static void GetResultFromJson(string json)
        {
            GetResult(getHtml(json));
        }
    }
}
