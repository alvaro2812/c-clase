using System;

namespace ejercicio_1
{
    class Program
    {



        public static int[] entrada(){

        //ZONA DEFINICIÓN DE VARIABLES////// 

           //declararemos un array de enteros que guardara y retornara los enteros
            int[] numeros = new int[100];

            //declararemos y inicializaremos una variable llamada i que poseera un indice de la tabla
            int i=0;

            //declararemos una variable entrada como String que usaremos para almacenar las lecturas
            string entrada="";
            
        //ZONA FIN DEFINICIÓN DE VARIABLES//////

        //INICIO ZONA INICIAl//
            //Escribiremos pidiendo un numero y procederemos a leer la entrada
            Console.Write("introduce un dato o pulsa 0: ");
            entrada=Console.ReadLine(); 
        //FIN ZONA INICIAl//

            
        //INICIO ZONA BUCLE//

            //crearemos un bucle que se recorrera siempre que entrada no sea igual a "0"
            while(entrada != "0") {
            //INICIO ZONA Try/catch //

                //crearemos un try con un catch que intentara pasar el valor String de entrada
                // a int, en caso de que pueda pasarlo lo almacenara en el array numero y en
                // caso contrario le indicara al usuario que introduzco un valor que no es un entero 
                try{
     
                    //asignara a numeros[i] el valor converido a entero de entrada
                    numeros[i]=Int32.Parse(entrada);
                    i++;

                }
                catch(FormatException){
                    //indicaremos al usuario que a introducido un valor que no es un entero y que meta un numero entero la proxima vez
                    Console.WriteLine("el valor introducido no es un numero por favor introduce un numero");
                
                }
            //FIN ZONA Try/catch //


                //Escribiremos pidiendo un numero y procederemos a leer la entrada
                Console.Write("introduce un dato o pulsa 0: ");
                entrada=Console.ReadLine();

            

            }
        //FIN ZONA BUCLE//


        //INICIO ZONA RETORNO
            return numeros;
        //FIN ZONA RETORNO
        }



        public static void multiplicar_y_sumar(int[] tabla){
        //ZONA DEFINICIÓN DE VARIABLES////// 
            int suma=0;
            int multi=1;
         //FIN DEFINICIÓN DE VARIABLES////// 
        
        
            for(int i=0;i<tabla.Length;i++){
                if(tabla[i] % 2 != 0 ){
                    suma=suma+tabla[i];
                  

                }
                else if(tabla[i] % 2 == 0){
                    multi=multi*tabla[i];
                }

            }
            Console.WriteLine($"la suma de  los numeros impares es {suma} y la multiplicación de los pares es {multi}");
        }
        static void Main(string[] args)
        {

            int[] salida = entrada();
            multiplicar_y_sumar(salida);

          
        }
    }
}
