using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectocII
{
    class Program
    {
        static void Main(string[] args)
        {
            int resm;
            do
            { Console.WriteLine("*************************");
                Console.WriteLine("elija una opcion ");
                Console.WriteLine("1.Suma de vectores A,B,C ");
                Console.WriteLine("2.Resta de vectores A,B,C ");
                Console.WriteLine("3.Modulo de un vector");
                Console.WriteLine("4.Multiplicacion escalar ");
                Console.WriteLine("5.Multiplicacion vectorial ");
                Console.WriteLine("6.salir ");
                Console.WriteLine("*************************");
                resm = Convert.ToInt32(Console.ReadLine());
                switch (resm)
                {case 1:
                        { int[] numero;
                            int res, res2, res3;
                            numero = new int[10];
                            //vector A
                            Console.WriteLine("ingrese primer valor del vector A");
                            numero[0] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector A");
                            numero[1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector A");
                            numero[2] = Convert.ToInt32(Console.ReadLine());
                            //Vector B
                            Console.WriteLine("ingrese primer valor del vector B");
                            numero[3] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector B");
                            numero[4] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector  B");
                            numero[5] = Convert.ToInt32(Console.ReadLine());
                            //Vector C
                            Console.WriteLine("ingrese primer valor del vector C");
                            numero[6] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector C");
                            numero[7] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector C");
                            numero[8] = Convert.ToInt32(Console.ReadLine());
                            res = numero[0] + numero[3] + numero[6];
                            res2 = numero[1] + numero[4] + numero[7];
                            res3 = numero[2] + numero[5] + numero[8];
                            Console.WriteLine("la suma de vectores es :  ({0},{1},{2}) ", res, res2, res3);
     
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        { int[] numero;
                            int res, res2, res3;
                            numero = new int[10];
                            //vector A
                            Console.WriteLine("ingrese primer valor del vector A");
                            numero[0] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector A");
                            numero[1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector A");
                            numero[2] = Convert.ToInt32(Console.ReadLine());
                            //Vector B
                            Console.WriteLine("ingrese primer valor del vector B");
                            numero[3] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector B");
                            numero[4] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector  B");
                            numero[5] = Convert.ToInt32(Console.ReadLine());
                            //Vector C
                            Console.WriteLine("ingrese primer valor del vector C");
                            numero[6] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector C");
                            numero[7] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector C");
                            numero[8] = Convert.ToInt32(Console.ReadLine());
                            res = numero[0] - numero[3] - numero[6];
                            res2 = numero[1] - numero[4] - numero[7];
                            res3 = numero[2] - numero[5] - numero[8];
                            Console.WriteLine("la resta de vectores es :  ({0},{1},{2}) ", res, res2, res3);
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        { double a, b, c, res;
                            Console.WriteLine("Modulo vectorial ");
                            Console.WriteLine("Ingrese 3 valores para el vector :");
                            Console.WriteLine("Ingrese valor 1 :");
                            a = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese valor 2 :");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese valor 3 :");
                            c = double.Parse(Console.ReadLine());
                            res = Math.Sqrt(a * a + b * b + c * c);
                            Console.WriteLine("El modulo es: {0}", res);
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        { int[] numero;
                            int res, res2, res3, res4;
                            numero = new int[7];
                            //vector A
                            Console.WriteLine("ingrese primer valor del vector A");
                            numero[0] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector A");
                            numero[1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector A");
                            numero[3] = Convert.ToInt32(Console.ReadLine());
                            //Vector B
                            Console.WriteLine("ingrese primer valor del vector B");
                            numero[4] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector B");
                            numero[5] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector  B");
                            numero[6] = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            res = numero[0] * numero[4];
                            res2 = numero[1] * numero[5];
                            res3 = numero[3] * numero[6];
                            res4 = res + res2 + res3;
                            if (res4 > 0)
                            { Console.WriteLine("el producto escalar es: {0} ", res4); }
                            else
                            {
                                Console.WriteLine("El producto escalar aplicando valor absoluto es : Abs({0}) = {1}", res4, Math.Abs(res4));
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            int[] numero;
                            int res, res2, res3, res4, i, J, res5, res6, k, aux;
                            numero = new int[7];
                            //vector A
                            Console.WriteLine("ingrese primer valor del vector A");
                            numero[0] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector A");
                            numero[1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector A");
                            numero[2] = Convert.ToInt32(Console.ReadLine());
                            //Vector B
                            Console.WriteLine("ingrese primer valor del vector B");
                            numero[3] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese segundo valor del vector B");
                            numero[4] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese tercer valor del vector  B");
                            numero[5] = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            res = numero[1] * numero[5];
                            res2 = numero[2] * numero[4];
                            i = res - res2;
                            res3 = numero[0] * numero[5];
                            res4 = numero[2] * numero[3];
                            J = res3 - res4;
                            res5 = numero[0] * numero[4];
                            res6 = numero[1] * numero[3];
                            k = res5 - res6;
                            if (J > 0)
                            {
                                aux = J * -1;
                                Console.WriteLine("El producto vectorial es : {0},{1},{2}", i, aux, k);
                            }
                            else
                            { Console.WriteLine("El producto vectorial es : {0},{1},{2}", i, J, k); }
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("no esta dentro de las opciones");
                            Console.WriteLine("hola");
                            break;
                       }
                }

            } while (resm != 6);


           

          

        } 
    }
}
