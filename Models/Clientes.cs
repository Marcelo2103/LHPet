using System.Reflection.Metadata;

namespace LhPet.models;

public class Cliente
{
    /* No trecho de código a seguir são criados os atributos de clientes e seus gitters  e setters correspondentes.*/

public int Id { get; set; }
public string? Nome { get; set; }
public string? Cpf { get; set; }
public string? Email { get; set; }
public string? Paciente { get; set; }

/* Neste trecho do código, é criado o Construtor do model Cliente e determinado quais os parâmentros são necessários na criação das instâncias*/

public Cliente(int id, string nome, string cpf,string email, string paciente)
{
this.Id = id;
this.Nome = nome;
this.Cpf = cpf;
this.Email = email;
this.Paciente = paciente;
}
}


   
    

