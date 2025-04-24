using System.Collections;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;

public class EscrevaTexto1L : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI texto;
    [TextArea]
    [SerializeField] private string mensagem1;
    [TextArea]
    

    [SerializeField] private float VelocidadeDigitacao = 0.02f;

    private bool escrevendo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        texto.text = "";
        StartCoroutine(DigitarTexto(mensagem1));
    }

    private IEnumerator DigitarTexto(string mensagem)
    {
        foreach (char letra in mensagem)
        {
            texto.text += letra;
            yield return new WaitForSeconds(VelocidadeDigitacao);
        }
    }


    
}



