using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using restArbol.Excepciones;

namespace restArbol.ArbolBinario
{
    public class Nodo_Arbol
    {
        public int valorNodo;
        public Nodo_Arbol nodoIzquierdo;
        public Nodo_Arbol nodoDerecho;
        
        public int nivel;
        public int altura;

        public Nodo_Arbol() {
        }

        public Nodo_Arbol(int nuevoValor, Nodo_Arbol _nodoIzquierdo, Nodo_Arbol _nodoDerecho, Nodo_Arbol _padre) {
            valorNodo = nuevoValor;
            nodoIzquierdo = _nodoIzquierdo;
            nodoDerecho = _nodoDerecho;
        }

        public Nodo_Arbol insertarNodo(int v, Nodo_Arbol n, int nivel) {
            try
            {
                if (n == null)
                {
                    n = new Nodo_Arbol(v, null, null, null);
                    n.nivel = nivel;
                }
                else if (v < n.valorNodo)
                {
                    nivel++;
                    n.nodoIzquierdo = insertarNodo(v, n.nodoIzquierdo, nivel);
                }
                else if (v > n.valorNodo)
                {
                    nivel++;
                    n.nodoDerecho = insertarNodo(v, n.nodoDerecho, nivel);
                }
                else
                {
                    throw new ControlException("Valor de nodo existente");
                }
                return n;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Nodo_Arbol ancestroComun(Nodo_Arbol root, int valorNodo1, int valorNodo2) {
            if (root == null)
            {
                return null;
            }

            // Si el valor de la raíz es igual a uno de los nodos dados, entonces el ancestro es la misma raíz
            if (root.valorNodo == valorNodo1 || root.valorNodo == valorNodo2)
            {
                return root;
            }

            Nodo_Arbol left = ancestroComun(root.nodoIzquierdo, valorNodo1, valorNodo2);
            Nodo_Arbol right = ancestroComun(root.nodoDerecho, valorNodo1, valorNodo2);

            // Si no se ha encontrado ningúno, la raíz es el ancestro común
            if (left != null && right != null)
            {
                return root;
            }

            return (left != null) ? left : right;
        }
    }
    public class _nodosJSON {
        public string nodos { get; set; }
    }
}