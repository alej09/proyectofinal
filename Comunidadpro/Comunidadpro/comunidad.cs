using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidadpro
{
    public class comunidad
    {
        string identificación;
        string nombre;
        string poblacion;

        public string Identificación
        {
            get
            {
                return identificación;
            }

            set
            {
                identificación = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Poblacion
        {
            get
            {
                return poblacion;
            }

            set
            {
                poblacion = value;
            }
        }
    }
}