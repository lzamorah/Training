//2.Comentnarios Descriptivos
//3.Nombres de funciones que explican lo que hace la funcion
//4.Nombres de variables isgnificativas


using System;
using System.Collections.Generic;

namespace ProyectoD1
{
    //Clase Singleton que guarda la configuracion del sistema.
    //Para acceder a la instancia se llama al metodo Instancia()
    //Que devuelve un objeto tipo Configuracion.
    //Este objeto se puede modificar con los metodos set y get.
    class Configuracion
    {
        private static Configuracion configuracion;
        private List<InterfaceFormato> formatos; 
        private List<InterfazAlgoritmo> algoritmos;
		private Alfabeto alfabeto;
        private string metodo;


        //Genero el nuevo alfabeto(que tiene al default)
        //Inicializo la lista de algoritmos
        //Inicializo la lista de formatos
        //Inicializa la lista 
        private Configuracion() 
		{
			alfabeto = new Alfabeto();                  
			algoritmos = new List<InterfazAlgoritmo>(); 
			formatos = new List<InterfaceFormato>();
            metodo = "";

		}

       
        public static Configuracion getConfiguracion()
        {
            if (configuracion == null)
            {
                configuracion = new Configuracion();
            }
            return configuracion;
        }

        public void elegirMetodo(string opcion)
        {
            metodo = opcion;
        }

		public void elegirAlgoritmo(string opcion)
		{	string vigenere = "Vigenere";
			string transposicion = "Transposicion";
			string codificacionBinaria = "Binario";
			string palabraClave = "Palabra Clave";
			if (opcion.Equals(vigenere))
			{
				anadirAlgoritmoALista(Vigenere.getVigenere());
			}
			else if (opcion.Equals(transposicion))
			{

				anadirAlgoritmoALista(Transposicion.getTransposicion());
			}
			else if (opcion.Equals(codificacionBinaria))
			{

				anadirAlgoritmoALista(CodificacionBinaria.getCodificacionBinaria());
			}
			else if (opcion.Equals(palabraClave))
			{
				anadirAlgoritmoALista(PalabraClave.getPalabraClave());
			}
			else 
			{
				anadirTodoAlgoritmo();
			}
		}

		void anadirAlgoritmoALista(InterfazAlgoritmo pAlgoritmo)
		{ 
			algoritmos.Clear();
			algoritmos.Add(pAlgoritmo);
		}

		void anadirTodoAlgoritmo()
		{ 
			algoritmos.Clear();
			algoritmos.Add(Vigenere.getVigenere());
			algoritmos.Add(Transposicion.getTransposicion());
			algoritmos.Add(CodificacionBinaria.getCodificacionBinaria());
			algoritmos.Add(PalabraClave.getPalabraClave());

		}
		public void elegirFormato(string opcion)
		{
			string txt = "Txt";
			string pdf = "PDF";
			string xml = "XML";

			if (opcion.Equals(txt))
			{

				anadirFormatoALista(TXT.getTxt());

			}
			else if (opcion.Equals(pdf))
			{

				anadirFormatoALista(PDF.getPDF());
			}
			else if (opcion.Equals(xml))
			{

				anadirFormatoALista(XML.getxml());
			}
			else 
			{ 
			
			}
		}

		void anadirFormatoALista(InterfaceFormato pFormato)
		{
			formatos.Clear();
			formatos.Add(pFormato);
		}

		public void anadirTodoFormato()
		{ 
			formatos.Clear();
			formatos.Add(TXT.getTxt());
			formatos.Add(PDF.getPDF());
			formatos.Add(XML.getxml());
		}
		
        public List<InterfaceFormato> getFormato()
        {
            return formatos;
        }
        

        public List<InterfazAlgoritmo> getAlgoritmo()
        {
            return algoritmos;
        }

        public String getMetodo()
        {
            return metodo;
        }

        public Alfabeto getAlfabeto()
        {
            return alfabeto;
        }
    }
}
