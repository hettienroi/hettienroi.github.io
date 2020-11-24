using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            string output = "       <div class=\"column ";
            output += txtCat.Text.ToString() + "\">\n           <div class=\"content\">\n" +
                "               <a href=\"";
            output += txtLinkStore.Text.ToString() + "\" target = \"_blank\" >\n" +
                "                   <img src=\"pics/";
            output += txtCode.Text.ToString() + ".jpg\" alt=\"" + txtCode.Text.ToString() + "\" style=\"width:100% \">\n" +
                "               </a>\n" +
                "               <b>Code: ";
            output += txtCode.Text.ToString() + "</b>\n" +
                "               <br>\n" +
                "               Giá: €";
            output += txtPriceStore.Text.ToString() + "\n" +
                "               <br>\n" +
                "               Bạn: $";
            output += txtPriceBan.Text.ToString() + "\n" +
                "               <br>\n" +
                "               Size: ";
            output += txtSize.Text.ToString() + " (cm)\n" +
                "               <br>\n" +
                "               <center><a href=\"";
            output += txtLinkBan.Text.ToString() + "\" target=\"_blank\">Link bạn</a></center>\n" +
                "           </div>\n" +
                "       </div>";
            System.Windows.Forms.Clipboard.SetText(output);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCat.Clear();
            txtCode.Clear();
            txtLinkBan.Clear();
            txtLinkStore.Clear();
            txtPriceBan.Clear();
            txtPriceStore.Clear();
            txtSize.Clear();
        }
    }
}
