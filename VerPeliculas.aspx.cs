using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace ExamenParcialNo2
{
    public partial class VerPeliculas : System.Web.UI.Page
    {
        static List<Pelicula> peliA = new List<Pelicula>();
        static List<Pelicula> peliIngreV = new List<Pelicula>();
        static string añoP;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("ElencosPeli.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            peliA = JsonConvert.DeserializeObject<List<Pelicula>>(json);
        }

        protected void btnBuscarP_Click(object sender, EventArgs e)
        {
            añoP = txtAño.Text;
            bool encontrar = false;

            foreach (var u in peliA)
            {
                Pelicula AlEditado = peliA.Find(c => c.Año == añoP);

                if (AlEditado != null)
                {
                   Pelicula ver = new Pelicula();
                    ver.TituloP = AlEditado.TituloP;

                    peliIngreV.Add(ver);

                    GridView1.DataSource = peliIngreV;
                    GridView1.DataBind();
                    txtVer.Text = ver.TituloP;
                    peliIngreV.Clear();
                    encontrar = true;
                }

            }

            if (!encontrar)
            {
                Response.Write("<script>alert('El año no se ha encotrado')</script>");
                añoP = "";

            }
        }
    }
}