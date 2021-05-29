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
    public partial class registroEntrenador : Form
    {
        Controlador.controladorUsuarios controladorInicio = new Controlador.controladorUsuarios();
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInicial = 9.9262422798561;
        double LongInicial = -84.0921020507813;
        public registroEntrenador()
        {
            InitializeComponent();
            labelErrorDatos.Hide();
            errorUser.Hide();
            errorTel.Hide();

        }
        private bool TieneChar(string str)
        {
#pragma warning disable CS0162 // Unreachable code detected
            for (int i = 0; i < str.Length; i++)
#pragma warning restore CS0162 // Unreachable code detected
            {
                if (Char.IsLetter(str, i))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (TieneChar(telefono.Text)){
                errorTel.Show();
            }
            else if (user.Text != "" && password.Text != "" && nombre.Text != "" && apellido1.Text != "" &&
                apellido2.Text != "" && telefono.Text != "" && provincia.Text != "" && canton.Text != "" && distrito.Text != ""
                 && correo.Text != "" && id.Text != "")//revisa que los datos necesarios sean ingresados
            {
                errorTel.Hide();
                if (controladorInicio.RegistroEntrenador(user.Text, password.Text, "Entrenador", nombre.Text, apellido1.Text, apellido2.Text, Int32.Parse(telefono.Text),
                provincia.Text, canton.Text, distrito.Text, correo.Text, id.Text, otras.Text, webSite.Text, latitud.Text, longitud.Text, facebook.Text, instragram.Text, twitter.Text))
                {
                    errorUser.Hide();
                    foreach(Control c in Controls)
                    {
                        if(c is TextBox)
                        {
                            c.ResetText();
                        }
                    }
                }
                else
                {
                    errorUser.Show();
                }

            }
            else
            {
                labelErrorDatos.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            ActiveForm.Hide();
        }

        private void registroEntrenador_Load(object sender, EventArgs e)
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

        private void gMapControl_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;

            int late = Convert.ToInt32(lat);
            int lnge = Convert.ToInt32(lng);
            longitud.Text = lnge.ToString();
            latitud.Text = late.ToString();
            marker.Position = new PointLatLng(lat, lng);
        }
    }
}
