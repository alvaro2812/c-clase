using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace ejercicio_2
{
    class Program
    {
        //declararemos una funcion como string que nos retornara los espacios de a insertar
        public static String contar_espacios(int espacio){

            switch(espacio){
                case 0:
                    return "    ";
                case 1:
                    return "   ";
                  

                case 2:
                    return "  ";
                   

                case 3:
                    return " ";
                   

                
            }
            return "";
        }

        public static void imprimir_tabla(int[,] tabla,int maximo_exterior,int maximo_interior){

            //crearemos las variables interior y exterior para usarlas como indice en la tabla
            int interior=0;
            int exterior=0;
            //declararemos la variable espacio como int, esta la usaremos para obtener los valores
            int espacio=(int)Math.Floor(Math.Log10(tabla[exterior,interior]) + 1); 
        
            //declararemos un array de characteres 
            char[] alfabeto = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Console.Write("|filas   ");


            //crearemos un for que creara la cadena de filas
            for(int i=0;i<maximo_interior;i++){
               
               //en caso que sea igual a 0 pondra el | para iniciar la columna
                if(i==0){
                    
                    Console.Write("|"+char.ToUpper(alfabeto[i])+"   |");
                }
                // en caso de que no sea igual a 0 pondra solo un barra
                else{
                    Console.Write(""+char.ToUpper(alfabeto[i])+"   |");
                }
            }
            Console.Write("\n");

            //crearemos un bucle que leera desde exterior=0 hasta maximo_exterior
             while(exterior<maximo_exterior){

                  
                //escribiremos el numero de la columna
                Console.Write($"|{exterior}       ");
                
                //crearemos un for que se recorrera desde interior=0 hasta maximo_interior
                for(interior=0;interior<maximo_interior;interior++){

                    //asignaremos a espacio el numero de numeros que tenga el valor en el array, esto lo aremos para
                    //cuando llamemos al metodo contar_espacios nos retorne el espacio correspondiente al numero
                    espacio=(int)Math.Floor(Math.Log10(tabla[exterior,interior]) + 1); 

                    //crearemos un if que en caso de que interior sea igual maximo_interior-1 ponga el | para cerrar
                    // la tabla
                    if(interior == maximo_interior-1 && tabla[exterior,interior] != 0){
                        Console.Write("|"+tabla[exterior,interior]+contar_espacios(espacio)+"|");
                    }
                    //en caso de que sea un 0 pondra 00 y un espacio
                    else if(interior == maximo_interior-1 && tabla[exterior,interior] == 0){
                        Console.Write("|"+"00"+contar_espacios(2)+"|");
                    }

                    // en caso de que no se cumpla solo pondra el | al principio
                    else if(tabla[exterior,interior] != 0){
                        Console.Write("|"+tabla[exterior,interior]+contar_espacios(espacio));  
                    }
                    // en caso de que no se cumpla nada solo pondra el | y el  00 al principio
                    else{

                        Console.Write("|"+"00"+contar_espacios(2));
                    }
                }
                      
                Console.Write("\n");
                 
                    
                exterior++;

                   
                    
                   
                   
                   
                }
        }
        public static int[,] salida(int maximo_exterior,int maximo_interior){
            
            //zona declaración variables//
                
                //crearemos la variable interior que usaremos
                //para recorrer el bucle interior 
                int interior=0;

                //crearemos la variable exterior que usaremos
                //para recorrer el bucle exterior 
                int exterior=0;

                //crearemos la variable entrada_str para leer la entrada de datos
                String entrada_str="";

                //crearemos la variable entrada_int para convertir entrada_str a entero
                int entrada_int=1;

                //
                int[,] tabla = new int[maximo_exterior,maximo_interior];
            //fin zona declaración variables//

            //inicio zona bucle//

                //crearemos un bucle que se recorra desde exterior hasta el valor de maximo_exterior
                while(exterior<maximo_exterior && entrada_int !=0){
                    
                    Console.WriteLine($"fila {exterior}");

                   //crearemos un bucle que se recorra desde interior hasta el valor de maximo_interior
                    while(interior<maximo_interior && entrada_int !=0){
                    

                       
                        try{

                            Console.Write($"introduce un valor en la posición {interior} pulsa 0 ");
                            entrada_str=Console.ReadLine();
                            entrada_int=Int32.Parse(entrada_str);
                            tabla[exterior,interior]=entrada_int;
                            //sumaremos una a interior
                            interior++;
                        }
                        catch(FormatException){
                            Console.WriteLine("la entrada de datos no es un numero por favor introduzca uno o pulse 0");
                        }
                    }
                

                    Console.WriteLine("-----Fin Fila----");
                    //sumaremos una a exterior
                    exterior++;
                    //resetaremos interior a 0 para que la siguiente vez vuelva a 
                    //recorrer el bucle
                    interior=0;
                }
                


                //crearemos un bucle que se recorra desde exterior hasta el valor de maximo_exterior
                exterior=0;

               
               


            //fin zona bucle//

            return tabla;
        }


        static void Main(string[] args)
        {
            int [,] salida_tabla = salida(3,2);
           
            imprimir_tabla(salida_tabla,3,2);
        }
    }
}
