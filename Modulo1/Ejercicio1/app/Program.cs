//Pedimos por consola la var;
string nombre = Console.ReadLine();
//La imprimimos:
Console.WriteLine("Hola, como estas:" + nombre +"?");
//Pedimos todos los datos de datetime
DateTime now = DateTime.Now;
//Guardamos lo que nos interesa y lo imprimimos.
var hora = now.TimeOfDay;
Console.WriteLine("La hora es : "+hora);