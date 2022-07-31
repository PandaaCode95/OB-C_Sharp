
Client cliente = new Client("alvaro", 640640640, "C/Aguila 2", "pandaacode@gmail.com", false);

cliente.impresion();

public struct Client
{
    public string name { get;}
    public int tel  { get;}
    public string dir  { get;}
    public string email { get;}
    public bool nClient { get;}

    public Client(string name,int tel, string dir,string email,bool nClient)
    {
        this.name = name;
        this.tel = tel; 
        this.dir = dir; 
        this.email = email; 
        this.nClient = nClient; 
    }
    public string impresion(){
           string res ="Este es el nombre: " + this.name +" El telefono: "+ this.tel + " La dirección: "+ this.dir + " El email: "+ this.email+" Es cliente? " + this.nClient;
           Console.WriteLine(res);
           return res;
 }
}
