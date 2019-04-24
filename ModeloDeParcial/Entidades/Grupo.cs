using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> _mascotas;
        private string _nombre;
        static EtipoManada _tipo;

        #region CONSTRUCTORES
        private Grupo()
        {
            this._mascotas = new List<Mascota>();
        }
        static Grupo()
        {
            Grupo._tipo = EtipoManada.Unica;
        }
        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }
        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Grupo._tipo = tipo;
        } 
        #endregion

        #region PROPIEDADES
        private EtipoManada tipo;

        public static EtipoManada Tipo
        {
            set { Grupo._tipo = value; }
        } 
        #endregion

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool rtn = false;

            foreach (Mascota item in g._mascotas)
            {
                if (item.Equals(m))
                {
                    rtn = true;
                }
            }
            return rtn;
        }
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g == m)
            {
                Console.WriteLine(m.Nombre + ", Ya se encuentra en la lista");
            }
            else
            {
                g._mascotas.Add(m);
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g._mascotas.Remove(m);
            }
            else
            {
                Console.WriteLine(m.Nombre + ", No se encuentra en la lista");
            }
            return g;
        }

        public static implicit operator string (Grupo g)
        {
            string rtn = "";

            //switch (g.tipo)
            //{
            //    case EtipoManada.Mixta:
            //        rtn = "Grupo: " + g._nombre + " Tipo: Mixta\n Cantidad en grupo: " + g._mascotas.Count();

            //        foreach (Mascota item in g._mascotas)
            //        {
            //            if (g.tipo == EtipoManada.Mixta)
            //            {
            //                rtn += item.ToString();
            //            }
            //        }
            //        break;
            //}

            //ERA AL REVES, LA PUTA QUE LO PARIO
            return rtn;
        }

    }
}
