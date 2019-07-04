using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using restArbol.Excepciones;

namespace restArbol.ArbolBinario
{
    public class Arbol
    {
        public Nodo_Arbol Raiz;
        
        public Arbol() {

        }

        public Arbol(Nodo_Arbol r) {//Para enviar todo el arbol desde el front
            Raiz = r;
        }
        public Nodo_Arbol crearArbol(_nodosJSON nodos) {
            try {
                if (nodos == null || nodos.nodos == "")
                {
                    throw new ControlException("Nodos no proporcionados");
                }

                Nodo_Arbol _nodoArbol = new Nodo_Arbol();
                var _nodos = nodos.nodos.ToString().Split(',');

                
                for (var i = 0; i < _nodos.Count(); i++)
                {
                    _nodoArbol = this.insertarNodo(Convert.ToInt32(_nodos[i]));
                }
                return _nodoArbol;

            } catch (Exception e) {
                throw e;
            }
        }
        public Nodo_Arbol insertarNodo(int v) {
            try {
                if (Raiz == null)
                {
                    Raiz = new Nodo_Arbol(v, null, null, null);
                    Raiz.nivel = 0;
                }
                else
                {
                    Raiz = Raiz.insertarNodo(v,Raiz, Raiz.nivel);
                }
                return Raiz;
            } catch (Exception e) {
                return Raiz;
            }
        }
        public Nodo_Arbol ancestroComun(Nodo_Arbol root, int valorNodo1, int valorNodo2) {
            try {
                return Raiz.ancestroComun(root,valorNodo1,valorNodo2);
            } catch (Exception e) {
                throw e;
            }
        }
    }
}