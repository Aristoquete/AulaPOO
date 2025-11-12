using UnityEngine;

public class ArmasRPG
{
    public string tipo;
    public int quantidadeMunicao;

    public ArmasRPG(string tipo, int quantidadeMunicao)
    {
        this.tipo = tipo;
        this.quantidadeMunicao = quantidadeMunicao;
    }

    public string GetTipo()
    {
        return tipo;
    }
    public void SetTipo(string tipo)
    {
        this.tipo = tipo;
    }
    public int GetQuantidadeMunicao()
    {
        return quantidadeMunicao;
    }
    public void SetQuantidadeMunicao(int quantidadeMunicao)
    {
        this.quantidadeMunicao = quantidadeMunicao;
    }
}