using System;
using System.Collections.Generic;
using System.Text;

namespace Fazendinha
{
    class Galinha : Animais
    {
        private double quantidade_de_ovos;

        public double Quantidade_de_ovos
        {
            get
            {
                return this.quantidade_de_ovos;
            }
            set
            {
                this.quantidade_de_ovos = value;
            }
        }

        public override string Som()
        {
            string som_galinha;
            som_galinha = "có";
            return som_galinha;
        }

        public Galinha(double altura, double peso)
        {
            this.Altura = altura;
            this.Peso = peso;
        }


    }
}
