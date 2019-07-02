using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmBot
{
    public partial class commandview : Form
    {
        List<string> cmd = new List<string>();
        public commandview(List<string> commands)
        {
            cmd = commands;
            InitializeComponent();
        }

        private void commandview_Load(object sender, EventArgs e)
        {
            foreach (var command in cmd)
            {
                listCMD.Items.Add(command);
            }
        }
    }
}
