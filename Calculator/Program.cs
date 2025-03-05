namespace Calculator
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            do
            {
                double n1, n2, resul;
                string[] mensaje = { "suma", "resta", "multiplicación", "división", "potencia" };

                Console.WriteLine("Hola mi estimado usuario, bienvenido a la calculadora de operaciones básicas");
                Console.WriteLine("Por favor, ingrese la operacion a realizar");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Salir");
                
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (opcion == 6)
                {
                    Console.WriteLine("Gracias por usar la calculadora, hasta luego");
                    break;
                }


                Console.WriteLine("Ingrese el primer número para la " + mensaje[opcion - 1]);
                n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número para la " + mensaje[opcion - 1]);
                n2 = Convert.ToDouble(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El resultado de la suma es: " + (n1 + n2));
                        break;
                    case 2:
                        Console.WriteLine("El resultado de la resta es: " + (n1 - n2));
                        break;
                    case 3:
                        Console.WriteLine("El resultado de la multiplicación es: " + (n1 * n2));
                        break;
                    case 4:
                        Console.WriteLine("El resultado de la división es: " + (n1 / n2));
                        break;
                    case 5:
                        Console.WriteLine("El resultado de la potencia es: " + Math.Pow(n1, n2));
                        break;
                }

                Console.WriteLine("Gracias por usar la calculadora, presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

            } while (true);
        }
    }
}
