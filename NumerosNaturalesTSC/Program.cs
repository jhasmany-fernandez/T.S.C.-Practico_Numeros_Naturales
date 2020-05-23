using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosNaturalesTSC
{
    class Program
    {
        //==============================================================================
        // HERRAMIENTAS
        // 123 = 3
        static int Herramienta_verificar_Numeros_divisibles_tres(int aux) {
            int d = 0, r, f = 0;
            while (aux > 0)
            {
                r = aux % 10;
                d = r % 3;
                if (d == 0)
                {
                    f = (f * 10) + r;
                }
                aux = (aux - r) / 10;
            }
            return f;
        }
        // 123 = 3
        static int Herramienta_Obtener_digito_mayor(int aux)
        {
            int e;
            int d;
            d = aux % 10;
            aux = aux / 10;
            while (aux > 0)
            {
                e = aux % 10;
                aux = aux / 10;
                if (e > d)
                {
                    d = e;
                }
            }
            return d;
        }
        // 123 = 1
        static int Herramienta_Obtener_digito_menor(int aux)
        {
            int e;
            int d;
            d = aux % 10;
            aux = aux / 10;
            while (aux > 0)
            {
                e = aux % 10;
                aux = aux / 10;
                if (e < d)
                {
                    d = e;
                }
            }
            return d;
        }
        //123 = 3
        static int Herramienta_Contar_digitos(int aux) {
            int c = 0;
            while (aux > 0) {
                aux = aux / 10;
                c = c + 1;
            }
            return c;
        }
        //123 = 321
        static int Herramienta_Invertir_digitos(int aux) {
            int d = 0, f = 0;
            while (aux > 0) {
                d = aux % 10;
                aux = aux / 10;
                f = (f * 10) + d;
            }
            return f;
        }
        // 456 = 4
        static int Herramienta_Obtener_Primer_Digito(int aux) {
            int a = 0, f = 0;
            while (aux > 0) {
                a = Herramienta_Invertir_digitos(aux);
                f = a % 10;
                aux = 0;
            }
            return f;
        }
        // 456 = 6
        static int Herramienta_Obtener_Ultimo_Digito(int aux)
        {
            int f = 0;
            while (aux > 0)
            {
                f = aux % 10;
                aux = 0;
            }
            return f;
        }

        static int Herramienta_Obtenre_Digitos_Pares(int aux) {
            int e, d, f = 0;
            while (aux > 0)
            {
                d = aux % 10;
                aux = aux / 10;
                e = d % 2;
                if (e == 0)
                {
                    f = (f * 10) + d;
                }
            }
            return f;
        }
    
        static int Herramienta_Obtenre_Digitos_Impares(int aux)
        {
            int e, d, f = 0;
            while (aux > 0)
            {
                d = aux % 10;
                aux = aux / 10;
                e = d % 2;
                if (e == 1)
                {
                    f = (f * 10) + d;
                }
            }
            return f;
        }

        static int Herramienta_Sumar_Digitos(int aux) {
            int d=0,f=0;
            while (aux > 0)
            {
                d = aux % 10;
                aux = aux / 10;
                f = f + d;
            }
            return f;
        }

        static decimal Herramienta_Promedio_digitos(int aux) {
            int a, b;
            decimal f;
            a = Herramienta_Sumar_Digitos(aux);
            b = Herramienta_Contar_digitos(aux);
            f = decimal.Divide(a , b);
            return f;
        }

        static bool Herramienta_Verificar_Primo(int aux) {
            int a = 0;
            bool b = true;
            for (int i = 1; i <= aux; i++)
            {
                if (aux % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                b = true;
                
            }
            else
            {
                b = false;
                
            }
            return b;
        }

        static int Herramienta_Obtener_Digitos_Primos(int aux) {
            int d,f=0;
            while (aux > 0) {
                d = aux % 10;
                if (Herramienta_Verificar_Primo(d) == true) {
                    f = (f*10) + d;
                }
                aux = aux / 10;
            }
            return f;
        }

        static string Herramiena_Verificar_Digito_Par(int aux)
        {
            int a;
            string b;
            a = Herramienta_Obtenre_Digitos_Pares(aux);
            if (a == 0)
            {
                b = "No exite algun numero par";
            }
            else
            {
                b = "Exite algun numero par";
            }
            return b;
        }

        static string Herramiena_Verificar_Digito_Impar(int aux) {
            int a;
            string b;
            a = Herramienta_Obtenre_Digitos_Impares(aux);
            if (a == 0) {
                b = "No exite algun numero Impar";
            }
            else {
                b = "Exite algun numero Impar";
            }
            return b;
        }

        static int Herramienta_Verificar_Divisibles_Numero_Cuatro(int aux) {
            int b,a = 0;
            while (aux > 0) {
                b = aux % 10;
                if (b % 4 == 0)
                {
                    a++;
                }
                aux = aux / 10;
            }
            return a;
        }

        static string Herramienta_Sacar_Promedio_Cantidad_Digitos_Cinco_Seis(int aux) { 
            int a;
            decimal h=0;
            string s;
            a = Herramienta_Contar_digitos(aux);
            if ((a == 5) || (a == 6))
            {
                h = Herramienta_Promedio_digitos(aux);
                s ="El promedio de Cantidad de digitos 5 a 6 Es: "+ (Convert.ToString(Math.Round(h,5)));
            }
            else {
                s = "No se encuentra en el promedio de Cantidad de digitos 5 a 6";
            }

            return s;
        }
        //==============================================================================
        // PRACTICO NUMEROS NATURALES

        static int Ejercicio_1(int aux) {
            int a=0, b=0;
            a = Herramienta_verificar_Numeros_divisibles_tres(aux);
            b = Herramienta_Contar_digitos(a);
            return b;
        }

        static int Ejercicio_2(int aux)
        {
            int a = 0, b = 0;
            a = Herramienta_verificar_Numeros_divisibles_tres(aux);
            b = Herramienta_Obtener_digito_menor(a);
            return b;
        }
        static string Ejercicio_3(int aux)
        {
            
            string a;
            a = Herramienta_Sacar_Promedio_Cantidad_Digitos_Cinco_Seis(aux);
            return a;
        }
        static int Ejercicio_4(int aux)
        {
            int a = 0, b = 0;
            a = Herramienta_Obtenre_Digitos_Pares(aux);
            b = Herramienta_Obtener_Primer_Digito(a);
            return b;
        }

        static decimal Ejercicio_5(int aux)
        {
            int a = 0; 
            decimal b = 0;
            a = Herramienta_verificar_Numeros_divisibles_tres(aux);
            b = Herramienta_Promedio_digitos(a);
            return b;
        }

        static int Ejercicio_6(int aux)
        {
            int a = 0;
            a = Herramienta_Obtener_Primer_Digito(aux);
            return a;
        }

        static int Ejercicio_7(int aux)
        {
            int a = 0;
            a = Herramienta_Obtener_Ultimo_Digito(aux);
            return a;
        }

        static int Ejercicio_8(int aux)
        {
            int a = 0;
            a = Herramienta_Contar_digitos(aux);
            return a;
        }

        static int Ejercicio_9(int aux)
        {
            int a = 0, b = 0;
            a = Herramienta_Obtenre_Digitos_Pares(aux);
            b = Herramienta_Contar_digitos(a);
            return b;
        }

        static int Ejercicio_10(int aux)
        {
            int a = 0, b = 0;
            a = Herramienta_Obtenre_Digitos_Impares(aux);
            b = Herramienta_Contar_digitos(a);
            return b;
        }

        static int Ejercicio_11(int aux)
        {
            int a = 0;
            a = Herramienta_Obtener_digito_mayor(aux);
            return a;
        }

        static int Ejercicio_12(int aux)
        {
            int a = 0;
            a = Herramienta_Obtener_digito_menor(aux);
            return a;
        }

        static decimal Ejercicio_13(int aux)
        {
            decimal a = 0;
            a = Herramienta_Promedio_digitos(aux);
            return a;
        }

        static decimal Ejercicio_14(int aux)
        {
            int b = 0;
            decimal a = 0;
            b = Herramienta_Obtenre_Digitos_Pares(aux);
            a = Herramienta_Promedio_digitos(b);
            return a;
        }
        static decimal Ejercicio_15(int aux)
        {
            int b = 0;
            decimal a;
            b = Herramienta_Obtener_Digitos_Primos(aux);
            a = Herramienta_Promedio_digitos(b);
            return a;
        }
        static string Ejercicio_16(int aux)
        {
            string a;
            a = Herramiena_Verificar_Digito_Impar(aux);
            return a;
        }
        static string Ejercicio_17(int aux)
        {
            string a;
            a = Herramiena_Verificar_Digito_Par(aux);
            return a;
        }
        static string Ejercicio_18(int aux)
        {
            int a,b;
            string s;
            a = Herramienta_Obtenre_Digitos_Pares(aux);
            a = Herramienta_Contar_digitos(a);
            b = Herramienta_Obtenre_Digitos_Impares(aux);
            b = Herramienta_Contar_digitos(b);
            s = "Digito Par: "+(Convert.ToString(a)) + " Digito Impar: "+ (Convert.ToString(b));
            return s;
        }
        static string Ejercicio_19(int aux)
        {
            int a, b;
            string s;

            a = Herramienta_Obtenre_Digitos_Pares(aux);
            a = Herramienta_Contar_digitos(a);
            b = Herramienta_Obtenre_Digitos_Pares(aux);
            b = Herramienta_Verificar_Divisibles_Numero_Cuatro(b);
            s = "Cantidad digitos Pares: " + "["+(Convert.ToString(a)) +"]"+ " Cantidad digitos pares divisibles entre Cuatro: " + "["+(Convert.ToString(b))+"]";
            return s;
        }
   
        //==============================================================================
        // VISUALIZACION DE LA CONSOLA

        static void Main(string[] args)
        {
            int n = 0, f = 0, num = 0;
            decimal d;
            bool b = true, rr=true;
            char a;
            string s;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("ELEGIR LA [OPCION]:");
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1]: Hacer un algoritmo para contar los dígitos múltiplos de tres.");
            Console.WriteLine("[2]: Hacer un algoritmo para mostrar el digito menor de los múltiplos de tres.");
            Console.WriteLine("[3]: Hacer un algoritmo para mostrar el promedio de los dígitos que se encuentren entre 5 y 6.");
            Console.WriteLine("[4]: Hacer un algoritmo para mostrar el primer digito par.");
            Console.WriteLine("[5]: Obtener el promedio de los dígitos múltiplos de tres.");
            Console.WriteLine("[6]: Hacer un algoritmo que muestre el primer digito de un numero.");
            Console.WriteLine("[7]: Hacer un algoritmo que muestre el ultimo digito de un numero.");
            Console.WriteLine("[8]: Hacer un algoritmo que muestre la cantidad de dígitos que tiene un numero.");
            Console.WriteLine("[9]: Hacer un algoritmo que pida un numero por teclado y determine cuantos dígitos pares tiene dicho numero.");
            Console.WriteLine("[10]: Hacer un algoritmo que pida un numero por teclado y determine cuantos dígitos impares tiene Dicho numero.");
            Console.WriteLine("[11]: Hacer un algoritmo que pida un numero por teclado y determine cual es el valor del digito mayor de dicho numero.");
            Console.WriteLine("[12]: Hacer un algoritmo que pida un numero por teclado y determine cual es el valor del digito menor de dicho numero.");
            Console.WriteLine("[13]: Hacer un algoritmo que pida un numero por teclado y determine el promedio de todos los dígitos de dicho numero.");
            Console.WriteLine("[14]: Hacer un algoritmo que pida un numero por teclado y determine el promedio de todos los dígitos pares de dicho numero.");
            Console.WriteLine("[15]: Hacer un algoritmo que pida un numero por teclado y determine el promedio de todos los dígitos primos de dicho numero.");
            Console.WriteLine("[16]: Hacer un algoritmo que pida un numero por teclado y determine si existe algún digito impar en dicho numero.");
            Console.WriteLine("[17]: Hacer un algoritmo que pida un numero por teclado y determine si existe algún digito par en dicho numero.");
            Console.WriteLine("[18]: Hacer un algoritmo que pida un numero por teclado y determine cuantos dígitos pares tiene a continuación un par digito impar.");
            Console.WriteLine("[19]: Hacer un algoritmo que pida un numero por teclado y determine cuantos dígitos pares son divisibles entre cuatro.");
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            
            
            while (b == true) { //Bandera
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("INGRESE LA OPCION: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("");
                switch (num) //Estructura Case
                    {
                    case 1:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_1(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 2:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_2(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 3:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        s = Ejercicio_3(n);
                        Console.Write("EL RESULTADO ES: "+s);
                        break;
                    case 4:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_4(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 5:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        d = Ejercicio_5(n);
                        Console.Write("EL RESULTADO ES: ");
                        Console.WriteLine("{0:N4}", +d);
                        break;
                    case 6:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_6(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 7:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_7(n);
                        Console.Write("EL RESULTADO ES: " + f);
                        break;
                    case 8:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_8(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 9:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_9(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 10:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_10(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 11:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_11(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 12:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        f = Ejercicio_12(n);
                        Console.WriteLine("EL RESULTADO ES: " + f);
                        break;
                    case 13:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        d = Ejercicio_13(n);
                        Console.Write("EL RESULTADO ES: ");
                        Console.WriteLine("{0:N4}", + d);
                        break;
                    case 14:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        d = Ejercicio_14(n);
                        Console.Write("EL RESULTADO ES: ");
                        Console.WriteLine(Math.Truncate(d));
                        break;
                    case 15:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        d = Ejercicio_15(n);
                        Console.Write("EL RESULTADO ES: ");
                        Console.WriteLine("{0:N1}", +d);
                        break;
                    case 16:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        s = Ejercicio_16(n);
                        Console.WriteLine("EL RESULTADO ES: " + s);
                        break;
                    case 17:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        s = Ejercicio_17(n);
                        Console.WriteLine("EL RESULTADO ES: " + s);
                        break;
                    case 18:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        s = Ejercicio_18(n);
                        Console.WriteLine("EL RESULTADO ES: " + s);
                        break;
                    case 19:
                        Console.Write("INGRESAR EL VALOR: ");
                        n = int.Parse(Console.ReadLine());
                        s = Ejercicio_19(n);
                        Console.WriteLine("EL RESULTADO ES: " + s);
                        break;
                    default:
                        Console.Write("La opcion no existe, Vuelva a intentarlo ");
                        b = false;
                        break;
                }
           
                while (rr == true) { //Bandera
                    Console.WriteLine(""); //Espacio
                    if (b == true) //Pregunta si desea continular o no 
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Si desa seguir Marcar ingrese la letra: 's' y si no 'n' : ");
                        a = char.Parse(Console.ReadLine());
                        if ((a == 's') || (a == 'S'))
                        {
                            b = true;
                            rr = false;
                        }
                        else
                        {
                            if ((a == 'n') || (a == 'N'))
                            {
                                Console.WriteLine(""); //Espacio
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Presionar la tecla Enter ");
                                b = false;
                                rr = false;
                            }
                            else
                            {
                                Console.WriteLine(""); //Espacio
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ERRO /Por favor Marque la Opcion: 's' si desa continuar, Si no 'n'  ");
                            }
                        }
                    }
                    else {
                        b = true;
                    }
                }
                rr = true;
            }
            Console.ReadKey();
        }
    }
}
