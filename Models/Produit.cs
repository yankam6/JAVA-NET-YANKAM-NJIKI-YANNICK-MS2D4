namespace CRUD.Models;
public class Produit
{
    public string Identifiant {get; set;}
    public string Code {get; set;}
    public int Nom {get; set;}
    public int Description {get; set;}
    public long Prix {get; set;}
    public DateOnly DatePeremption {get; set;}
}