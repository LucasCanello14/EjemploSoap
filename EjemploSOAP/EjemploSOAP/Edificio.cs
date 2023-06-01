using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSOAP
{
    internal class Edificio
    {
        public List<Ascensor> ascensores;
        public Edificio()
        {
            ascensores = new List<Ascensor>();  
        }
        
        public bool EstadoAscensor(int codigo)
        {
            bool ocupado;
            Ascensor ascensor = ascensores.First(x => x.Codigo == codigo);
            if (ascensor.Ocupado)
            {
                ocupado = true;
            }
            else
            {
                ocupado = false;
            }

            return ocupado;
        }

        public int SolicitarAscensor(int nroPiso, int codigo)
        {
            Ascensor ascensor = ascensores.First(x => x.Codigo == codigo);
            if (!ascensor.Ocupado)
            {
                ascensor.Ocupado = true;
                int pisoInicial = ascensor.PisoActual;
            }
            return ;
        }
    }
}
