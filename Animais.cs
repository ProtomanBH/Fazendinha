using System;
using System.Collections.Generic;
using System.Text;

namespace Fazendinha
{
    public abstract class Animais : Fazenda
    {
        private double altura;
        private double peso;
                
        public double Altura
        {
            get
            {
                return this.altura;
            }
            set
            {
                this.altura = value;
            }
        }

        public double Peso 
        {
            get
            {
                return this.peso;
            }
            set
            {
                this.peso = value;
            }
        }
        public abstract string Som();
    }
}
