using UnityEngine;

public class Narrador : MonoBehaviour
{
    [SerializeField] GameObject buttonEscolha;
    [SerializeField] GameObject buttonSumir;
    [SerializeField] GameObject escrevendoText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(escrevendoText.GetComponent<EscrevaTexto>().FinalizaTexto())
        {
            buttonSumir.SetActive(false);
            AparecerBotoes();
        }
    }

    public void AparecerBotoes()
    {
        if (escrevendoText.GetComponent<EscrevaTexto>().FinalizaTexto())
        {
            buttonEscolha.SetActive(true);
        }
    }
}