using Gmap.net;
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

namespace TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var map = new GoogleMapApi(true);
            var location = new Location(54.9816378, 82.8971373);
            var pic = new PictureBox();
            //MemoryStream stream = new MemoryStream(Convert.ToInt32(map));
            //pic.Image = Image.FromStream(stream);
            //string urlmaps = "http://maps.googleapis.com/maps/api/staticmap?center=43.56,4.48&size=600x600&sensor=true&format=png&maptype=roadmap&zoom=10";
            //string urlmaps = "https://www.google.ru/maps/@54.9816378,82.8971373,16.03z?entry=ttu";
            //var request = WebRequest.Create("https://w.forfun.com/fetch/f1/f1ea8ae2e3a05e675f937fc177626474.jpeg");

            //using (var response = request.GetResponse())
            //using (var stream = response.GetResponseStream())
            //{
            //    pictureBox1.Image = Bitmap.FromStream(stream);
            //}
            map.SetLocation(location);
            
            //pictureBox1.ImageLocation = Image.FromStream(map);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
