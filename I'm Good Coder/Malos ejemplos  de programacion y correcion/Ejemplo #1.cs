//Mala Practica 

//En el siguiente ejemplo se pueden encontrar los siguientes puntos:
//1. Falta de comentarios que describan la funcionalidad 
//2. Nombres poco significativos que no describen lo que hacen

using System.Xml;


namespace ProyectoD1
{
    class XML :InterfaceFormato
    {
		
		private XmlDocument doc;
		private XmlElement raiz;
        private XmlElement codi;
		private static XML xml = null;
   
		private static int contador = 1;

		public static XML getxml()
		{
			if (xml == null)
			{
				xml = new XML();
			}
			return xml;
		}
		private XML()
		{
            
            doc = new XmlDocument();
            raiz = doc.CreateElement("Programa");
            doc.AppendChild(raiz);
            contador++;
		}

		public void crearRaiz(string pCodificacion)
		{/*
            raiz = doc.CreateElement("Programa");
            doc.AppendChild(raiz);
            codificacion = doc.CreateElement(pCodificacion);
			raiz.AppendChild(codificacion);
            */
		}

		public void bloque(string titulo, string parrafo)
		{ 
			XmlElement resul = doc.CreateElement(titulo);
            resul.AppendChild(doc.CreateTextNode(parrafo));
            codi.AppendChild(resul);
		}


        public void transformarAArchivo(string fecha, string metodo,string frase, string nombre, string resultado)
		{

            codi = doc.CreateElement("codificacion");
            raiz.AppendChild(codi);

            bloque("fechaCifrado", fecha);
            bloque("estado", metodo);
            bloque("fraseOriginal", frase);
            bloque("nombreAlgoritmo", nombre);
            bloque("resultado",resultado);
			
            doc.Save("C:\\Users\\LuciaZ\\Desktop\\II Semestre  - 2016\\Diseño\\I Proyecto\\Resultados\\ResulXML.xml");
        }

    }
}

//-----------------------------------------------------------------------------------------------

//Buena Practica


//---Cambios realizados
//1. Comentarios significativos.
//2. Nombres significativos de funciones que expresan exactamente lo que hacen.
//3. Nombres significativos de Variables que expresan para lo que son.

//--Buenas practicas
//4. Responsabilidad unica de la clase.
//5. Funciones pequeñas y fáciles de entender.

using System.Xml;

//Clase XML
//Encargada de la creación de un solo archivo XML.
namespace ProyectoD1
{
    class XML :InterfaceFormato
    {
		
		private XmlDocument doc;
		private XmlElement raiz;
		private XmlElement codificacion;
		private static XML xml = null;
   
		private static int contador = 1;

		public static XML getxml()
		{
			if (xml == null)
			{
				xml = new XML();
			}
			return xml;
		}

		private XML()
		{
            
            doc = new XmlDocument();
            raiz = doc.CreateElement("Programa");
            doc.AppendChild(raiz);
            contador++;
		}

		public void crearRaiz(string pCodificacion)
		{}

		public void crearBloque(string titulo, string parrafo)
		{ 
			XmlElement resultado = doc.CreateElement(titulo);
			resultado.AppendChild(doc.CreateTextNode(parrafo));
			codificacion.AppendChild(resultado);
		}


        public void transformarAArchivo(string pFecha, string pMetodo,string pFraseOriginal, string pNombreAlgoritmo, string pResultado)
		{

            codificacion = doc.CreateElement("codificacion");
            raiz.AppendChild(codificacion);
                        
            crearBloque("fechaCifrado",pFecha);
			crearBloque("estado",pMetodo);
			crearBloque("fraseOriginal",pFraseOriginal);
			crearBloque("nombreAlgoritmo",pNombreAlgoritmo);
			crearBloque("resultado",pResultado);
			
            doc.Save("C:\\Users\\LuciaZ\\Desktop\\II Semestre  - 2016\\Diseño\\I Proyecto\\Resultados\\ResulXML.xml");
        }

    }
}

