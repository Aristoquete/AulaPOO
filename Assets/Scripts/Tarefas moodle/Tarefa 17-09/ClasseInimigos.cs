using UnityEngine;

public class ClasseInimigos 
{
    public string nome;
    public int vida;
    private static int quantidadeInimigos = 0;

    public ClasseInimigos(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
        quantidadeInimigos++;
    }

    public static int getquantidadeInimigos()
    {
        return quantidadeInimigos;
    }

    public ClasseInimigos()
    {
        nome = "SemNome";
        vida = 50;
        quantidadeInimigos++;
    }

    public ClasseInimigos(string nome)
    {
        this.nome = nome;
        quantidadeInimigos++;
    }
    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return nome;
    }

    public void setVida(int vida)
    {
        this.vida = vida;
    }

    public int getVida()
    {
        return vida;
    }

    public string DescricaoInimigo()
    {
        return " Inimigo : " + nome + " Vida : " + vida;
    }
}
