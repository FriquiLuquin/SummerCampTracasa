using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAction
{
    internal class Ejemplo
    {
        public void EjemploFunc1()
        {
            // Expresion Lambda
            Func<string> holaMundoExpresion =
                // Parametros
                ()
                // Operador Lambda
                =>
                // Delegado / Metodo Anonimo / Expresion
                "Hola mundo!";

            Console.WriteLine(holaMundoExpresion);
            Console.WriteLine(holaMundoExpresion());

            // Expresion Lambda
            Func<string> holaMundoBloque =
                // Parametros
                ()
                // Operador Lambda
                =>
                // Delegado / Metodo Anonimo / Expresion
                {
                    var cadena = "Hola mundo!";
                    return cadena;
                };

            Console.WriteLine(holaMundoBloque);
            Console.WriteLine(holaMundoBloque());
        }

        public void EjemploFunc2()
        {
            Func<int, int, int> sumar =
                // Parametros
                (a, b)
                // Operador Lambda
                =>
                // Delegado / Metodo Anonimo / Expresion
                {
                    var suma = a + b;
                    return suma;
                };

            Console.WriteLine(sumar(10, 20));

            Func<int, int, int> sumarRedux = (a, b) => a + b;
            Console.WriteLine(sumarRedux(10, 20));
        }

        public void EjemploAction()
        {
            // Usando metodo como parametro
            TestAction(Accion, 1);

            // Usando expresion lambda
            TestAction((numero) => Console.WriteLine($"En el parametro Accion {numero}"), 1);

            TestAction((numero) =>
            {
                Console.WriteLine($"En el parametro Accion {numero}");

            }, 2);

            // Usando una variable (npo declarar como var)
            Action<int> accion = (numero) => { Console.WriteLine($"En la variable Accion {numero}"); };

            TestAction(accion, 1);


            // Lista de Acciones
            List<Action<int>> listaAcciones = new List<Action<int>>
            {
                Accion,
                (numero) => Console.WriteLine($"En el parametro Accion {numero}"),
                accion
            };

            foreach (var elemAccion in listaAcciones)
            {
                TestAction(elemAccion, 1);
            }


        }

        public void TestAction(Action<int> accion, int numero)
        {
            accion(numero);
        }

        public void Accion(int numero)
        {
            Console.WriteLine($"En el metodo Accion {numero}");
        }
    }
}
