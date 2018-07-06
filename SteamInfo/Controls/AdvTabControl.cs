using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamInfo.Controls
{
    public partial class AdvTabControl : TabControl
    {
        public AdvTabControl()
        {
            InitializeComponent();
        }

        public override Rectangle DisplayRectangle
        {
            get
            {
                Rectangle rect = base.DisplayRectangle;
                return new Rectangle(rect.Left - 4, rect.Top - 4, rect.Width + 8, rect.Height + 8);
            }
        }

        protected override bool ShowFocusCues
        {
            get { return false; }
        }
    }
}
