using UnityEngine;

public class Objetos : MonoBehaviour
{
    void Start()
    {
        //personagemRPG1
        PersonagemRPG danca = new PersonagemRPG("Nilou", 75000, 1000);
        danca.SetNome("Nilou");
        danca.SetVida(75000);
        danca.SetMana(1000);

        //personagemRPG2
        PersonagemRPG chapeu = new PersonagemRPG("Chasca", 30000, 2000);
        chapeu.SetNome("Chasca");
        chapeu.SetVida(30000);
        chapeu.SetMana(2000);

        //ArmasRPG1
        ArmasRPG PlumagemEscarlatedoAbutreAstral = new ArmasRPG("Arco", 532);
        PlumagemEscarlatedoAbutreAstral.SetTipo("Arco");
        PlumagemEscarlatedoAbutreAstral.SetQuantidadeMunicao(532);

        //ArmasRPG2
        ArmasRPG ChavedeHierofania = new ArmasRPG("Espada", 0);
        ChavedeHierofania.SetTipo("Espada");
        ChavedeHierofania.SetQuantidadeMunicao(0);
    }
}
