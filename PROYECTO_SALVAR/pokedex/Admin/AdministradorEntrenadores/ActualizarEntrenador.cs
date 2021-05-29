using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace pokedex
{
    public partial class ActualizarEntrenador : Form
    {
        Controlador.controladorEntrenadores controladorEntrenadores = new Controlador.controladorEntrenadores();
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInicial = 9.9262422798561;
        double LongInicial = -84.0921020507813;
        public ActualizarEntrenador(string idE)
        {
            InitializeComponent();
            errorUser.Hide();
            labelErrorDatos.Hide();
            successLabel.Hide();
            id.Text = idE;
            id.ReadOnly = true;
        }

        private void labelErrorDatos_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarEntrenador_Load(object sender, EventArgs e)
        {
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.CanDragMap = true;
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 9;
            gMapControl.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud {1}", LatInicial, LongInicial);

            gMapControl.Overlays.Add(markerOverlay);
        }

        private void gMapControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;

            longitud.Text = lng.ToString();
            latitud.Text = lat.ToString();
            marker.Position = new PointLatLng(Convert.ToDouble(latitud.Text), Convert.ToDouble(longitud.Text));
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(telefono.Text == "")
            {
                telefono.Text = "0";
            }
            if(controladorEntrenadores.ActualizarEntrenador(nombre.Text, apellido1.Text, apellido2.Text, Int32.Parse(telefono.Text), provincia.Text,
                canton.Text,distrito.Text,correo.Text, id.Text,otras.Text,webSite.Text,latitud.Text,longitud.Text,facebook.Text,instragram.Text,
                twitter.Text))
            {
                errorUser.Hide();
                labelErrorDatos.Hide();
                successLabel.Show();
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        c.ResetText();
                    }
                }
            }
            else
            {
                successLabel.Hide();
                labelErrorDatos.Show();
            }
        }
    }
}
