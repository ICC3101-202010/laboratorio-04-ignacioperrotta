using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la fábrica orientada a objetos");
            Console.WriteLine("Seleecione que opción desea realizar");
            Console.WriteLine("(1) Encender todas las Máquinas");
            Console.WriteLine("(2) Empezar a funcionar las máquinas");
            Console.WriteLine("(3) Empezar a funcionar las máquinas desde 0");
            Console.WriteLine("(4) Apagar todas las Máquinas");
            Console.WriteLine("(5) Salir de la fábrica");
            Console.WriteLine(" ");
            Console.WriteLine("Le recordamos que:");
            Console.WriteLine("Memoria máxima de la máquina de Empaque = 7");
            Console.WriteLine("Memoria máxima de la máquina de Recepción = 6");
            Console.WriteLine("Memoria máxima de la máquina de Almacenamiento = 5");
            Console.WriteLine("Memoria máxima de la máquina de Ensamblaje = 4");
            Console.WriteLine("Memoria máxima de la máquina de Verificación = 3");

            Empaque empaque = new Empaque();
            Recepcion recepcion = new Recepcion();
            Almacenamiento almacenamiento = new Almacenamiento();
            Ensamblaje ensamblaje = new Ensamblaje();
            Verificacion verificacion = new Verificacion();
            Computador computador = new Computador();
            List<int> piezas = new List<int>();
            string input_usuario;
            input_usuario = Console.ReadLine();
            int pieza;
            pieza = 1;
            int memory;
            memory = 1;
            while (input_usuario == "1" || input_usuario == "2" || input_usuario == "3" || input_usuario == "4" || input_usuario == "5")
            {
                if (input_usuario == "1")
                {
                    if (computador.estado_maquinas == "encendidas")
                    {
                        Console.WriteLine("Ya están prendidas todas las máquinas");
                    }
                    else
                    {
                        computador.encender_todo(empaque, recepcion, almacenamiento, ensamblaje, verificacion);
                    }
                }
                else if (input_usuario == "2")
                {
                    if (computador.estado_maquinas == "apagadas")
                    {
                        Console.WriteLine("Las máquinas no pueden funcionar,ya que están apagadas");
                        Console.WriteLine("¿Deseas encenderlas?");
                        Console.WriteLine("a)si");
                        Console.WriteLine("b)no");
                        string resp = Console.ReadLine();
                        if (resp == "a")
                        {
                            computador.encender_todo(empaque, recepcion, almacenamiento, ensamblaje, verificacion);
                            Console.WriteLine("");
                            Console.Write("Ahora procederemos a funcionar las máquinas");
                        }
                        else if (resp == "b")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opción ingresada no válida");
                            break;
                        }
                    }
                    
                    while (memory != 0)
                    {
                        piezas.Add(pieza);
                        Console.WriteLine("");
                        Console.WriteLine("El objeto " + pieza + " se está procesando");
                        empaque.reiniciar();
                        recepcion.reiniciar();
                        almacenamiento.reiniciar();
                        ensamblaje.reiniciar();
                        verificacion.reiniciar();
                        pieza++;
                        Console.WriteLine("Desea continuar con el funcionamiento");
                        Console.WriteLine("a)si");
                        Console.WriteLine("b)no");
                        string respuesta;
                        respuesta = Console.ReadLine();
                        if (respuesta == "a")
                        {
                            continue;
                        }
                        else if (respuesta == "b")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opción ingresada no válida");
                            break;
                        }
                    }
                    memory = 1;

                    

                }
                else if (input_usuario == "3")
                {
                    if (computador.estado_maquinas == "apagadas")
                    {
                        Console.WriteLine("Las máquinas no pueden funcionar,ya que están apagadas");
                        Console.WriteLine("¿Deseas encenderlas?");
                        Console.WriteLine("a)si");
                        Console.WriteLine("b)no");
                        string resp = Console.ReadLine();
                        if (resp == "a")
                        {
                            computador.encender_todo(empaque, recepcion, almacenamiento, ensamblaje, verificacion);
                            Console.WriteLine("");
                            Console.Write("Ahora procederemos a funcionar las máquinas desde 0");
                        }
                        else if (resp == "b")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opción ingresada no válida");
                            break;
                        }
                    }
                    else
                    {
                        piezas.Clear();
                        pieza = 1;
                        empaque.memoria_acumulada = 0;
                        recepcion.memoria_acumulada = 0;
                        almacenamiento.memoria_acumulada = 0;
                        ensamblaje.memoria_acumulada = 0;
                        verificacion.memoria_acumulada = 0;
                    }
                    
                    while (memory != 0)
                    {
                        piezas.Add(pieza);
                        Console.WriteLine("");
                        Console.WriteLine("El objeto " + pieza + " se está procesando");
                        empaque.reiniciar();
                        recepcion.reiniciar();
                        almacenamiento.reiniciar();
                        ensamblaje.reiniciar();
                        verificacion.reiniciar();
                        pieza++;
                        Console.WriteLine("Desea continuar con el funcionamiento");
                        Console.WriteLine("a)si");
                        Console.WriteLine("b)no");
                        string respuesta;
                        respuesta = Console.ReadLine();
                        if (respuesta == "a")
                        {
                            continue;
                        }
                        else if (respuesta == "b")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opción ingresada no válida");
                            break;
                        }
                    }
                   



                }
                else if (input_usuario == "4")
                {
                    if (computador.estado_maquinas == "apagadas")
                    {
                        Console.WriteLine("Ya están apagadas todas las máquinas");
                    }
                    else
                    {
                        computador.apagar_todo(empaque, recepcion, almacenamiento, ensamblaje, verificacion);
                    }
                }
                else if (input_usuario == "5")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("El criterio ingresado no es válido");
                }
                Console.WriteLine(" ");
                Console.WriteLine("Bienvenido a la fábrica orientada a objetos");
                Console.WriteLine("Seleecione que opción desea realizar");
                Console.WriteLine("(1) Encender todas las Máquinas");
                Console.WriteLine("(2) Empezar a funcionar las máquinas");
                Console.WriteLine("(3) Empezar a funcionar las máquinas desde 0");
                Console.WriteLine("(4) Apagar todas las Máquinas");
                Console.WriteLine("(5) Salir de la fábrica");
                input_usuario = Console.ReadLine();
            }


        }
    }
}
