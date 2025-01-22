using System;
class Program
{
    static void Main()
    {
        bool continuar = true; // Creamos una variable continuar y la inicializamos en verdadero
        while (continuar) // Iniciamos otra vez si continuar es verdadero
        {
            int numero;
            while (true) // Creamos un ciclo while que se repite hasta que el usuario ingrese un número
            {
                Console.WriteLine("Ingrese un número");
                string ingresado = Console.ReadLine();
                //.TryParse() intenta convertir lo ingresado en un número entero. Si se convierte en número devuelve true y guarda el número en la variable numero
                if (int.TryParse(ingresado, out numero)) 
                {
                    break; // Si se convierte en número, salimos del ciclo while
                }
                Console.WriteLine("Se debe ingresar un número entero");
            }

            if (numero < 2) // Si el número ingresado es menor a 2
            {
                Console.WriteLine("El número no es primo");
                Console.WriteLine("¿Quiere ingresar otro número? si o no"); // Preguntamos al usuario si quiere ingresar otro número
                string respuesta = Console.ReadLine().ToLower(); // Guardamos la respuesta del usuario en minúsculas
                continuar = respuesta == "si"; // Si la respuesta es "si" continuar es verdadero, si no, es falso
                continue;
            }

            bool Primo = true; // Creamos una variable esPrimo y la inicializamos en verdadero
            for (int divisionNumeros = 2; divisionNumeros < numero; divisionNumeros++) // Creamos un ciclo for que empieza en 2 y termina en el número ingresado
            {
                if (numero % divisionNumeros == 0) // Si el residuo de dividir el número entre numeros es 0
                {
                    Primo = false; // Cambiamos el valor de Primo a falso
                    break; // Salimos del ciclo for
                }
            }

            if (Primo) // Si Primo es verdadero
            {
                Console.WriteLine("El número es primo");
            }
            else // Si Primo es falso
            {
                Console.WriteLine("El número no es primo");
            }

            Console.WriteLine("¿Quiere ingresar otro número? si o no"); // Preguntamos al usuario si quiere ingresar otro número
            string respuesta2 = Console.ReadLine().ToLower(); // Guardamos la respuesta del usuario en minúsculas
            continuar = respuesta2 == "si"; // Si la respuesta es "si" continuar es verdadero, si no, es falso
        }
    }
}
