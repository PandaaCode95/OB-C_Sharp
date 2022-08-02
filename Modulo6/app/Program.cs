var coches = new List<string>();
coches.Add("Ford");
coches.Add("Nissan");
coches.Add("Peugeot");

foreach(var co in coches)
{
    Console.WriteLine(co + "coches");
}

List<Elemento> ele = CrearLista();
/*
foreach(Elemento elemento in ele)
{
    Console.WriteLine(elemento.name);
    Console.WriteLine(elemento.nAtom);
}
*/
var query = 
    from el in ele
    where el.name =="Potasio"
    select el;


Console.WriteLine(query.name);

/*
foreach(var ele2 in query)
{
    Console.WriteLine(ele2.name);
}*/
static List<Elemento> CrearLista()
{
    return new List<Elemento>
    {
        {new Elemento(){simbolo="k",name="Potasio",nAtom=20}},
        {new Elemento(){simbolo="Na",name="Sodio",nAtom=12}},
        {new Elemento(){simbolo="Li",name="Litio",nAtom=10}}

    };
}
public class Elemento
{
    public string simbolo { get; set;}
    public string name { get; set;}
    public int nAtom { get; set;}

}