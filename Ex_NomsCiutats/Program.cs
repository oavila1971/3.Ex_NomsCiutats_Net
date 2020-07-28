using System;

namespace Ex_NomsCiutats
{
    class Program
    {
        static void Main(string[] args)
        {
            // FASE 1:

            Console.WriteLine("FASE 1:\n");


            string ciutat1;
            string ciutat2;
            string ciutat3;
            string ciutat4;
            string ciutat5;
            string ciutat6;

            Console.WriteLine("Introdueix el nom de la 1ª ciutat (Barcelona): ");
            ciutat1 = Console.ReadLine();

            Console.WriteLine("\nIntrodueix el nom de la 2ª ciutat (Madrid): ");
            ciutat2 = Console.ReadLine();

            Console.WriteLine("\nIntrodueix el nom de la 3ª ciutat (Valencia): ");
            ciutat3 = Console.ReadLine();

            Console.WriteLine("\nIntrodueix el nom de la 4ª ciutat (Màlaga): ");
            ciutat4 = Console.ReadLine();

            Console.WriteLine("\nIntrodueix el nom de la 5ª ciutat (Cadis): ");
            ciutat5 = Console.ReadLine();

            Console.WriteLine("\nIntrodueix el nom de la 6ª ciutat (Santander): ");
            ciutat6 = Console.ReadLine();

            Console.WriteLine("\nCiutats: {0}, {1}, {2}, {3}, {4}, {5}", ciutat1,ciutat2,ciutat3,ciutat4,ciutat5,ciutat6);

            // FASE 2:

            Console.WriteLine("\nFASE 2:\n");

            string[] arrayCiutats = new string[6];

            arrayCiutats[0] = ciutat1;
            arrayCiutats[1] = ciutat2;
            arrayCiutats[2] = ciutat3;
            arrayCiutats[3] = ciutat4;
            arrayCiutats[4] = ciutat5;
            arrayCiutats[5] = ciutat6;

            Array.Sort(arrayCiutats); // Referència: https://stackoverrun.com/es/q/1764195

            Console.WriteLine("\nCiutats ordenades alfabèticament:\n");

            for (int i = 0; i < arrayCiutats.Length; i++)
            {                
                Console.WriteLine(arrayCiutats[i]);
            }

            // FASE 3:

            Console.WriteLine("\nFASE 3:\n");

            string[] arrayCiutatsModificades = new string[6];
            string cadena;

            Console.WriteLine("\nCiutats modificades i ordenades alfabèticament:\n");

            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                cadena = arrayCiutats[i];
                cadena = cadena.Replace("a", "4");      // Referencia: https://docs.microsoft.com/es-es/dotnet/csharp/how-to/modify-string-contents
                arrayCiutatsModificades[i] = cadena;
                Console.WriteLine(cadena);
                
            }

            //Array.Sort(arrayCiutatsModificades);

            //Console.WriteLine("\nCiutats modificades i ordenades alfabèticament:\n");

            /*for (int i = 0; i < arrayCiutatsModificades.Length; i++)
            {
                Console.WriteLine(arrayCiutatsModificades[i]);
            }*/

            // FASE 4:

            Console.WriteLine("\nFASE 4:\n");

            char[] arrayCiutat1 = new char[ciutat1.Length];
            char[] arrayCiutat2 = new char[ciutat2.Length];
            char[] arrayCiutat3 = new char[ciutat3.Length];
            char[] arrayCiutat4 = new char[ciutat4.Length];
            char[] arrayCiutat5 = new char[ciutat5.Length];
            char[] arrayCiutat6 = new char[ciutat6.Length];

            arrayCiutat1 = ciutat1.ToCharArray(); // Referència: http://lineadecodigo.com/java/convertir-una-cadena-en-un-array-de-caracteres-con-java/
            arrayCiutat2 = ciutat2.ToCharArray();
            arrayCiutat3 = ciutat3.ToCharArray();
            arrayCiutat4 = ciutat4.ToCharArray();
            arrayCiutat5 = ciutat5.ToCharArray();
            arrayCiutat6 = ciutat6.ToCharArray();

            Console.WriteLine("\nCiutats printades a l'inrevès:\n");

            paraulaInvertida(arrayCiutat1);
            paraulaInvertida(arrayCiutat2);
            paraulaInvertida(arrayCiutat3);
            paraulaInvertida(arrayCiutat4);
            paraulaInvertida(arrayCiutat5);
            paraulaInvertida(arrayCiutat6);


            /*for (int i = 0; i < arrayCiutat1.Length; i++)
            {
                cadena = arrayCiutat1[i] + cadena;
            }
            Console.WriteLine(cadena);*/

        }

        private static void paraulaInvertida(char[] arrayC) 
        {
            string cadena = "";

            for (int i = 0; i < arrayC.Length; i++)
            {
                cadena = arrayC[i] + cadena;
            }
            Console.WriteLine(cadena);
        }
    }
}
