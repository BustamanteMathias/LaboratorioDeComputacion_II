using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceBoligrafo
{
    class Boligrafo
    {
        //ATRIBUTO

        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        //METODOS

        private void SetTinta(short tinta)
        {
            short nivelTinta = this.tinta;

            if((nivelTinta + tinta) >= 0 && (nivelTinta + tinta) <= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = short.Parse((nivelTinta + tinta).ToString());
                //Console.WriteLine("QUEDAN " + this.tinta);
                //Recargar();
                //Console.WriteLine("QUEDAN " + this.tinta);
            }
        }

        public void Recargar()
        {
            this.tinta = Boligrafo.cantidadTintaMaxima;
        }
        
        public short GetTinta()
        {
            short retornoNivelTinta = this.tinta;
            return retornoNivelTinta;
        }

        public ConsoleColor GetColor()
        {
            ConsoleColor retornoConsoleColor = this.color;
            return retornoConsoleColor;
        }

        public bool Pintar (int gasto, out string dibujo)
        {
            short nivelTinta = GetTinta();
            short auxGasto = short.Parse( (gasto * -1).ToString() );

            bool validarPinto;

            dibujo = "";
            
            if((nivelTinta-gasto) >=0 && (nivelTinta - gasto) <= Boligrafo.cantidadTintaMaxima)
            {
                for (int i=0; i < gasto; i++)
                {
                    dibujo = dibujo + "*";
                }

                SetTinta(auxGasto);

                validarPinto = true;
            }
            else
            {
                dibujo = "SIN TINTA SUFICIENTE";
                validarPinto = false;
            }

            return validarPinto;
        }

        //CONSTRUCTOR

        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            Console.BackgroundColor = color;
        }
    }
}
