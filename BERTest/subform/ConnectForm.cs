using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SubForm
{
    public partial class SubFormConnect : Form
    {
        public SubFormConnect()
        {
            InitializeComponent();
        }

        public static string PPGserverAddressValue = "172.16.81.91";  //PPG IP，addre是string
        public static string ATTserverAddressValue = "172.16.81.96";  //ATT IP，addre是string
        public static int PPGserverPortValue = 5026;   // port是int
        public static int ATTserverPortValue = 5025;   //port通用

        private void saveConfig_Click(object sender, EventArgs e)
        {
            PPGserverAddressValue = PPGserverAddress.Text;
            PPGserverPortValue = int.Parse(PPGserverPort.Text.ToString());  // port 换int

            ATTserverAddressValue = ATTserverAddress.Text;
            ATTserverPortValue = int.Parse(ATTserverPort.Text.ToString());  // port 换int

            this.Close();  // 关闭当前窗口
        }

        private void Form1_Load(object sender, EventArgs e)  // 窗体恢复时加载上次的输入
        {
            // 加载保存的内容
            PPGserverAddress.Text = PPGserverAddressValue;
            PPGserverPort.Text = PPGserverPortValue.ToString();

            ATTserverAddress.Text = ATTserverAddressValue;
            ATTserverPort.Text = ATTserverPortValue.ToString();
        }

    }
}
