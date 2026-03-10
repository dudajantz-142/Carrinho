using UnityEngine;
using UnityEngine.SceneManagement;

public class Começar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Bora()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Sair()
    {
        SceneManager.LoadScene("QualFoi");
    }
    public void informações()
    {
        SceneManager.LoadScene("informaçoes");
    }
    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }
}
