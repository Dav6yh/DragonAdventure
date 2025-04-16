using UnityEngine;

public class DiretorBatalha : MonoBehaviour
{
    [SerializeField] GameObject buttonSumir;
    [SerializeField] GameObject escrevendoText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AparecerBotoes()
    {
        if (escrevendoText.GetComponent<EscrevaTexto>().FinalizaTexto())
        {
            buttonSumir.SetActive(true);
        }
    }
}
