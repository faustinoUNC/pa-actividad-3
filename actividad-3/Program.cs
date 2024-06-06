namespace actividad_3
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionIngresada;
            do
            {
                opcionIngresada = RenderizarMenu();

                //Ejecutar la opcion seleccionada
                switch (opcionIngresada)
                {
                    case 1:
                        //Ordenar palabras alfabeticamente
                        //1. Solicitar al usuario 2 palabras con un bucle for
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese 2 palabras");
                        Console.WriteLine("");

                        string[] palabras = new string[2];//---> new string[2] es para indicar que el array tendra 2 elementos, new se usa para crear un objeto
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Ingrese la palabra numero {i + 1}");

                            palabras[i] = Console.ReadLine();
                        }
                        //2. Ordenar las palabras
                        Array.Sort(palabras); //---> Array.Sort es un metodo que sirve para ordenar elementos de un array en base a un criterio, en este caso se ordenan alfabeticamente, puede recibir un segundo parametro que es una funcion lambda que se encarga de comparar los elementos

                        //3. Mostrar las palabras ordenadas
                        Console.WriteLine("");
                        Console.WriteLine("Palabras ordenadas alfabeticamente:");
                        foreach (string _palabra in palabras)
                        {
                            Console.WriteLine(_palabra);
                        }

                        break;



                    case 2:
                        //Ordenar palabras de menor a mayor por longitud
                        //1. Solicitar al usuario upalabras
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese Tres Palabras");
                        Console.WriteLine("");

                        string[] palabras2 = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Ingrese palabra numero {i + 1}");

                            palabras2[i] = Console.ReadLine();
                        }

                        //2. Ordenar las palabras de menor a mayor por longitud
                        Array.Sort(palabras2, (a, b) => a.Length.CompareTo(b.Length)); //---> Array.Sort es un metodo que sirve para ordenar elementos de un array en base a un criterio, en este caso se ordenan por longitud, puede recibir un segundo parametro que es una funcion lambda que se encarga de comparar los elementos
                        //una funcion lambda es una funcion anonima que se puede usar para pasarla como parametro a otro metodo
                        //El aprametro a y b son los elementos a comparar, el metodo CompareTo devuelve un entero negativo si a es menor que b, 0 si son iguales y un entero positivo si a es mayor que b
                        //Si necesitara ordenar de mayor a menor solo tendria que cambiar el orden de a y b en la funcion lambda

                        //3. Mostrar las palabras ordenadas
                        Console.WriteLine("");
                        Console.WriteLine("Palabras ordenadas de menor a mayor por longitud:");
                        foreach (string _palabra in palabras2)
                        {
                            Console.WriteLine(_palabra);
                        }
                        break;



                    case 3:
                        //Encontrar una palabra dentro de una frase y la posicion de la misma
                        //1. Solicitar al usuario una frase y una palabra
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una frase");
                        Console.WriteLine("");

                        string frase = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una palabra");
                        Console.WriteLine("");

                        string palabra = Console.ReadLine();

                        //2. Encontrar la palabra dentro de la frase
                        int posicion = frase.IndexOf(palabra); //---> IndexOf es un metodo que devuelve la posicion de un elemento dentro de una coleccion, en este devuelve la primera posicion en la que se encuentra la palabra, si no se encuentra devuelve -1
                                                               //Si la palabra no se encuentra en la frase devuelve -1
                                                               //cada posicion esta dada por cada caracter de la frase

                        //3. Mostrar la palabra y la posicion
                        Console.WriteLine("");
                        if (posicion == -1)
                        {
                            Console.WriteLine($"La palabra '{palabra}' no se encuentra en la frase '{frase}'");
                        }
                        else
                        {
                            Console.WriteLine($"La palabra '{palabra}' se encuentra en la posicion {posicion + 1} de la frase '{frase}'");
                        }
                        break;

                }
                 regresarAlMenu();

            } while (opcionIngresada!=4);
        }



        //FUNCIONES
        static int RenderizarMenu()
        {
            bool opcionValida = false;
            int opcionIngresada = 0;

            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("*                Trtabajando con cadenas                       *");
            Console.WriteLine(""); ;
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("*  Opcion 1 - ordenar palabras alfabeticamente                 *");
            Console.WriteLine("");
            Console.WriteLine("*  Opcion 2 - ordenar palabras de menor a mayor por longitud   *");
            Console.WriteLine("");
            Console.WriteLine("*  Opcion 3 - Encontrar una palabra dentro de una frase        *");
            Console.WriteLine("");
            Console.WriteLine("*  Opcion 4 - Salir del programa                               *");
            Console.WriteLine("");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            do
            {
                string input = Console.ReadLine();

                opcionValida = int.TryParse(input, out opcionIngresada) && opcionIngresada >= 1 && opcionIngresada <= 4;//.tryParse devuelve un booleano si se pudo convertir o no

                if (!opcionValida)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entre 1 y 4.");
                    Console.WriteLine("");
                }

                if (opcionIngresada == 4)
                {
                    Console.WriteLine("Gracias por usar el programa");
                    break;
                }

            } while (!opcionValida);

            return opcionIngresada;
        }



        static void regresarAlMenu()
        {
            string respuesta;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Desea volver al menu principal");
                Console.WriteLine("Si");
                Console.WriteLine("No");
                respuesta = Console.ReadLine().ToLower();

                if (respuesta == "si")
                {
                   Console.Clear(); 

                }
                else if (respuesta == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Gracias por usar el programa");
                }
                else
                {
                    Console.WriteLine("Respuesta no valida");
                }
            } while (respuesta != "si" && respuesta != "no");
            
        }   

    }
}

           