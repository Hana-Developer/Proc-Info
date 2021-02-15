using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] allProc = Process.GetProcesses();

            foreach(Process proc in allProc)
            {
                listBox1.Items.Add("====================================");
                listBox1.Items.Add(String.Format("프로세스 이름 : {0}", proc.ProcessName));
                listBox1.Items.Add(String.Format("프로세스 ID : {0}", proc.Id));
                listBox1.Items.Add("====================================");
            }
        }
    }
}
