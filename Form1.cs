using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace prayer_time_1._0._0
{
    public partial class windowLabel : Form
    {
        public windowLabel()
        {
            InitializeComponent();
            
        }


        private void windowLabel_Load(object sender, EventArgs e)
        {
            string json;
            timer1.Start();
            cTimeDate.Text = DateTime.Now.ToLongTimeString();
            cDate.Text = DateTime.Now.ToLongDateString();
            string uri = "https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400\r\n";
            WebRequest request = WebRequest.Create(uri);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader streamReader = new StreamReader(stream);
                string json = streamReader.ReadToEnd();
            }
            RootObject root = JsonConvert.DeserializeObject(root);
        
            response.Close();

            txtSunrise.Text = root.results.sunrise;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cTimeDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        
    }
}
