using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class Form1 : Form
    {
        Authorizate auth;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label10.Text = "";

            
            Entrance.BackColor = System.Drawing.Color.Transparent;
            Registration.BackColor = System.Drawing.Color.Transparent;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            auth = new Authorizate(label1.Text, label2.Text);

            label3.Text = auth.SendToServerLoginPassword();

            if (auth.UserAuthorizate)
            {

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
