using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_final
{
    class Interfaz
    {

        //Variables globales


        //Inicializadas en cero

        //static double moneda5 = 0, moneda10 = 0, moneda25 = 0, moneda100 = 0, billete1 = 0, billete5 = 0;

        //static int bebida = 0, coca = 0, uva = 0, fanta = 0, durazno = 0, limon = 0, frambuesa = 0, agua = 0, mineral = 0;

        static double ingreso, precio, cambio, ingresar;
        static int modoadministrador;

        //Inicializadas con valores

        static double moneda5 = 50, moneda10 = 50, moneda25 = 50, moneda100 = 50, billete1 = 25, billete5 = 15;

        static int bebida = 10, coca = 10, uva = 10, fanta = 10, durazno = 10, limon = 10, frambuesa = 10, agua = 10, mineral = 10;

        static void Main(string[] args)
        {
            funciongeneral();
        }

        static void banquito()
        {
            switch (ingreso)
            {
                case 0.05:
                    moneda5 = moneda5 + 1;
                    break;
                case 0.1:
                    moneda10 = moneda10 + 1;
                    break;
                case 0.25:
                    moneda25 = moneda25 + 1;
                    break;
                case 1:

                    Random r = new Random();
                    int aleatorio = r.Next(1, 2);

                    if (aleatorio == 1)
                    {
                        moneda100 = moneda100 + 1;
                    }
                    else
                    {
                        billete1 = billete1 + 1;
                    }

                    break;
                case 5:
                    billete5 = billete5 + 1;
                    break;
                default:
                    Console.WriteLine("(/)");
                    break;
            }
        }

        static void Recibir()
        {
            Console.Clear();
            FuncionM();
            Console.SetCursorPosition(60, 7);
            Console.WriteLine("{0:C}", precio);
            Console.SetCursorPosition(61, 11);
            ingreso = Convert.ToDouble(Console.ReadLine());
            banquito();
            precio = precio - ingreso;
            if (precio < 0)
            {
                Console.Clear();
                cambio = precio * -1;
                FuncionM();
                Console.SetCursorPosition(60, 24);
                Console.WriteLine("{0:C}", cambio);
            }
        }



        static void FuncionM()
        {
            Console.SetWindowSize(70, 35);
            Console.WriteLine("         ╔════════════════════════════════════════════╦══════════════╗");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ╠════════════════════════════════════════════╬══════════════╣");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║   ┌───────┐  ║");
            Console.WriteLine("         ║                                            ║   |       |  ║");
            Console.WriteLine("         ║                                            ║   └───────┘  ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║   ┌───────┐  ║");
            Console.WriteLine("         ║                                            ║   |       |  ║");
            Console.WriteLine("         ║                                            ║   └───────┘  ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ╠════════════════════════════════════════════╬══════════════╣");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ║                                            ║              ║");
            Console.WriteLine("         ╚════════════════════════════════════════════╩══════════════╝");
            Console.SetCursorPosition(12, 6);
            Console.WriteLine("Coca-Cola");
            Console.SetCursorPosition(13, 11);
            Console.WriteLine("Red-Bull");
            Console.SetCursorPosition(13, 16);
            Console.WriteLine("Té Limón");
            Console.SetCursorPosition(29, 6);
            Console.WriteLine("Cifrut");
            Console.SetCursorPosition(26, 11);
            Console.WriteLine("Mirinda Fresa");
            Console.SetCursorPosition(26, 16);
            Console.WriteLine("Mirinda Uva");
            Console.SetCursorPosition(42, 6);
            Console.WriteLine("Salutaris");
            Console.SetCursorPosition(45, 11);
            Console.WriteLine("Agua");
            Console.SetCursorPosition(45, 16);
            Console.WriteLine("Agua");
            Console.SetCursorPosition(15, 7);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("███");
            Console.SetCursorPosition(15, 8);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("███");
            Console.SetCursorPosition(15, 12);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("███");
            Console.SetCursorPosition(15, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("███");
            Console.SetCursorPosition(15, 17);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("███");
            Console.SetCursorPosition(15, 18);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("███");
            Console.SetCursorPosition(30, 7);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("███");
            Console.SetCursorPosition(30, 8);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("███");
            Console.SetCursorPosition(30, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("███");
            Console.SetCursorPosition(30, 13);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("███");
            Console.SetCursorPosition(30, 17);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("███");
            Console.SetCursorPosition(30, 18);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("███");
            Console.SetCursorPosition(45, 7);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("███");
            Console.SetCursorPosition(45, 8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("███");
            Console.SetCursorPosition(45, 12);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("███");
            Console.SetCursorPosition(45, 13);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("███");
            Console.SetCursorPosition(45, 17);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("███");
            Console.SetCursorPosition(45, 18);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("███");
            Console.ResetColor();


        }

        static void funciongeneral()
        {
            bool confirmacion = false;

            //Sistema
            FuncionM();
            Console.SetCursorPosition(61, 7);
            do
            {

                if (int.TryParse(Console.ReadLine(), out bebida))
                {
                    confirmacion = true;
                    switch (bebida)
                    {
                        case 010:
                            precio = 0.65;
                            do
                            {
                                Recibir();

                            } while (precio > 0);

                            coca = coca - 1;

                            break;

                        case 020:
                            precio = 0.55;
                            do
                            {
                                Recibir();

                            } while (precio > 0);

                            uva = uva - 1;

                            break;
                        case 030:
                            precio = 0.55;
                            do
                            {
                                Recibir();

                            } while (precio > 0);

                            fanta = fanta - 1;

                            break;
                        case 040:
                            precio = 0.60;
                            do
                            {
                                Recibir();

                            } while (precio > 0);

                            durazno = durazno - 1;

                            break;
                        case 050:
                            precio = 0.60;
                            do
                            {
                                Recibir();

                            } while (precio > 0);

                            limon = limon - 1;

                            break;
                        case 060:
                            precio = 0.60;
                            do
                            {
                                Recibir();

                            } while (precio > 0);

                            frambuesa = frambuesa - 1;

                            break;
                        case 070:
                            precio = 0.50;
                            do
                            {
                                Recibir();

                            } while (precio > 0);

                            agua = agua - 1;

                            break;
                        case 080:
                            precio = 0.50;
                            do
                            {
                                Recibir();

                            } while (precio > 0);



                            break;
                        case 0990:
                            Console.Clear();
                            Console.WriteLine("/Modo administrador/\n" +
                                "¿Qué desea hacer?\n" +
                                "[1] Ingresar dinero\n" +
                                "[2] Retirar dinero\n" +
                                "[3] Ingresar productos\n" +
                                "[4] Retirar productos\n" +
                                "[5] Salir\n");
                            modoadministrador = Convert.ToInt32(Console.ReadLine());
                            switch (modoadministrador)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("/Retirar monedas/");
                                    Console.WriteLine("Monedas de $0.05:");
                                    ingresar = Convert.ToInt32(Console.ReadLine());
                                    moneda5 = moneda5 + ingresar;
                                    Console.WriteLine("Monedas de $0.10:");
                                    Console.WriteLine("Monedas de $0.25:");
                                    Console.WriteLine("Monedas de $1.00:");
                                    Console.WriteLine("Billete de $1.00:");
                                    Console.WriteLine("Billete de $5.00:");

                                    break;
                                case 2:
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Clear();
                                    break;
                                case 5:
                                    Console.Clear();
                                    funciongeneral();
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida");
                                    break;
                            }
                            break;

                    }
                }
                else
                {
                    Console.SetCursorPosition(61, 7);
                    Console.WriteLine("(/)");
                    Console.ReadKey();
                    Console.Clear();
                    FuncionM();

                }
            } while (confirmacion == false);
            Console.ReadKey();
        }

    }
}