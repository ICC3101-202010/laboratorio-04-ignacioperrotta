using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab4
{
    public class Ensamblaje : Maquinas
    {
        private int Memoria = 4;
        public int memoria_acumulada = 0;
        public void restaurar()
        {
            memoria_acumulada = 0;
        }
        public override string encender()
        {
            return "";
        }
        public override string apagar()
        {
            return "";
        }
        public override bool reiniciar()
        {
            memoria_acumulada++;
            if (memoria_acumulada == Memoria)
            {
                Console.WriteLine("Ha utilizado la capacidad máxima de memoria pa la máquina de ensamblaje, por lo tan se restablecerá");
                restaurar();
                return true;
            }
            return false;
        }



    }
}
