using System;

namespace Cocina
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;

            bool num1 = false;
            bool num2 = false;
            bool num3 = false;
            bool num4 = false;
            bool num5 = false;


            Combustible comb;
            Electrodomestico elec;
            Utensilios ute;
            Condimento con;
            Huevo hue;
            Arroz roz;


            Console.WriteLine("Hola, hoy cocinaremos un huevo frito");
            while (num1 == false)
            {
                Console.WriteLine("Con cuanto combustible cuenta para la parrilla?");
                Console.WriteLine("Capacidad: ");
                comb = new Combustible();
                comb.cap_combustible = int.Parse(Console.ReadLine());
                Console.WriteLine("Durabilidad: ");
                comb.dur_combustible = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Los datos son correctos?");
                Console.WriteLine("Capacidad: " + comb.cap_combustible);
                Console.WriteLine("Durabilidad: " + comb.dur_combustible);
                Console.WriteLine("s/n");
                respuesta = Console.ReadLine();
                while (respuesta != "s" && respuesta != "n")
                {
                    Console.WriteLine("Intente denuevo: s/n");
                    respuesta = Console.ReadLine();
                }
                while (respuesta == "n")
                {
                    Console.WriteLine("Capacidad: ");
                    comb.cap_combustible = int.Parse(Console.ReadLine());
                    Console.WriteLine("Durabilidad: ");
                    comb.dur_combustible = int.Parse(Console.ReadLine());
                    Console.WriteLine("s/n");
                    respuesta = Console.ReadLine();
                    /*Console.WriteLine("Hasta luego");
                    Console.ReadKey();
                    Environment.Exit(0);*/
                }
                if (respuesta == "s")
                    num1 = true;
            }
            Console.Clear();



            Console.WriteLine("Los datos de su parrilla son: ");
            Console.WriteLine("Marca: ");
            elec = new Electrodomestico();
            elec.mar_electrodomestico = Console.ReadLine();
            Console.WriteLine("Estado (1 / 10): ");
            elec.des_electrodomestico = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Los datos son: ");
            Console.WriteLine("Marca: " + elec.mar_electrodomestico);
            Console.WriteLine("Estado: " + elec.des_electrodomestico);
            Console.WriteLine("Desea prender la cocina?");
            Console.WriteLine("s/n");
            respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("Intente denuevo: s/n");
                respuesta = Console.ReadLine();
            }
            if (respuesta == "n")
            {
                Console.WriteLine("Usted decidio no prenderla");
                Console.WriteLine("Hasta luego");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Parrilla prendida!");
                Console.WriteLine("");
                num2 = true;
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Cuan desgastada esta la sarten?");
            ute = new Utensilios();
            ute.dur_utensilio_sarten = int.Parse(Console.ReadLine());
            if (ute.dur_utensilio_sarten >= 61 && ute.dur_utensilio_sarten <= 100)
            {
                Console.WriteLine("Su sarten esta en perfectas condiciones.");
            }
            if (ute.dur_utensilio_sarten >= 31 && ute.dur_utensilio_sarten <=60)
            {
                Console.WriteLine("Su sarten esta en condicione media. Se le puede pegar un poco el huevo.");
            }
            if (ute.dur_utensilio_sarten <=30)
            {
                Console.WriteLine("Su sarten no sirve. Compre una nueva.");
                Console.WriteLine("Hasta luego");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
                num3 = true;
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Cuanta mantequilla utilizara?");
            con = new Condimento();
            con.cant_condimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea utilizar esa cantidad?");
            Console.WriteLine("s/n");
            respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("Intente denuevo: s/n");
                respuesta = Console.ReadLine();
            }
            while (respuesta == "n")
            {
                Console.WriteLine("Cuanta mantequilla utilizara?");
                con.cant_condimento = int.Parse(Console.ReadLine());
                Console.WriteLine("Desea utilizar esa cantidad?");
                Console.WriteLine("s/n");
                respuesta = Console.ReadLine();
            }
            if (respuesta == "s")
                num4 = true;
            Console.Clear();


            Console.WriteLine("Cuantos huevos utilizara?");
            hue = new Huevo();
            hue.can_huevo = int.Parse(Console.ReadLine());
            int gramos;
            gramos = hue.can_huevo * hue.peso_comida;
            Console.WriteLine("Usted consumira: " + gramos +" gramos");
            Console.WriteLine("Consumira esa cantidad?");
            Console.WriteLine("s/n");
            respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("Intente denuevo: s/n");
                respuesta = Console.ReadLine();
            }
            while (respuesta == "n")
            {
                Console.WriteLine("Cuantos huevos utilizara?");
                hue.can_huevo = int.Parse(Console.ReadLine());
                gramos = hue.can_huevo * hue.peso_comida;
                Console.WriteLine("Usted consumira: " + gramos + " gramos");
                Console.WriteLine("Consumira esa cantidad?");
                Console.WriteLine("s/n");
                respuesta = Console.ReadLine();
            }
            if (respuesta == "s")
                num5 = true;
            Console.Clear();

            if (num1 == true && num2 == true && num3 == true && num4 == true && num5 == true)
            {
                Console.WriteLine("Su huevo frito esta listo.");
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Desea añadirle arroz?");
            Console.WriteLine("s/n");
            respuesta = Console.ReadLine();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("Desea añadirle arroz?");
                Console.WriteLine("s/n");
                respuesta = Console.ReadLine();
            }
            if  (respuesta == "s")
            {
                string tipoarroz;
                //tipoarroz = roz.tarroz;
                Console.WriteLine("Que tipo de arroz desea. Amarillo (a) o Blanco (b)");
                tipoarroz = Console.ReadLine();
                while (tipoarroz != "a" && tipoarroz != "b")
                {
                    Console.WriteLine("Que tipo de arroz desea. Amarillo (a) o Blanco (b)");
                    tipoarroz = Console.ReadLine();
                }
                if (tipoarroz == "a")
                {
                    Console.WriteLine("Usted eligio: Arroz amarillo.");
                    roz = new Arroz();
                    roz.amarillo = true;
                } else if (tipoarroz == "b")
                {
                    Console.WriteLine("Usted eligio: Arroz Blanco");
                    roz = new Arroz();
                    roz.blanco = true;
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}


