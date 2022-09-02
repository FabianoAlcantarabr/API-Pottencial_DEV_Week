using System.Collections.Generic;

namespace src.Models;

public class Pessoa 
{

    public Pessoa()
    {
        this.nome = "template";
        this.idade = 0;
        this.contratos = new List<Contrato>();
        this.ativado = true;
    }

    public Pessoa (string nome, int idade, string cpf){
        this.nome = nome;
        this.idade = idade;
        this.cpf = cpf;
        this.contratos = new List<Contrato>();
        this.ativado = true;
    }

    // nome, idade, cpf, ativa (// para fazer comentário)
    public int Id { get; set; }
    public string nome { get; set; }
    public int idade { get; set; }
    public string? cpf { get; set; }
    public bool ativado { get; set; }
    public List<Contrato> contratos { get; set; }

}