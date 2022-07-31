//Ejercicio 1

Console.WriteLine("Porfavor introduce el nombre:");
string name =Console.ReadLine();
Console.WriteLine("Porfavor introduce el email:");
string email= Console.ReadLine();
Console.WriteLine("Porfavor introduce el cupon:");
bool cupon = Convert.ToBoolean(Console.ReadLine());
int price = 35;
float desc =0.15f;
float res=0f;
//Para poner un precio variable unicamente tendriamos que pedirlo y guardarlo en la variable price;
if (cupon)
{
    res =price- price*desc;
    Console.WriteLine("El precio es:" +res);
}
else
{
    res = price;
    Console.WriteLine("El precio es:" +res);
}

//Ejercicio 2

Console.WriteLine("Indique con un número el lenguaje que prefiera.");
Console.WriteLine("1. Java");
Console.WriteLine("2. JS");
Console.WriteLine("3. C#");
Console.WriteLine("4. Python");
Console.WriteLine("5. c++");
int opt = Convert.ToInt32(Console.ReadLine());

switch (opt)
{
    case 1:
        Console.WriteLine("Ha seleccionado la opción Java");
        break;
        
    case 2:
        Console.WriteLine("Ha seleccionado la opción JavaScript");
        break;
    case 3:
        Console.WriteLine("Ha seleccionado la opción C#");
        Console.WriteLine("Hola Mundo");
        break;
    case 4:
        Console.WriteLine("Ha seleccionado la opción Python");
        break;
    case 5:
        Console.WriteLine("Ha seleccionado la opción C++");
        break;
}