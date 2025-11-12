using UnityEngine;

public class ClasseArma
{
    private int forca;
    private string efeito;

    public ClasseArma(int forca, string efeito)
    {
        this.forca = forca;
        this.efeito = efeito;
    }
    public void setForca(int forca)
    {
        this.forca = forca;
    }

    public int getForca()
    {
        return forca;
    }

    public void setEfeito(string efeito)
    {
        this.efeito = efeito;
    }

    public string getEfeito()
    {
        return efeito;
    }

    public string Atacar()
    {
        return "Ataque simples ";
    }

    public string Atacar(int forca)
    {
        return "Ataque com força " + forca;
    }

    public string Atacar(string efeito)
    {
        return "Ataque com efeito " + efeito;
    }

}
