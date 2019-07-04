using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using restArbol.ArbolBinario;

namespace restArbol.Controllers
{
    public class ArbolController : ApiController
    {
        [Route("arbol")]
        [HttpPost]
        public IHttpActionResult insertarNodo([FromBody] _nodosJSON nodos) {
            try {

                Arbol arbol=new Arbol();
                Nodo_Arbol _nodoArbol=arbol.crearArbol(nodos);

                return Ok(_nodoArbol);

            } catch (Exception e) {
                if (e.Message == "Valor de nodo existente" || e.Message== "Nodos no proporcionados") {
                    return Content(HttpStatusCode.InternalServerError, e.Message);
                }
                return Content(HttpStatusCode.BadRequest, "Ocurrió un error interno al intentar insertar un nodo en el arbol binario.");
            }
        }

        [Route("ancestro")]
        [HttpGet]
        public IHttpActionResult ancestroComun(string nodos, int valorNodo1, int valorNodo2) {
            try {
 
                Arbol arbol = new Arbol();
                _nodosJSON _nodos = new _nodosJSON();
                _nodos.nodos = nodos;

                Nodo_Arbol _nodoArbol = arbol.crearArbol(_nodos);
                Nodo_Arbol comun = arbol.ancestroComun(_nodoArbol, valorNodo1, valorNodo2);

                return Ok(comun);

            } catch (Exception e) {
                return Content(HttpStatusCode.BadRequest, "Ocurrió un error interno al intentar calcular el ancestro común.");
            }

        }
        
    }
}
