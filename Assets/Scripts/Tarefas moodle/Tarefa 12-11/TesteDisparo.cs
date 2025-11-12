using UnityEngine;

public class TesteDisparo : MonoBehaviour
{
    [SerializeField] private Arqueiro arqueiro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        arqueiro = new Arqueiro("Archer", 20, 30);
        Debug.Log(arqueiro);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            arqueiro.AtirarFlecha();
        }
    }
}
