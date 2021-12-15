using System;
using System.Linq;
using System.Security;

namespace ejercicio_6
{
    class Program
    {


        
        //crearemos un metodo que  lo que  hara sera  obtener el mayor del array

        // este metodo pedira dos parametros,  el array y su longitud
        public static int obtener_mayor(int[] tabla,int size){

            //declararemos la variable mayor como int, esta la usaremos para comparar el valor
            // de la tabla y el mayor
            int mayor=1;

            //declararemos la variable mayor_pos como int, esta se usara para almacenar
            // la posicion del numero mayor que se detecto
            int mayor_pos=0;

            //crearemos un bucle que se recorrera de a=0 hasta el parametro que nos indica el 
            //tamaño del array(size)
            for(int a=0;a<=size;a++){
               
                    //en caso de que el valor que haya en la posicion de la tabla sea mayor
                    // al de la variable mayor sera cierto y asignara a mayor el valor de 
                    //la tabla y a mayor_pos su posicion en la tabla
                    if(tabla[a]>=mayor){
                        mayor=tabla[a];
                        mayor_pos=a;    
                    }
                
            }
            //una vez hecho esto retornara el valor de mayor_pos , es decir retornara
            //la posicion en la  que se encuentra el mayor

            return mayor_pos;
        }

        //crearemos un metodo que ordenara y le pediremos que nos pase por parametro 
        //el array a filtrar y su tamaño
        public static void ordenar(ref int[] tabla,int size){


            //crearemos la variable intercambio que usaremos para realizar el intercambio
            int intercambio=0;

            //declararemos la variable  pos para almacenar la posicion en la que encuentra
            //el mayor 
            int pos =0;

            //crearemos la variable f para que obtenga el tamaño total de la tabla
            int f=tabla.Length-1;

            //crearemos un bucle que se recorrera siempre que f sea mayor a 0
            while(f>=0){
                //llamaremos al metodo  obtener_mayor y alamacenaramos su salida en pos
                pos=obtener_mayor(tabla,size);
                //asignaremos a la variable intercambio el valor de taba[pos]
                intercambio=tabla[pos];
                //cambiaremos el valor de tabla[pos] al valor de tabla[f]
                tabla[pos]=tabla[f];

                //a tabla[f] le asignaremos el de intercambio
                tabla[f]=intercambio;

                //restaremos una a f
                f--;
            }
            //crearemos un for que imprimira los valores de tabla[i] salvo 0 ya que al ordenar
            //los valores de menor a mayor las posiciones vacias ocuparan el valor 0 y por
            //tanto los primeros valores seran todos 0
            for(int i=0;i<f;i++){
                
                if(tabla[i]!=0){
                    Console.WriteLine(tabla[i]);
                }
            }
           
        }

        //crearemos el metodo entrada que nos retornara el array con sus campos
        // y pedira un parametro para almacenar la longitud de la tabla
        public static int[] entrada(ref int i){


            
            //definiremos la variable entrada_string para realizar la lectura de consola
            String entrada_string ="";

            //crearemos un nuevo array en el que almacenaremos las lecturas del usuario y
            //que posteriormente retornaremos
            int[] tabla = new int[100];

            //crearemos un do while que se repetira hasta que entrada_string sea igual a 0
            do{
              

                //crearemos un try catch que en caso de que cuando el valor introducido 
                //no sea un numero nos muestre un error por pantalla 
                try{

                    //le pediremos al usuario que escriba un numero o que pulse 0
                    Console.Write("Introduce un numero o pulsa 0: ");

                    //leeremos el input del usuario y lo almacenaremos en entrada_string
                    entrada_string=Console.ReadLine();

                    //crearemos un if que en caso de que el valor no sea 0 nos lo inserte 
                    // en la tabla y le sume a i++, usaremos la funcion int32.parse para
                    //convertir el texto a numero
                    if(Int32.Parse(entrada_string) != 0){
                        tabla[i]=Int32.Parse(entrada_string);
                        i++;
                    }


                }
                //en caso de que el texto no sea un numero y no pueda convertirlo retornar al usuario el 
                //siguiente mensaje, esto lo haremos para que no surgan errores
                catch(FormatException){
                     Console.WriteLine("El valor introducido no es un numero, escribe uno o pulsa 0");

                }
            }
            while(entrada_string!="0");
            i--;
            return tabla;
        }
        static void Main(string[] args)
        {

            int i=0;
            int[] tabla = entrada(ref i);
            ordenar(ref tabla,i);
        }
    }
}
