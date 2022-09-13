    // See https://aka.ms/new-console-template for more information
using System;
class Program {

public class Autor{
    private string nome;
    private int idade;

public Autor(string nome, int idade){
    this.nome = nome;
    this.idade = idade;
}
public string getNome(){
    return this.nome;
}

public int getIdade(){
    return this.idade;
}

public int fazerAniversario(){
    this.idade++;
    return this.idade;
}
}
public class Livro{
    private Autor a;
    private string titulo;

public Livro(Autor a, string titulo){
    this.a = a;
    this.titulo = titulo;
}
public Autor getAutor(){
    return this.a;
}
public string getTitulo(){
    return this.titulo;
}
}
public static void Main (string[] args) {
    Autor a = new Autor("Fulano", 40);
    Livro livro = new Livro(a, "O Capital");
    Console.WriteLine(a.getNome());
    Console.WriteLine(a.getIdade());
    Console.WriteLine(livro.getAutor().getNome());
    Console.WriteLine(livro.getTitulo());
    }
}