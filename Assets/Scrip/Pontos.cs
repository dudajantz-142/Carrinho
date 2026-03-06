using UnityEngine;

public class Pontos : MonoBehaviour
{
    public Rigidbody2D Rb2d;
    public float Vel;
    public int Pontinhos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pontos")) // caso o tiro acerte alguem com a teg meteoro
        {
            Destroy(collision.gameObject);
        }
    }
}
