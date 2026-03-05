using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
    
{
    public int Pontos;
    public int Vida;
    public float Vel, velandar;
    public float LimiteRot;
    public Rigidbody2D rbd2;
    public float eixoY;
    public float eixoX;
    public Vector2 Dir;
    public TextMeshProUGUI TextoVida;
    public TextMeshProUGUI TextoPontos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eixoX = Input.GetAxis("Horizontal") * -1;
        rbd2.AddTorque(eixoX * Vel);
        if (Keyboard.current.wKey.isPressed) // define as teclas de movimenta��o
        {
            eixoY = 1;
        }
        else
        {
            eixoY = 0;
        }
        Dir = this.transform.up * eixoY * velandar;
        rbd2.linearVelocity = Dir;
        if (rbd2.angularVelocity <= -LimiteRot)
        {
            rbd2.angularVelocity = -LimiteRot;
        }
        else if (rbd2.angularVelocity >= LimiteRot)
        {
            rbd2.angularVelocity = LimiteRot;
        }
    }

    public void Bateu(int dano)
    {
        Vida = Vida - dano;
        TextoVida.text = "Vida:" + Vida;
        if (Vida <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
    public void AdicionaPontos(int PontosParametro)
    {
        Pontos = Pontos + PontosParametro;
        TextoPontos.text = "Pontos: " + Pontos; 
    }

}
