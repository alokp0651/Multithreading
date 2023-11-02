using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeConsumingWork.Enabled = false;
            PrintNumber.Enabled = false;

            DoTimeConsumingWork();

            //another way 
            //Thread workerThread = new Thread(DoTimeConsumingWork);
            //workerThread.Start();//<----starting thread but rembember using this way the job for excuting DoTimeConsumingmethod offloaded to this worker thread so the button will not be disabled.(this is multi threading and this will make your app more responsive)

            TimeConsumingWork.Enabled = true;
            PrintNumber.Enabled = true;


        }
        private void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void PrintNumber_Click(object sender, EventArgs e)
        {
            for (int i = 1;i< 10; i++)
            {
                listBox1.Items.Add(i);

            }
        }
    }
}
