using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidadpro
{
    public class localcomercial:propiedades 

    {
        string nombrecomercia;
        string actividad;

        public string Nombrecomercia
        {
            get
            {
                return nombrecomercia;
            }

            set
            {
                nombrecomercia = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}