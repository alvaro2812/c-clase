using System;

namespace ejercicio_4
{
    class Program
    {
        //hacer un programa que obtenga el maximo numero de un array de enteros
        public static int retornar_mayor(int[] numeros){

            // declararemos la variable mayor como entero
            int mayor=0;    



            
            //crearemos un bucle que recorre desde i=0 hasta numero.length
            for(int i=0;i<numeros.Length;i++){

                //crearemos un bucle que recorre desde a=0 hasta numero.length
                for(int a=0;a<numeros.Length;a++){

                    //en caso de que el numero alamacenado en numeros[a] sea mayor a la variable mayor
                    // guardara el valor de numeros[a] en mayor
                    if(numeros[a]>mayor){
                        mayor=numeros[a];
                       
                    }
                }


            }

            return mayor;
        }
        static void Main(string[] args)
        {

            //crearemos un array de enteros llamado numeros que usaremos para probar el metodo
            int[] numeros = new int[100];

            //crearemos un for que insertara valores de prueba hasta 10
            for(int i=0;i<10;i++){
                numeros[i]=i;
            }

            //llamaremos al metodo retornar_mayor 
            Console.WriteLine("el mayor es "+ retornar_mayor(numeros));

        }
    }
}
