//Mala forma de programacion


using System;
using System.Collections.Generic;

namespace ProyectoD1
{
class PalabraClave : InterfazAlgoritmo
	{
		private DateTime fechaCifrado { get; set; }
		private bool estado { get; set; }
		private string fraseOriginal { get; set; }
		private string resultado { get; set; }
		private static string nombreAlgoritmo { get; set; }
		private string clave;
		private static PalabraClave palabraClave = null;

		public static PalabraClave getPalabraClave()
		{
			if (palabraClave == null)
			{
				palabraClave = new PalabraClave();
			}
			return palabraClave;
		}
		

		private PalabraClave()
		{
			clave = "tango";
			//fraseOriginal = pFraseOriginal;
			fechaCifrado = DateTime.Now;
			estado = false;
			nombreAlgoritmo = "Palabra Clave";
			//fraseOriginal = pFraseOriginal;
			resultado = "";
		}


		public string codificarPalabra(String palabra, string operacion)
		{
			List<String> alfabeto = new List<String>(new String[]{"a","b","c","d","e","f", "g","h","i","j","k","l",
				"m","n","o","p","q","r","s","t","u","v","w","x","y","z"});

			string resul = "";
			int contador = 0;
			int contadorClave = 0;
			while (contador <= palabra.Length)
			{
				while (contadorClave < clave.Length)
				{

					if (contador > palabra.Length - 1)
					{
						break;
					}
					//Console.WriteLine(palabra[contador]);

					if (palabra[contador].Equals(' '))
					{
						break;
					}
					else {
						string preCaracter = palabra[contador] + "";
						string preClave = clave[contadorClave] + "";
						int valorCaracter = 0;
						if (operacion.Equals("sumar"))
						{
							valorCaracter = alfabeto.IndexOf(preCaracter) + alfabeto.IndexOf(preClave) + 2;

						}
						else
						{
							valorCaracter = alfabeto.IndexOf(preCaracter) - alfabeto.IndexOf(preClave);

						}
						if (valorCaracter > alfabeto.Count)
						{
							valorCaracter -= alfabeto.Count;

						}
						else if (valorCaracter < 0)
						{

							valorCaracter += alfabeto.Count;
						}
						string preRespuesta = alfabeto[valorCaracter - 1];
						resul += preRespuesta;
					}
					contadorClave++;
					contador++;
				}

				contadorClave = 0;
				if (contador > palabra.Length - 1)
				{
					break;
				}

			}
			return resul;
		}


		public string preCodificar(string operacion, string identificador)
		{
			//cada 
			string[] arregloFrase = identificador.Split(' ');
			int contadorPalabra = arregloFrase.Length;
			int contadorCiclo = 0;
			string resul = "";
			while (contadorCiclo < contadorPalabra)
			{
				//Console.WriteLine(arregloFras);
				resul += codificarPalabra(arregloFrase[contadorCiclo], operacion);
				resul += " ";
				contadorCiclo++;
			}
			return resul;
		}


		public void codificar(String pFrase)
		{
			resultado = preCodificar("sumar",pFrase);


		}
		public void decodificar(String pFrase)
		{
			resultado = preCodificar("restar", pFrase);
		}

        public String getResultado()
        {
            return resultado;
        }

        public DateTime getfecha()
        {
            return fechaCifrado;
        }

        public string getFraseOriginal()
        {
            return fraseOriginal;
        }

        public string getNombreAlgoritmo()
        {
            return nombreAlgoritmo;
        }
        public void setPalabraClave(string pClave)
        {
            clave = pClave;
        }

       
    }
    
}

//----------------------------------------------------------------------------
//Buena forma de programacion
//
//1. Metodos cortos y facil de entender
//2. Cometarios significativos
//3. Variables y funciones con nombres significativos

using System;
using System.Collections.Generic;

