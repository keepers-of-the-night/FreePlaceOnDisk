using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreePlaceOnDisk
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int i = 0, j=0;
            Label[] l = {label1, label2, label3, label4, label5 , label6, label7, label8, label9, label10};
            foreach (DriveInfo MyDriveInfo in allDrives)
            {
                if (MyDriveInfo.IsReady == true)
                {
                    l[i].Text= " Диск : " + MyDriveInfo.Name;
                    l[i+5].Text = " Свободного места : " + Convert.ToString((MyDriveInfo.AvailableFreeSpace)/1024/1024);
                    i++;
                }
                if(i<4)
                {
                    for(j=i+1; j<=4; j++)
                    {
                        l[j].Text = "--";
                        l[j+5].Text = "--";
                    }
                }
            }
            label12.Text = Convert.ToString(c);
            c += 1;
        }
    }
}
