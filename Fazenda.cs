using System;
using System.Collections.Generic;
using System.Text;

namespace Fazendinha
{
    public class Fazenda
    {
        public List<Animais> lista_de_animais = new List<Animais>();

        private double valor_leite_por_litro;
        private double valor_ovo_por_unidade;


        public double Valor_leite_por_litro
        {
            get
            {
                return valor_leite_por_litro;
            }
            set
            {
                valor_leite_por_litro = value;
            }
        }        

        public double Valor_ovo_por_unidade
        {
            get
            {
                return valor_ovo_por_unidade;
            }
            set
            {
                valor_ovo_por_unidade = value;
            }
        }

        public double receita_mensal(List<double> quantidade, double valor_produto)
        {
            double receita, quant_ovo = 0;
            for(int i = 0; i < quantidade.Count; i++)
            {
                quant_ovo = quant_ovo + quantidade[i];
            }
            receita = quant_ovo * valor_produto * 30;
            return receita;
        }

        public void insere_lista(Animais animal)
        {
            lista_de_animais.Add(animal);
        }       
    }
}
