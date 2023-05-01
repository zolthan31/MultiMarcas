using Microsoft.AspNetCore.Mvc;
using MultiMarcas.API.Models;

namespace MultiMarcas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{


    public IEnumerable<Product> _produto = new Product[]
        {
            new Product()
            {
                ProdutotId = 1,
                Peca = "Camisa Polo",
                Marca = "Lacoste",
                Valor = "R$ 120,00",
                Tamanhos = "P, M, G",
                Quantidade = 10,
                ImagemURL = "imagem1.png"
            },
            new Product()
            {
                ProdutotId = 2,
                Peca = "Bermuda Mauricinho",
                Marca = "Lacoste",
                Valor = "R$ 100,00",
                Tamanhos = "P, M, G",
                Quantidade = 10,
                ImagemURL = "imagem2.png"
            }
        };
    public ProductController() 
    {        
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
       return _produto;
    }

    [HttpGet("{id}")]
    public IEnumerable<Product> GetById(int id)
    {
       return _produto.Where(produto => produto.ProdutotId == id);
    }    

    [HttpPost]
    public string Post()
    {
        return "teste Produto";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"teste Produto com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"teste Produto com id = {id}";
    }
}
