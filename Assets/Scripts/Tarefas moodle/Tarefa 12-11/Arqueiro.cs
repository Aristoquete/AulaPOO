using UnityEngine;

public class Arqueiro : Personagem
{
    private int flechas;

   public Arqueiro(string nome, int vida, int flechas) : base(nome, vida)
    {
        this.flechas = flechas;
    }

    public void AtirarFlecha()
    {
        
        if(flechas <= 0)
        {
            Debug.Log("Acabou as flechas");
            return;
        }

        flechas--;
        Debug.Log("quantidade de flechas : " + flechas);
    }
}
