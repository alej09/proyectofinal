﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.IO;

namespace Comunidadpro
{
    public partial class _Default : Page
    {
        List<comunidad> listacomunidad = new List<comunidad>();
        List<propiedades> Listapropietarios = new List<propiedades>();
        List<datosdepropietarios> listadatospro = new List<datosdepropietarios>();
        List<garaje> listagaraje = new List<garaje>();
        List<gastos> listagastos = new List<gastos>();
        List<gastossalida> listagastossalida = new List<gastossalida>();
        List<localcomercial> listalocalcomercial = new List<localcomercial>();
        List<piso> listapisos = new List<piso>();

        public void cargar(bool comuni, bool gas, bool daspro, bool gassalida, bool pro)
        {
            if (comuni == true)
            {
            Assembly _assembly; Stream _imageStream;
            StreamReader _textStreamReader;
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("Comunidadpro.comunidad.bmp");
            _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Comunidadpro.comunidad.txt"));

            while (_textStreamReader.Peek() > -1)
            {
                comunidad comtemp = new comunidad();
                comtemp.Identificacion = _textStreamReader.ReadLine();
                comtemp.Nombre = _textStreamReader.ReadLine();
                comtemp.Poblacion  = _textStreamReader.ReadLine();
                listacomunidad.Add(comtemp);
            }
            _textStreamReader.Close();
        }
            if (gas == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Comunidadpro.gastos.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Comunidadpro.gastos.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    gastos gastostemp = new gastos();
                    gastostemp.Identificacion = _textStreamReader.ReadLine();
                    gastostemp.Nombre = _textStreamReader.ReadLine();
                    gastostemp.Tipodereparto = _textStreamReader.ReadLine();
                    listagastos.Add(gastostemp);
                }
                _textStreamReader.Close();
            }
            if (daspro == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Comunidadpro.datosdepropietarios.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Comunidadpro.datosdepropietarios.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    datosdepropietarios dasprotemp = new datosdepropietarios();
                    dasprotemp.Nombre = _textStreamReader.ReadLine();
                    dasprotemp.Nit = _textStreamReader.ReadLine();
                    dasprotemp.Email = _textStreamReader.ReadLine();
                    listadatospro.Add(dasprotemp);
                }
                _textStreamReader.Close();
            }
            if (gassalida == true )
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Comunidadpro.gastossalida.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Comunidadpro.gastossalida.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    gastossalida gassalidatemp = new gastossalida();
                    gassalidatemp.Idgasto = _textStreamReader.ReadLine();
                    gassalidatemp.Descripcion = _textStreamReader.ReadLine();
                    gassalidatemp.Importe = Convert.ToInt32(_textStreamReader.ReadLine());
                    gassalidatemp.Tipodezonadereparto = _textStreamReader.ReadLine();
                    listagastossalida.Add(gassalidatemp);
                }
                _textStreamReader.Close();
            }
            if (pro == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Comunidadpro.propiedades.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Comunidadpro.propiedades.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    
                    if (_textStreamReader.ReadLine()=="L")
                    {
                        localcomercial locacomertemp = new localcomercial();
                    }
                    if (_textStreamReader.ReadLine() == "G")
                    {
                        garaje garatemp = new garaje();
                    }
                    if (_textStreamReader.ReadLine() == "P")
                    {
                        piso pistemp = new piso();
                    }
                }
                _textStreamReader.Close();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}