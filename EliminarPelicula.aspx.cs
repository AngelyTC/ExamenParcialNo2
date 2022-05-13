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
    public partial class EliminarPelicula : System.Web.UI.Page
    {
        static List<Pelicula> borrarP = new List<Pelicula>();
        static List<Pelicula> peliIngreV = new List<Pelicula>();
        static string peliB;
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("ElencosPeli.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            borrarP = JsonConvert.DeserializeObject<List<Pelicula>>(json);
        }

        protected void GuardarBorrado()
        {
            string json = JsonConvert.SerializeObject(borrarP);
            string archivo = Server.MapPath("ElencosPeli.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            peliB = txtAño.Text;
            bool encontrar2 = false;

            foreach (var u in borrarP)
            {
               Pelicula  AlEditado = borrarP.Find(c => c.Año == peliB);

                if (AlEditado != null)
                {
                    txtTitulo.Text = AlEditado.TituloP;
                    txtGenero.Text = AlEditado.Genero;
                    txtEstudio.Text = AlEditado.Estudio;
                    encontrar2 = true;
                }
               
            }
            foreach (var u in borrarP)
            {
                Pelicula AlEditado = borrarP.Find(c => c.Año == peliB);

                if (AlEditado != null)
                {
                    Pelicula ver = new Pelicula();
                    ver.TituloP = AlEditado.TituloP;
                    ver.Año = AlEditado.Año;
                    ver.Genero = AlEditado.Genero;
                    ver.Estudio = AlEditado.Estudio;

                    peliIngreV.Add(ver);

                    GridView1.DataSource = peliIngreV;
                    GridView1.DataBind();

                    peliIngreV.Clear();
                    encontrar2 = true;
                }

            }

            if (!encontrar2)
            {
                Response.Write("<script>alert('El año no se ha encotrado')</script>");
                peliB = "";
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (var u in borrarP)
            {
                Pelicula alumnoEliminado = borrarP.Find(c => c.Año == peliB);

                if (alumnoEliminado != null)
                {
                    borrarP.Remove(alumnoEliminado);
                    break;
                }

            }
            GuardarBorrado();
        }
    }
}