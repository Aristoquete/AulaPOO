    using UnityEngine;

public class ObjetosCena : MonoBehaviour
{
    void Start()
    {
        //Inimigos
        ClasseInimigos goblin = new ClasseInimigos("Goblin", 100);
        Debug.Log(goblin.DescricaoInimigo());

        ClasseInimigos pai = new ClasseInimigos();
        Debug.Log(pai.DescricaoInimigo());

        ClasseInimigos fada = new ClasseInimigos("Fada");
        Debug.Log(fada.DescricaoInimigo());

        ClasseInimigos jefersson = new ClasseInimigos("DiscL", 38);
        Debug.Log(jefersson.DescricaoInimigo());

        ClasseInimigos vodka = new ClasseInimigos("Vodka", 200);
        Debug.Log(vodka.DescricaoInimigo());

        ClasseInimigos churros = new ClasseInimigos("Churros", 10);
        Debug.Log(churros.DescricaoInimigo());

        ClasseInimigos penteado = new ClasseInimigos("Penteado", 30);
        Debug.Log(penteado.DescricaoInimigo());

        Debug.Log("Total de inimigos: " + ClasseInimigos.getquantidadeInimigos());

        //armas
        ClasseArma arco = new ClasseArma(50, "queimação");
        Debug.Log(arco.Atacar());
        Debug.Log(arco.Atacar(arco.getForca()));
        Debug.Log(arco.Atacar(arco.getEfeito()));
    }

    void Update()
    {
        
    }
}
