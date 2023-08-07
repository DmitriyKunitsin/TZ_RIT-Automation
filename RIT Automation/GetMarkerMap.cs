using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.MapProviders;

namespace RIT_Automation
{
    internal class GetMarkerMap
    {
        public static void Install_MarkesG(GMapControl gMapControl2)
        {
            double Lat = 0;
            double Lng = 0;
            string Text = string.Empty;
            
           var Installmarkers = DataBase.Unload_Existing_Markers();
            foreach(Markers mark in Installmarkers)
            {
                Lat = mark.lat;
                Lng = mark.lng;
                Text = mark.text;
                if (Text == "Car")
                {
                    GMapOverlay markers = new GMapOverlay("markersG");
                    GMapMarker marker = new GMarkerGoogle
                        (new GMap.NET.PointLatLng(Lat, Lng)
                        , GMarkerGoogleType.arrow);
                    marker.ToolTip = new GMapRoundedToolTip(marker);
                    marker.ToolTipText = Text;
                    marker.ToolTip.Fill = new SolidBrush(Color.FromArgb(200, Color.Black));
                    marker.ToolTip.Foreground = Brushes.White;
                    marker.ToolTip.TextPadding = new Size(20, 20);
                    markers.Markers.Add(marker);
                    gMapControl2.Overlays.Add(markers);
                }
                else 
                {
                    // Создание нового маркера на центре карты(красный крестик)
                    GMapOverlay markers = new GMapOverlay("markersR");
                    GMapMarker marker = new GMarkerGoogle
                        (new GMap.NET.PointLatLng(Lat,Lng)
                        , GMarkerGoogleType.red);
                    marker.ToolTip = new GMapRoundedToolTip(marker);
                    marker.ToolTipText = "People";
                    // Добавление маркера на карту
                    markers.Markers.Add(marker);
                    // Добавление маркера на оверлей
                    gMapControl2.Overlays.Add(markers);
                }
                
            }
        }
    }
}
