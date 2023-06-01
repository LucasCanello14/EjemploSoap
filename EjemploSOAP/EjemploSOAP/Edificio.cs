using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSOAP
{
    public class Edificio
    {
       
        
        public List<Ascensor> ascensores;
        public Edificio()
        {
           
            ascensores = new List<Ascensor>();
            Ascensor ascensor1 = new Ascensor() { Codigo = 1, Ocupado = false, PisoActual = 0 };
            Ascensor ascensor2 = new Ascensor() { Codigo = 2, Ocupado = false, PisoActual = 0 };
            Ascensor ascensor3 = new Ascensor() { Codigo = 3, Ocupado = false, PisoActual = 0 };
            ascensores.Add(ascensor1);
            ascensores.Add(ascensor2);
            ascensores.Add(ascensor3);
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
            int pisoInicial = 0;
            Ascensor ascensor = ascensores.First(x => x.Codigo == codigo);
            if (!ascensor.Ocupado)
            {
                ascensor.Ocupado = true;
                pisoInicial = ascensor.PisoActual;
            }
            return pisoInicial;
        }

        public string  DesocuparAscensor(int codigo)
        {
            Ascensor ascensor = ascensores.First(x => x.Codigo == codigo);
            if (ascensor.Ocupado)
            {
                ascensor.Ocupado = false;
            }
            return "Ascensor desocupado";
        }
    }
}
