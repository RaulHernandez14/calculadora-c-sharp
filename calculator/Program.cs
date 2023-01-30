// Declarar variables y luego inicializar a cero..
double num1 = 0; double num2 = 0;

//  Mostrar el título como la aplicación de calculadora de la consola C#.
Console.WriteLine("Calculadora\r");
Console.WriteLine("------------------------\n");

// Pide al usuario que escriba el primer número.
Console.WriteLine("Ingrese el primer numero y presione enter");
num1 = Convert.ToDouble(Console.ReadLine());

//  Pide al usuario que escriba el segundo número.
Console.WriteLine("Ingrese el sugundo numero y presiona enter");
num2 = Convert.ToDouble(Console.ReadLine());

// Pide al usuario que elija una opción.
Console.WriteLine("Seleccione una opcion:");
Console.WriteLine("\t1 - Sumar");
Console.WriteLine("\t2 - Restar");
Console.WriteLine("\t3 - Multiplicar");
Console.WriteLine("\t4 - Dividir");
Console.Write("Tu opcion? ");

// Use una declaración de cambio para hacer los cálculos.
switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "2":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "3":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "4":
        // Pida al usuario que ingrese un divisor distinto de cero hasta que lo haga.
        while (num2 == 0)
        {
            Console.WriteLine("Escriba otro numero diferente a cero ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine($"Tu resultado: {num1} / {num2} = " + (num1 / num2));
        break;
}

// Espere a que el usuario responda antes de cerrar.
Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora..");
Console.ReadKey();