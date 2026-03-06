using UnityEngine;

public class Cones : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float vel;
    public int dano;
    public int Pontos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Destroy(this.gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ConeDeTransito(Vector3 pos)
    {
        Vector3 dir = pos - this.gameObject.transform.position;
        rb2d.linearVelocity = Vector2.down * vel;
    }
}
