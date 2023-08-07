using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RIT_Automation
{
    public partial class Form1 : Form
    {
        private GMapMarker _selectedMarker; // Выбранный маркер пользователем
        List<Markers> markersRun = new List<Markers>();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Куницин Дмитрий Сергеевич";
            this.Load += Form1_Load;
            // подписка на события мышки 
            gMapControl2.MouseUp += _gMapControl_MouseUp;
            gMapControl2.MouseDown += _gMapControl_MouseDown;
            
        }
        private void _gMapControl_MouseDown(object sender, MouseEventArgs e)
        {
            //нахожу тот маркер на котором нажали клавишу мыши
            _selectedMarker = gMapControl2.Overlays
                .SelectMany(o => o.Markers)
                .FirstOrDefault(m => m.IsMouseOver == true);
            double Lat = 0;
            double Lng =0;
            // передаю координаты нажатого маркера
            if (_selectedMarker != null)
            {
                try
                {
                    switch (e.Button)
                    {
                            // Перемещение маркера на левую кнопку мыши 
                        case MouseButtons.Left:
                            Lat = _selectedMarker.Position.Lat;
                            Lng = _selectedMarker.Position.Lng;
                            markersRun = DataBase.Search_LatLng_Markers(Lat, Lng);
                            break;
                            // Удаление из бд маркера при нажатии на него правой кнопки мыши
                        case MouseButtons.Right:
                            Lat = _selectedMarker.Position.Lat;
                            Lng = _selectedMarker.Position.Lng;
                            markersRun = DataBase.Search_LatLng_Markers(Lat, Lng);
                            DataBase.Deleted_Selected_Marker(markersRun);
                            break;
                            }
                    }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
        private void _gMapControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (_selectedMarker is null)
                return;
            //перевожу координаты курсора мыши в долготу и широту на карте
            var latlng = gMapControl2.FromLocalToLatLng(e.X, e.Y);
            //присваивю новую позицию для маркера
            _selectedMarker.Position = latlng;
            int id = 0;
            foreach (Markers mark in markersRun)
            {
                id = mark.Id; break;
            }
            DataBase.Chancge_LatLng_Marker(id,latlng.Lat,latlng.Lng);
            labelLat.Text = Convert.ToString(latlng.Lat);
            labelLng.Text = Convert.ToString(latlng.Lng);
            _selectedMarker = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DataBase.Created_Data_Table_Markers();
            
            gMapControl2.Bearing = 0;
            gMapControl2.CanDragMap= true;
            gMapControl2.DragButton = MouseButtons.Left;
            gMapControl2.GrayScaleMode= true;
            gMapControl2.MarkersEnabled= true;
            gMapControl2.MaxZoom = 18;
            gMapControl2.MinZoom = 2;
            gMapControl2.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            gMapControl2.NegativeMode = false;
            gMapControl2.PolygonsEnabled = true;
            gMapControl2.RoutesEnabled= true;
            gMapControl2.ShowTileGridLines = false;
            gMapControl2.Zoom = 18;
            gMapControl2.Position = new PointLatLng(54.9746069, 82.9247925);
            gMapControl2.Dock= DockStyle.Fill;
            gMapControl2.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode =
                GMap.NET.AccessMode.ServerOnly;
            // Add Polygons
            GMapOverlay polygons = new GMapOverlay("polygons");
            // Вершины полигона
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(54.97437273425866, 82.9245070056296));
            points.Add(new PointLatLng(54.974485112815536, 82.92437155407546));
            points.Add(new PointLatLng(54.97497811229814, 82.92558123034038));
            points.Add(new PointLatLng(54.974868429098024, 82.92571534079002));
            GMapPolygon polygon = new GMapPolygon(points, "Работадатель");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polygons.Polygons.Add(polygon);
            this.gMapControl2.Overlays.Add(polygons);
            // Загружаю маркеры из базы данных и прогрузка их на карту
            GetMarkerMap.Install_MarkesG(gMapControl2);
        }
        private void buttonGreen_Click(object sender, EventArgs e)
        {
            // Создание нового маркера на центре карты(красный крестик)
            GMapOverlay markers = new GMapOverlay("markersG");
            GMapMarker marker = new GMarkerGoogle
                (new GMap.NET.PointLatLng(gMapControl2.Position.Lat,
                gMapControl2.Position.Lng)
                , GMarkerGoogleType.arrow);
            marker.ToolTip = new GMapRoundedToolTip(marker);
            marker.ToolTipText = "Car";
            marker.ToolTip.Fill = new SolidBrush(Color.FromArgb(200, Color.Black));
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.TextPadding = new Size(20 ,20);
            // Добавление маркера на карту
            markers.Markers.Add(marker);
            // Добавление в бд нового маркера
            DataBase.Insert_Markers_in_DataBase(gMapControl2.Position.Lat, gMapControl2.Position.Lng,marker.ToolTipText);
            // Добавление маркера на оверлей
            this.gMapControl2.Overlays.Add(markers);
            
        }
        private void buttonRed_Click(object sender, EventArgs e)
        {
            // Создание нового маркера на центре карты(красный крестик)
            GMapOverlay markers = new GMapOverlay("markersR");
            GMapMarker marker = new GMarkerGoogle
                (new GMap.NET.PointLatLng(gMapControl2.Position.Lat,
                gMapControl2.Position.Lng)
                , GMarkerGoogleType.red);
            marker.ToolTip = new GMapRoundedToolTip(marker);
            marker.ToolTipText = "People";
            // Добавление маркера на карту
            markers.Markers.Add(marker);
            // Добавление в бд нового маркера
            DataBase.Insert_Markers_in_DataBase(gMapControl2.Position.Lat, gMapControl2.Position.Lng, marker.ToolTipText);
            // Добавление маркера на оверлей
            this.gMapControl2.Overlays.Add(markers);
        }

        private void Map_Zoom_pic()
        {
            double CountZoom = gMapControl2.Zoom;
            textBox1.Text = CountZoom.ToString();
        }
    }
}
