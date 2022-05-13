using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcialNo2
{
    public class Pelicula
    {
        public string TituloP { get; set; }
        public string Año { get; set; }
        public string Genero { get; set; }
        public string Estudio { get; set; }
        public List<ActoresP> elenco { get; set; }
    }
}