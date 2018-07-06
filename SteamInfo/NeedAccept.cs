using Exzh.UserInterface.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamInfo
{
    public partial class NeedAccept : ExzhForm
    {
        public NeedAccept()
        {
            InitializeComponent();
        }

        public delegate void AcceptHandler(string apikey);
        public event AcceptHandler SendKey;

        private void SteamWebAPI_KeyConfirm_Click(object sender, EventArgs e)
        {
            SendKey(SteamWebAPI_Key.Text);
            this.Close();
        }

        private void SteamWebAPI_Canel_Click(object sender, EventArgs e)
        {
            SendKey(string.Empty);
            this.Close();
        }

        private void SteamWebAPI_GetKey_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/dev/apikey");
        }
    }
}
