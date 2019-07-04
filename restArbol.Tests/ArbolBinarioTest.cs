using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace restArbol.Tests
{
    [TestClass]
    public class ArbolBinarioTest
    {
        [TestMethod]
        public void test_ArbolConstruidoOk()
        {
            //Preparación de ambiente
            restArbol.ArbolBinario.Nodo_Arbol arbolEsperado = new ArbolBinario.Nodo_Arbol();
            restArbol.ArbolBinario._nodosJSON nodos = new ArbolBinario._nodosJSON();

            nodos.nodos = "67,39,76,74,85,83,87";
            arbolEsperado.valorNodo = 67;
            arbolEsperado.altura = 0;
            arbolEsperado.nivel = 0;

            arbolEsperado.nodoDerecho = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.valorNodo = 76;
            arbolEsperado.nodoDerecho.altura = 0;
            arbolEsperado.nodoDerecho.nivel = 1;

            arbolEsperado.nodoDerecho.nodoDerecho = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.nodoDerecho.valorNodo = 85;
            arbolEsperado.nodoDerecho.nodoDerecho.altura = 0;
            arbolEsperado.nodoDerecho.nodoDerecho.nivel = 2;

            arbolEsperado.nodoDerecho.nodoIzquierdo = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.nodoIzquierdo.valorNodo = 74;
            arbolEsperado.nodoDerecho.nodoIzquierdo.altura = 0;
            arbolEsperado.nodoDerecho.nodoIzquierdo.nivel = 2;

            arbolEsperado.nodoDerecho.nodoDerecho.nodoDerecho = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.nodoDerecho.nodoDerecho.valorNodo = 87;
            arbolEsperado.nodoDerecho.nodoDerecho.nodoDerecho.altura = 0;
            arbolEsperado.nodoDerecho.nodoDerecho.nodoDerecho.nivel = 3;

            arbolEsperado.nodoDerecho.nodoDerecho.nodoIzquierdo = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.nodoDerecho.nodoIzquierdo.valorNodo = 83;
            arbolEsperado.nodoDerecho.nodoDerecho.nodoIzquierdo.altura = 0;
            arbolEsperado.nodoDerecho.nodoDerecho.nodoIzquierdo.nivel = 3;


            arbolEsperado.nodoIzquierdo = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoIzquierdo.valorNodo = 39;
            arbolEsperado.nodoIzquierdo.altura = 0;
            arbolEsperado.nodoIzquierdo.nivel = 1;

            

            //Ejecución

            restArbol.ArbolBinario.Arbol arb = new ArbolBinario.Arbol();
            restArbol.ArbolBinario.Nodo_Arbol arbolRespuesta =arb.crearArbol(nodos);

            //Comprobación
            restArbol.ArbolBinario.Nodo_Arbol resp=visitaNodo(arbolEsperado, arbolRespuesta);
            Assert.AreEqual(1,1);
            
        }

        [TestMethod]
        public void test_ArbolConstruidoDistintoDelEsperado()
        {
            //Preparación de ambiente
            restArbol.ArbolBinario.Nodo_Arbol arbolEsperado = new ArbolBinario.Nodo_Arbol();
            restArbol.ArbolBinario._nodosJSON nodos = new ArbolBinario._nodosJSON();

            nodos.nodos = "67,39,76,74,85,83,87";
            arbolEsperado.valorNodo = 67;
            arbolEsperado.altura = 0;
            arbolEsperado.nivel = 0;

            arbolEsperado.nodoDerecho = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.valorNodo = 76;
            arbolEsperado.nodoDerecho.altura = 0;
            arbolEsperado.nodoDerecho.nivel = 1;

            arbolEsperado.nodoDerecho.nodoDerecho = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.nodoDerecho.valorNodo = 85;
            arbolEsperado.nodoDerecho.nodoDerecho.altura = 0;
            arbolEsperado.nodoDerecho.nodoDerecho.nivel = 2;

            arbolEsperado.nodoDerecho.nodoIzquierdo = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.nodoIzquierdo.valorNodo = 74;
            arbolEsperado.nodoDerecho.nodoIzquierdo.altura = 0;
            arbolEsperado.nodoDerecho.nodoIzquierdo.nivel = 2;

            arbolEsperado.nodoDerecho.nodoDerecho.nodoDerecho = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.nodoDerecho.nodoDerecho.valorNodo = 87;
            arbolEsperado.nodoDerecho.nodoDerecho.nodoDerecho.altura = 0;
            arbolEsperado.nodoDerecho.nodoDerecho.nodoDerecho.nivel = 3;

            arbolEsperado.nodoDerecho.nodoDerecho.nodoIzquierdo = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoDerecho.nodoDerecho.nodoIzquierdo.valorNodo = 83;
            arbolEsperado.nodoDerecho.nodoDerecho.nodoIzquierdo.altura = 0;
            arbolEsperado.nodoDerecho.nodoDerecho.nodoIzquierdo.nivel = 3;


            arbolEsperado.nodoIzquierdo = new ArbolBinario.Nodo_Arbol();
            arbolEsperado.nodoIzquierdo.valorNodo = 55;
            arbolEsperado.nodoIzquierdo.altura = 0;
            arbolEsperado.nodoIzquierdo.nivel = 1;



            //Ejecución

            restArbol.ArbolBinario.Arbol arb = new ArbolBinario.Arbol();
            restArbol.ArbolBinario.Nodo_Arbol arbolRespuesta = arb.crearArbol(nodos);

            //Comprobación
            restArbol.ArbolBinario.Nodo_Arbol resp = visitaNodo(arbolEsperado, arbolRespuesta);
            Assert.AreEqual(1, 1);

        }

        [TestMethod]
        public void test_ancestroComun29y44Igual39()
        {
            //Preparación de ambiente
            
            restArbol.ArbolBinario._nodosJSON nodos = new ArbolBinario._nodosJSON();
            nodos.nodos = "67,39,76,28,44,74,85,29,83,87";
            int valorNodo1 = 29;
            int valorNodo2 = 44;

            int resultadoEsperado = 39;


            //Ejecución

            restArbol.ArbolBinario.Arbol arb = new ArbolBinario.Arbol();
            restArbol.ArbolBinario.Nodo_Arbol _arbol= arb.crearArbol(nodos);
            restArbol.ArbolBinario.Nodo_Arbol comun = arb.ancestroComun(_arbol, valorNodo1, valorNodo2);

            int resultadoEjecucion = comun.valorNodo;

            //Comprobación
            Assert.AreEqual(resultadoEsperado,resultadoEjecucion);
        }

        [TestMethod]
        public void test_ancestroComun85y39Igual67()
        {
            //Preparación de ambiente

            restArbol.ArbolBinario._nodosJSON nodos = new ArbolBinario._nodosJSON();
            nodos.nodos = "67,39,76,28,44,74,85,29,83,87";
            int valorNodo1 = 85;
            int valorNodo2 = 39;

            int resultadoEsperado = 67;


            //Ejecución

            restArbol.ArbolBinario.Arbol arb = new ArbolBinario.Arbol();
            restArbol.ArbolBinario.Nodo_Arbol _arbol = arb.crearArbol(nodos);
            restArbol.ArbolBinario.Nodo_Arbol comun = arb.ancestroComun(_arbol, valorNodo1, valorNodo2);

            int resultadoEjecucion = comun.valorNodo;

            //Comprobación
            Assert.AreEqual(resultadoEsperado, resultadoEjecucion);
        }

        private restArbol.ArbolBinario.Nodo_Arbol visitaNodo(restArbol.ArbolBinario.Nodo_Arbol arbol, restArbol.ArbolBinario.Nodo_Arbol arbol2)
        {
            try
            {
                if (arbol == null)
                {
                    return arbol;
                }

                if (arbol.valorNodo != arbol2.valorNodo)
                {
                    throw new Exception();
                }
                visitaNodo(arbol.nodoDerecho, arbol2.nodoDerecho);
                visitaNodo(arbol.nodoIzquierdo, arbol2.nodoIzquierdo);

                return arbol;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
