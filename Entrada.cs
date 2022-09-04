using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322070
{
    internal class Entrada
    {
        // Declaração de Atributos
        double valor;
        int poltrona;
        string dataehora;

        // Declaração de Métodos

        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return this.valor;
        }
        public void SetPoltrona(int poltrona)
        {
            this.poltrona = poltrona;
        }
        public int GetPoltrona()
        {
            return this.poltrona;
        }
        public void SetDataehora(string dataehora)
        {
            this.dataehora = dataehora;
        }
        public string GetDataehora()
        {
            return this.dataehora;
        }

       
    }
}
