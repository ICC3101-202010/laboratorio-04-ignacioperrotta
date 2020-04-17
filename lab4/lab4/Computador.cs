using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab4
{
    public class Computador : Maquinas
    {
        public override string encender()
        {
            return "on";
        }
        public override string apagar()
        {
            return "off";
        }
        public override bool reiniciar()
        {
            return true;
        }
        public string estado_maquinas = "apagadas";
       
        public string estado
        {
            get
            {
                return estado_maquinas;
            }
            set
            {
                estado_maquinas = value;
            }

        }
        public void apagar_todo(Empaque empaque, Recepcion recepcion, Almacenamiento almacenamiento, Ensamblaje ensamblaje, Verificacion verificacion)
        {
            estado_maquinas = "apagadas";
            Console.WriteLine("Apagando todas las máquinas");
            Console.WriteLine(empaque.apagar() + "Máquina de empaque apagada");
            Console.WriteLine(recepcion.apagar() + "Máquina de recepción apagada");
            Console.WriteLine(almacenamiento.apagar() + "Máquina de almacenamiento apagada");
            Console.WriteLine(ensamblaje.apagar() + "Máquina de ensamblaje apagada");
            Console.WriteLine(verificacion.apagar() + "Máquina de verificación apagada");
        }
        public void encender_todo(Empaque empaque, Recepcion recepcion, Almacenamiento almacenamiento, Ensamblaje ensamblaje, Verificacion verificacion)
        {
            estado_maquinas = "encendidas";
            Console.WriteLine("Encendiendo todas las máquinas");
            Console.WriteLine(empaque.encender() + "Máquina de empaque encendida");
            Console.WriteLine(recepcion.encender() + "Máquina de recepción encendida");
            Console.WriteLine(almacenamiento.encender() + "Máquina de almacenamiento encendida");
            Console.WriteLine(ensamblaje.encender() + "Máquina de ensamblaje encendida");
            Console.WriteLine(verificacion.encender() + "Máquina de verificación encendida");
        }
    }
}
