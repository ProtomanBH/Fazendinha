using System;
using System.Collections.Generic;
using System.Text;

namespace Fazendinha
{
    class Vaca : Animais
    {
        private double producao_de_leite;

        public double Producao_de_leite
        {
            get
            {
                return this.producao_de_leite;
            }
            set
            {
                this.producao_de_leite = value;
            }
        }

        public override string Som()
        {
            string som_vaca;
            som_vaca = "mú";
            return som_vaca;
        }

        public Vaca(double altura, double peso)
        {
            this.Altura = altura;
            this.Peso = peso;
        }
    }
}
