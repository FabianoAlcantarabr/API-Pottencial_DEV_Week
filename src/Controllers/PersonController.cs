using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase{

[HttpGet]
    public Pessoa Get(){
        Pessoa pessoa = new Pessoa("Fabiano", 45, "12345678929");
        Contrato novoContrato = new Contrato("abc123", 50.56);
        pessoa.contratos.Add(novoContrato);
        return pessoa;
    }
    [HttpPost]
    public Pessoa Post([FromBody]Pessoa pessoa){
        return pessoa;
    }

    [HttpPut("{id}")]
    public string Update([FromRoute]int id, [FromBody]Pessoa pessoa){
        Console.WriteLine(id);
        Console.WriteLine(pessoa);
        return "Dados do id" + id + "atualizados";
    }

    [HttpDelete("{id}")]
    public string Delete([FromRoute]int id) {
        return "deletato pessoa de Id " + id;
    }
}