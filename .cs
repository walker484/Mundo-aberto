using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // Dinheiro inicial do jogador
    public double dinheiro = 0;

    // Limite máximo de dinheiro
    public double dinheiroMaximo = 800000000;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AdicionarDinheiro(double valor)
    {
        dinheiro += valor;

        if (dinheiro > dinheiroMaximo)
        {
            dinheiro = dinheiroMaximo;
        }
    }

    public bool GastarDinheiro(double valor)
    {
        if (valor > dinheiro)
            return false;

        dinheiro -= valor;
        return true;
    }
}
