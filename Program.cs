namespace Evidencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("---------------\n CALCULADORA \n---------------");
                Console.WriteLine("Ingrese el primer numero: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---------------");
                Console.WriteLine("[1] Suma");
                Console.WriteLine("[2] Resta");
                Console.WriteLine("[3] Multiplicacion");
                Console.WriteLine("[4] Division");
                Console.WriteLine("INGRESE UNA OPCION Y PRESIONE ENTER");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("---------------");
                switch(opcion)
                    {
                    case 1:
                        Console.WriteLine((numero1) + " + " + (numero2) + " = " + (numero1 + numero2));
                        break;
                    case 2:
                        Console.WriteLine((numero1) + " - " + (numero2) + " = " + (numero1 - numero2));
                        break;
                    case 3:
                        Console.WriteLine((numero1) + " * " + (numero2) + " = " + (numero1 * numero2));
                        break;
                    case 4:
                        if (numero2 == 0) {
                            Console.WriteLine("No se puede dividir entre 0");
                            break;
                        } else {
                            Console.WriteLine((numero1) + " / " + (numero2) + " = " + (numero1 / numero2));
                            break; }
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                    }

                Console.WriteLine("---------------");
                Console.WriteLine("\nSalir?\n[1] Si \n[0] No");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input == 1) {
                    Console.WriteLine("\nSaliendo...");
                    break;
                }

            }
        }
    }
}