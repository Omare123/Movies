using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Models.Dominio
{
    public class Pelicula : Entidad
    {
        public Pelicula()
        {
        }

        public Pelicula(DateTime fechaestreno, int duracion, string genero) {

            FechaEstreno = fechaestreno;
            Duracion = duracion;
            Genero = genero;
        }

        public DateTime FechaEstreno { get; set; }
        public int Duracion { get; set; }
        public string Genero { get; set; }

    }
}