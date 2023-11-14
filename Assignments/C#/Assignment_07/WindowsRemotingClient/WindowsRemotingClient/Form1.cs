using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemotingServer;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;


namespace WindowsRemotingClient
{
    public partial class Form1 : Form
    {
        Service remoteobj = new Service();
        
        public Form1()
        {
            InitializeComponent();
            remoteobj = (Service)Activator.GetObject(typeof(Service),"tcp://localhost:9050/OurFirstRemoteService");
        }

        private void btnHighest_Click(object sender, EventArgs e)
        {
            //channel and services registration
            
            int n1 = Int32.Parse(txtNum1.Text);
            int n2 = Int32.Parse(txtNum2.Text);
            txtresult.Text= (remoteobj.HighestNumber(n1,n2)).ToString();
        }

        private void btnSmallest_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(txtNum1.Text);
            int n2 = Int32.Parse(txtNum2.Text);
            txtresult.Text = (remoteobj.SmallestNumber(n1, n2)).ToString();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(txtNum1.Text);
            int n2 = Int32.Parse(txtNum2.Text);
            txtresult.Text = (remoteobj.MultiplicationNumber(n1, n2)).ToString();
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(txtNum1.Text);
            int n2 = Int32.Parse(txtNum2.Text);
            txtresult.Text = (remoteobj.Remainder(n1, n2)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
