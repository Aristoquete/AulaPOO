using UnityEngine;

public class PersonagemRPG
{
    public string nome;
    public int vida;
    public int mana;

    public PersonagemRPG(string nome, int vida, int mana)
    {
        this.nome = nome;
        this.vida = vida;
        this.mana = mana;
    }
    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public int GetVida()
    {
        return vida;
    }
    public void SetVida(int vida)
    {
        this.vida = vida;
    }
    public int GetMana()
    {
        return mana;
    }

    public void SetMana(int mana)
    {
        this.mana = mana;
    }
}
