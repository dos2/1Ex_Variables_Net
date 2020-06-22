using Microsoft.VisualBasic;
using System;

namespace ItAcademy
{
    class ExVariables
    {
        static void Main(string[] args)
        {
            //Fase1
            string nom="Eric", cognom1="Alonso", cognom2="Gonzàlez";
            int dia=16, mes=6, any=1987;

            Console.WriteLine($"Bon dia, {nom} {cognom1} {cognom2},");
            Console.WriteLine($"La data és {dia}/{mes}/{any}.");

            //Fase2 i 3
            const int ANYINICI = 1948;
            int anysTraspas=0;
            bool finalTraspas=false;
            for (int i = ANYINICI; i<=any; i=i+4 )
            {
                anysTraspas++;
                Console.WriteLine($"Any de traspàs {anysTraspas}: {i}");
                if (i == any)
                {
                    finalTraspas = true;
                }
            }
            Console.WriteLine($"Número d'anys de traspàs entre {ANYINICI} i {any}: {anysTraspas}");
            string siTraspas = "El teu any de naixement va ser un any de traspàs.";
            string noTraspas = "El teu any de naixement no va ser un any de traspàs.";
            if (finalTraspas)
            {
                Console.WriteLine(siTraspas);
            }
            else
            {
                Console.WriteLine(noTraspas);
            }
            string nomComplet = nom + " " + cognom1 + " " + cognom2;
            string dataCompleta =  dia.ToString() + "/" + mes.ToString() + "/" + any.ToString();

            Console.WriteLine($"El teu nom és {nomComplet}");
            Console.WriteLine($"El teu any de naixement és: {dataCompleta}");
            Console.WriteLine(noTraspas);



        }
        
    }
}
