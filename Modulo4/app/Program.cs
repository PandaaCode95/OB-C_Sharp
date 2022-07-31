/*
//Ejercicio 1

Console.WriteLine("Introduce la tabla de multiplicar que quieres:");
int num =Convert.ToInt32(Console.ReadLine());
int mul =0;
int res=0;
while (mul < 11)
{
    res= num*mul;
    Console.WriteLine(res);
    mul++;
}

//Ejercicio 2
int pos = 0;
int neg = 0;
do
{
    Console.WriteLine("Introduce el numero que quieres comprobar:");
    num =Convert.ToInt32(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("El número es negativo");
            neg++;
        }else if(num > 0)
        {
            Console.WriteLine("El número es positivo");
            pos++;
        }
        else
        {
            Console.WriteLine("El cero no cuenta");
        }
}while ((pos < 5) && (neg < 5));
Console.WriteLine("Has introducido: "+ neg+ "numeros negativos");
Console.WriteLine("Has introducido: "+ pos+ "numeros positivos");
*/

//Ejercicio 3
Console.WriteLine("Introduce la cantidad que quieres dibujar:");
int cant = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el ancho:");
int ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el alto:");
int alto = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce si quiere relleno o no (boolean) :");
bool relleno = Convert.ToBoolean(Console.ReadLine());
char dib='*';

//Cant veces se repite la creacion de array;
if (relleno == true)
{


for(int i = 0 ; i < cant; i++)
{
    Console.WriteLine("Dibujo n:" + i);
    char[,] dibujo = new char[ancho,alto];

    for(int j = 0 ; j < ancho; j++)
    {
        for(int k = 0 ; k < alto; k++)
        {
           
            Console.Write(dibujo[j,k]);
        }
        Console.Write("\n");
    }
}
}
else
{

    for(int i = 0 ; i < cant; i++)
      {
         Console.WriteLine("Dibujo n:" + i);
        char[,] dibujo = new char[ancho,alto];

        for (int j = 0 ; j < ancho; j++)
        {
            for (int k = 0; k < alto; k++)
			{
                if ((k == 0 || k == alto - 1)||(j==0 || j == ancho - 1))
                {
                dibujo[j,k] = dib;
                    Console.Write(dibujo[j,k]);
                }
                else
                {
                    dibujo[j,k] = ' ';
                    Console.Write(dibujo[j,k]);
                }
			}
            Console.Write("\n");
        }     
      }
}

