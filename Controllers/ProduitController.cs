using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers;

[ApiController]
[Route("[controller]")]

public class Produitcontroller : ControllerBase
{
    private static List<Produit> produits = new();

    [HttpGet]
    [Route("GetAll")]

    public List<Produit> GetAll()
    {
        return produits;
    }

    [HttpGet]
    [Route("Get/{identifiant}")]
    public Produit? Get (string identifiant)
    {
        return produits.Where( x => x.Identifiant == identifiant).FirstOrDefault();
    }

    [HttpPost]
    public void Post(Produit produit)
    {
        produits.Add(produit);
    }

    [HttpPut]
    public void Put(Produit produit)
    {
        int index = produits.FindIndex(y => y.Identifiant == produit.Identifiant);
        if (index >= 0)
        {
            produits[index] = produit;
        }
    }

    [HttpDelete]

    public void Delete(string identifiant)
    {
        int index = produits.FindIndex(y => y.Identifiant == identifiant);
        if (index >= 0)
        {
            produits.RemoveAt(index);
        }
    }



}