namespace ProyectoD1
{

//Clase encargada de realizar la codificación por palabra clave
//Existe una palabra clave que se puede cambiar, es la utilizada para realizar el cambio
class PalabraClave : InterfazAlgoritmo
	{
		private DateTime fechaCifrado { get; set; }
		private bool estado { get; set; }
		private string fraseOriginal { get; set; }
		private string resultado { get; set; }
		private static string nombreAlgoritmo { get; set; }
		private string clave;

		//Singleton, se declara la variable estática como nula , para luego verificar si fue declarada
		private static PalabraClave palabraClave = null;

		//Metodo singleton solo existe una instancia de esta clase
		public static PalabraClave getPalabraClave()
		{
			if (palabraClave == null)
			{
				palabraClave = new PalabraClave();
			}
			return palabraClave;
		}

		//Método constructor es privado para solo ser accedido desde la clase
		private PalabraClave()
		{
			clave = "tango";
			fechaCifrado = DateTime.Now;
			estado = false;
			nombreAlgoritmo = "Palabra Clave";
			resultado = "";
		}

        //Se toma la palabra clave
        //Se cuenta con una lista con el alfabeto
        //La palabra clave es la base para  obtener la codificación
        //Segun la cantidad de letras que tenga esta
		public string codificarPalabra(String palabra, string operacion)
		{
			List<String> alfabeto = new List<String>(new String[]{"a","b","c","d","e","f", "g","h","i","j","k","l",
				"m","n","o","p","q","r","s","t","u","v","w","x","y","z"});

			string resul = "";
			int contadorPalabra = 0;
			int contadorPalabraClave = 0;
			while (contadorPalabra <= palabra.Length)
			{
				while (contadorPalabraClave < clave.Length)
				{

					if (contadorPalabra > palabra.Length - 1)
					{
						break;
					}

					if (palabra[contadorPalabra].Equals(' '))
					{
						break;
					}
					else {
						string preCaracter = palabra[contadorPalabra] + "";
						string preClave = clave[contadorPalabraClave] + "";
						int valorCaracter = 0;
						//Comparar operacion
						if (operacion.Equals("sumar"))
						{
							valorCaracter = alfabeto.IndexOf(preCaracter) + alfabeto.IndexOf(preClave) + 2;
						} else {
							valorCaracter = alfabeto.IndexOf(preCaracter) - alfabeto.IndexOf(preClave);
						}

						if (valorCaracter > alfabeto.Count)
						{
							valorCaracter -= alfabeto.Count;
						}
						if (valorCaracter < 0)
						{
							valorCaracter += alfabeto.Count;
						}
						string preRespuesta = alfabeto[valorCaracter - 1];
						resul += preRespuesta;
					}
                    contadorPalabraClave++;
                    contadorPalabra++;
				}

                contadorPalabraClave = 0;
				if (contadorPalabra > palabra.Length - 1)
				{
					break;
				}

			}
			return resul;
		}



		public string preCodificar(string operacion, string identificador)
		{
			
			string[] arregloFrase = identificador.Split(' ');
			int contadorPalabra = arregloFrase.Length;
			int contadorCiclo = 0;
			string resul = "";
            
			while (contadorCiclo < contadorPalabra)
			{
				
				resul += codificarPalabra(arregloFrase[contadorCiclo], operacion);
				resul += " ";
				contadorCiclo++;
			}
			return resul;
		}


		public void codificar(String pFrase)
		{
			resultado = preCodificar("sumar",pFrase);


		}
		public void decodificar(String pFrase)
		{
			resultado = preCodificar("restar", pFrase);
		}

        public String getResultado()
        {
            return resultado;
        }

        public DateTime getfecha()
        {
            return fechaCifrado;
        }

        public string getFraseOriginal()
        {
            return fraseOriginal;
        }

        public string getNombreAlgoritmo()
        {
            return nombreAlgoritmo;
        }
        public void setPalabraClave(string pClave)
        {
            clave = pClave;
        }

        
        
    }
    
}
