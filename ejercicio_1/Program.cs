using System;

namespace ejercicio_1
{
    class Program
    {


        //crea un programa que lea numeros introducidos por el usuario y que posteriormente sume los impares y multiplique los pares
        
        //crearemos un metodo que lo que hara es leer la entrada del usuario y retornara un array creado por el usuario
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


       //crearemos un metodo para que nos retorne la multiplicación y suma

        public static void multiplicar_y_sumar(int[] tabla){
        //ZONA DEFINICIÓN DE VARIABLES////// 
            int suma=0;
            int multi=1;
         //FIN DEFINICIÓN DE VARIABLES////// 
        
        
         //crearemos un bucle for que se recorrera desde i=0 hasta tabla.length, es decir desde 0 hasta las posiciones ocupadas en la tabla 
            for(int i=0;i<tabla.Length;i++){
                
                //en caso de que el numero al hacerle un mod nos retorne un valor diferente de 0 lo sumara , es decir que en caso de que sea impar
                // sumara el valor de la tabla[i]
                if(tabla[i] % 2 != 0 ){
                    suma=suma+tabla[i];
                  

                }
                 //en caso de que el numero al hacerle un mod nos retorne un valor igual  a 0 lo multiplicara , es decir que en caso de que sea par
                // multiplicara el valor de la tabla[i] 
                else if(tabla[i] % 2 == 0){
                    multi=multi*tabla[i];
                }

            }
            //escribiremo las salida
            Console.WriteLine($"la suma de  los numeros impares es {suma} y la multiplicación de los pares es {multi}");
        }
        static void Main(string[] args)
        {
            //crearemos un nuevo array usando el metodo entrada();
            int[] salida = entrada();
            //llamaremos al metodo multiplicar_y_sumar() pasandole como parametro salida
            multiplicar_y_sumar(salida);

          
        }
    }
}
