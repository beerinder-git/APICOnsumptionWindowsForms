using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        CovidAPI CAPI;

        public Form1()
        {
            InitializeComponent();

            CAPI = new CovidAPI();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int output = await CAPI.ReturnDeaths(textBox1.Text);

            textBox2.Text = output.ToString(); 
            
        }
    }
}
