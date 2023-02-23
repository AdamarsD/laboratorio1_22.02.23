using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace labo1._1
{

    class Program
    {
        static void Main(string[] args)
        {

            datos date = new datos();

            Console.Write("\n \n \n");
            Console.WriteLine(" INGRESE LOS DATOS QUE SE LE SOLICITAN ");
            Console.Write("\n");
            Console.WriteLine(" INGRESE SU NOMBRE COMPLETO ");
            date.nombre = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("INGRESE SU EDAD:");
            date.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine(" INGRESE EL DEPARTAMENTO EN EL QUE VIVE Y SU MUNICIPIO: \n");
            date.departamento = Console.ReadLine();
            Console.WriteLine("\n");

            var lista = new List<string>();
            List<string> list = new List<string>();
            foreach(var municipio in lista)
            {
                Console.WriteLine(municipio);
            }



            string[] municipiosChal = { "Agua Caliente", "Arcatao", "Azacualpa", "Chalatenango", "Citalá", "Comalapa", "Concepción Quezaltepeque", "Dulce Nombre de María", "El Carrizal  \n" };
            Console.WriteLine(" Municipios de Chalatenango:\n");
            foreach (string municipio in municipiosChal)
            {
                Console.WriteLine(municipio);
            }


            string[] municipiosAhu = { "Ahuachapán", "Atiquizaya", "Concepción de Ataco", "El Refugio", "Guaymango", "Jujutla", "San Francisco Menéndez", "San Lorenzo  \n" };
            Console.WriteLine("Municipio de Ahuachapan : \n");
            foreach (string municipio in municipiosAhu)
            {
                Console.WriteLine(municipio);
            }

            string[] municipiosCaba = { "Cabañas", "Cinquera", "Dolores", "Guacotecti", "Ilobasco", "Jutiapa", "San Isidro", "Sensuntepeque  \n" };
            Console.WriteLine("Municipios de Cabañas : \n");
            foreach (string municipio in municipiosCaba)
            {
                Console.WriteLine(municipio);
            }

            string[] municipiosCus = { "Cojutepeque", "El Carmen, El Rosario", "Monte San Juan", "Oratorio de Concepcion", "San Bartolome Perulapia", "San Cristobal", "San Jose Guayabal   \n" };
            Console.WriteLine("Municipios de Cuscatlan : \n");
            foreach (string municipio in municipiosCus)
            {
                Console.WriteLine(municipio);
            }

            string[] municipiosLib = { "La Libertad", "Antiguo Cuscatlán", "Chiltiupán", "Ciudad Arce", "Colón", "Comasagua", "Huizúcar", "Jayaque  \n" };
            Console.WriteLine("Municipios de La Libertad :  \n");
            foreach (string municipio in municipiosLib)
            {
                Console.WriteLine(municipio);
            }

            string[] municipiosLPaz = { "Cuyultitán", "El Rosario", "Jerusalén", "Mercedes La Ceiba", "Olocuilta", "Paraíso de Osorio", "San Antonio Masahuat", "San Emigdio \n" };
            Console.WriteLine("Municipios de La Paz : \n");
            foreach (string municipio in municipiosLPaz)
            {
                Console.WriteLine(municipio);
            }

           

        }

        public class datos
        {
            public string nombre;
            public int edad;
            public string departamento;
            public void agregar()
            {
               

                Console.Write("\n \n \n");
                Console.WriteLine(" INGRESE LOS DATOS QUE SE LE SOLICITAN ");
                Console.Write("\n");
                Console.WriteLine(" INGRESE SU NOMBRE COMPLETO ");
                Console.ReadKey();
            }

            public void lista()
            {
                string[] municipiosChal = { "Agua Caliente", "Arcatao", "Azacualpa", "Chalatenango", "Citalá", "Comalapa", "Concepción Quezaltepeque", "Dulce Nombre de María", "El Carrizal  \n" };
                Console.WriteLine(" Municipios de Chalatenango:\n");
                foreach (string municipio in municipiosChal)
                {
                    Console.WriteLine(municipio);
                }


                string[] municipiosAhu = { "Ahuachapán", "Atiquizaya", "Concepción de Ataco", "El Refugio", "Guaymango", "Jujutla", "San Francisco Menéndez", "San Lorenzo  \n" };
                Console.WriteLine("Municipio de Ahuachapan : \n");
                foreach (string municipio in municipiosAhu)
                {
                    Console.WriteLine(municipio);
                }

                string[] municipiosCaba = { "Cabañas", "Cinquera", "Dolores", "Guacotecti", "Ilobasco", "Jutiapa", "San Isidro", "Sensuntepeque  \n" };
                Console.WriteLine("Municipios de Cabañas : \n");
                foreach (string municipio in municipiosCaba)
                {
                    Console.WriteLine(municipio);
                }

                string[] municipiosCus = { "Cojutepeque", "El Carmen, El Rosario", "Monte San Juan", "Oratorio de Concepcion", "San Bartolome Perulapia", "San Cristobal", "San Jose Guayabal   \n" };
                Console.WriteLine("Municipios de Cuscatlan : \n");
                foreach (string municipio in municipiosCus)
                {
                    Console.WriteLine(municipio);
                }

                string[] municipiosLib = { "La Libertad", "Antiguo Cuscatlán", "Chiltiupán", "Ciudad Arce", "Colón", "Comasagua", "Huizúcar", "Jayaque  \n" };
                Console.WriteLine("Municipios de La Libertad :  \n");
                foreach (string municipio in municipiosLib)
                {
                    Console.WriteLine(municipio);
                }

                string[] municipiosLPaz = { "Cuyultitán", "El Rosario", "Jerusalén", "Mercedes La Ceiba", "Olocuilta", "Paraíso de Osorio", "San Antonio Masahuat", "San Emigdio \n" };
                Console.WriteLine("Municipios de La Paz : \n");
                foreach (string municipio in municipiosLPaz)
                {
                    Console.WriteLine(municipio);
                }

            }


        }

    }

}
