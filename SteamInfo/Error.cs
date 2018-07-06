using Exzh.UserInterface.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamInfo
{
    public partial class Error : ExzhForm
    {
        public Error(string erroreason)
        {
            InitializeComponent();
            Error_Result.Text = erroreason;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
