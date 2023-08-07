using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RIT_Automation
{
    internal class Markers
    {
        public int Id { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string text { get; set; }

        //public double Lat
        //{
        //    get { return lat; }
        //    set { lat = value; }
        //}
        //public double Lng 
        //{ 
        //    get { return lng; } 
        //    set { lng = value;} 
        //}
        //public string Text 
        //{ 
        //    get { return text; } 
        //    set { text = value; } 
        //}
        public Markers() 
        { 
            this.Id = 0;
            this.lat = 0;
            this.lng = 0;
            this.text = string.Empty;
        }
    }
}
