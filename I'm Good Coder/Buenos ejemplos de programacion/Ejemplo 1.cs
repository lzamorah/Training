//1. Responsabilidad unica de la clase
//2. Funciones pequeñas con un único objetivo


using System.IO;

//Clase: TXT 
//Encargada de crear un archivo  TXT, si ya existe escribe en el mismo (Singleton)
namespace ProyectoD1
{
    class TXT : InterfaceFormato
    {
		private StreamWriter archivoTXT;
		private static TXT txt = null;

        public static TXT getTxt()
		{

			if (txt == null)
			{
				txt = new TXT();
			}	
			return txt;
		}
		
		public void escribirEnArchivo(string pTitulo, string pParrafo)
		{
			archivoTXT.WriteLine(pTitulo+": "+pParrafo+"\n");
		}

		public void cerrarArchivo()
		{ 
			archivoTXT.Close();
		}        
        
        public void transformarAArchivo(string pFecha, string pMetodo, string pFraseOriginal, string pNombreAlgoritmo, string pResultado)
        {
            
			archivoTXT = new StreamWriter("C:\\Users\\LuciaZ\\Desktop\\II Semestre  - 2016\\Diseño\\I Proyecto\\Resultados\\Resp1.txt", true);
            
			escribirEnArchivo("fechaCifrado", pFecha);
			escribirEnArchivo("metodo", pMetodo);
			escribirEnArchivo("fraseOriginal", pFraseOriginal);
			escribirEnArchivo("nombreAlgoritmo", pNombreAlgoritmo);
			escribirEnArchivo("resultado", pResultado);
 
            cerrarArchivo();

			
        }
    }
}
