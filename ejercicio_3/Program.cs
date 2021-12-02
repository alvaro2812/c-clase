using System;
using System.Diagnostics.Tracing;

namespace ejercicio_3
{
    class Program
    {


        // crearemos un metodo que pedira un numero para factorizar y nos lo retornara
        // ya factorizado en forma de integer
        public static int retornar_factorial(int numero_dado){

            //declararemos la variable saldia_factorial como 1, esta la usaremos en la
            // factorización
            int salida_factorial=1;

            //crearemos un bucle for que se recorrera desde  i=1 hasta el numero _dado+1, esto
            // se hace asi ya que si lo hicieramos con i<numero_dado solo nos recorreria desde el 0 hasta el 4
            // si quisieramos factorizar el numero 5
            for(int i=1;i<numero_dado+1;i++){
                salida_factorial=salida_factorial*i;
            }
            return salida_factorial;

        }


        static void Main(string[] args)
        {
            //declararemos la variable entrada para leer los numeros
            String entrada="";
            //crearemos la variable entrada_int para convertir el valor String de entrada
            //a entrada_int
            int entrada_int =  0;

            //crearemso un bucle que leera los datos del usuario hasta que introduzca 0
            do{
                //crearemos un try/catch que en caso de que el texto de entrada sea un numero
                // calcule el factorial y en caso contrario se lo indique al usuario               
                try{
                    // escribiremos al usuario pidiendo un numero o un 0 para terminar el bucle
                    Console.Write("intoduce el numero a factorizar o pulsa 0: ");

                    //leeremos la entrada del usuario
                    entrada=Console.ReadLine();

                    //convertiremos el numero a int32
                    entrada_int=Int32.Parse(entrada);

                    //imprimiremos la salida que obtengamos del metodo retornar_factorial indicando que es el factorial
                    // del numero almacenado en entrada_int
                    Console.WriteLine($"el factorial de {entrada_int} es "+retornar_factorial(entrada_int));
                }
                catch(FormatException){
                    //imprimiremos pidiendole al usuario que meta un valor que sea valido, es decir un numero
                    Console.WriteLine("el valor introducido no es un numero por favor introduce un numero o pulsa 0");
                }
            }while(entrada != "0");
           
           
        }
    }
}
