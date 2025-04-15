 
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Dragon : MonoBehaviour 
{
    [SerializeField] private string nomePersonagem;
    [SerializeField] private int vida = 100;
    [SerializeField] private int ataque1;
    [SerializeField] private int ataque2;
    [SerializeField] private int ataque3;
    [SerializeField] private int defesa;
    [SerializeField] private int especial = 0;
    [SerializeField] private bool estahVivo = true;
    
    public int Ataque1()
    {
        ataque1 = Random.Range(30, 60);
        return ataque1;
    }

    public int Ataque2()
    {
        ataque2 = Random.Range(30, 60);
        return ataque2;
    }

    public int Ataque3()
    {
        ataque3 = Random.Range(30, 60);
        return ataque3;
    }

    public int Defesa()
    {
        defesa = Random.Range(30, 60);
        return defesa;
    }
    public int Especial()
    {
        int valorAtaque = Random.Range(0, ataque1);
        /*
                if (valorAtaque > 0)
                {
                    Console.WriteLine("ARgh! Sinta Minha Furia!");
                    Console.WriteLine($"{nomePersonagem} ataca com {valorAtaque}");
                }
                else
                {
                    Console.WriteLine($"{nomePersonagem} erra o ataque.");
                }
        */
        especial++;
        return valorAtaque;
    }

    public virtual string GetNome()
    {
        return nomePersonagem;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}        
