using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_tree
{
    public class Arbol
    {
        public Object T;
        class Nodo<T>
        {
            public T info;           
            public Nodo<T> izq, derec;

            public Nodo(T miinfo)
            {
                this.info = miinfo;
                this.izq = null;
                this.derec = null;
            }
            Nodo<T> raiz;
            public void Agregar_nodoPadre( T info1)
            {
                if (raiz == null)
                {
                    Nodo<T> raiz = new Nodo<T>(info1);                  
                }
                else if ( raiz != null)
                {
                    Console.WriteLine("Nodo padre existente agregar esta info al nodo hijo izq(1) o derecho(2)");
                    string op = Console.ReadLine();
                    if (op == "1")
                    {   

                        this.Agrg_hijoI(info1);
                    }
                    if (op == "2")
                    {

                        this.Agrg_hijoI(info1);
                    }
                    Nodo<T> raiz = new Nodo<T>(info1);
                }

            }
            public void Agrg_hijoD( T inf)
            {
                this.derec = new Nodo<T>(inf);
            }
            public void Agrg_hijoI(T inf)
            {
                this.izq = new Nodo<T>(inf);
            }
            public void Informacion(Nodo<T> N)
            {
                Console.WriteLine(" info nodo padre: " + N.info +"\nnodo hijo izq: " + N.izq.info + "\nnodo hijo derec: " + N.derec.info);
            }
            public void Eliminarnodo(Nodo<T> N)
            {
                N = null;
            }
        }


    }

}
