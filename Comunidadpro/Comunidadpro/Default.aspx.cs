using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comunidadpro
{
    public partial class _Default : Page
    {
        List<comunidad> listacomunidad = new List<comunidad>();
        List<propiedades> Listapropietarios = new List<propiedades>();
        List<datosdepropietarios> listadatospro = new List<datosdepropietarios>();
        List<garaje> listagaraje = new List<garaje>();
        List<gastos> listagastos = new List<gastos>();
        List<gastossalida> listagastossalid = new List<gastossalida>();
        List<localcomercial> listalocalcomercial = new List<localcomercial>();
        List<piso> listapisos = new List<piso>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}