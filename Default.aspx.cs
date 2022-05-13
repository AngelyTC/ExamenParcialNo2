using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace ExamenParcialNo2
{
    public partial class _Default : Page
    {
        static List<Pelicula> peliA= new List<Pelicula>();
        static List<ActoresP> elencos1= new List<ActoresP>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private void GuardarElenco()
        {
            string json = JsonConvert.SerializeObject(peliA);

            string archivo = Server.MapPath("ElencosPeli.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        protected void btnElenco_Click(object sender, EventArgs e)
        {
            ActoresP ingresoA= new ActoresP();
            ingresoA.nombreA = txtActores.Text;
            ingresoA.FechaA = CalendarFecha.SelectedDate;

            elencos1.Add(ingresoA);

            GridView1.DataSource = elencos1;
            GridView1.DataBind();
        }

        protected void btnIngresoP_Click(object sender, EventArgs e)
        {
            Pelicula ingresoP = new Pelicula();
            ingresoP.TituloP= txtTitulo.Text;
            ingresoP.Año = txtAño.Text;
            ingresoP.Genero  = txtGenero.Text;
            ingresoP.Estudio = txtEstudio.Text;
            ingresoP.elenco = elencos1.ToArray().ToList();

            peliA.Add(ingresoP);
            GuardarElenco();

            elencos1.Clear();
        }
    }
}