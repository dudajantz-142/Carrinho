using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3 (this.transform.position.x, Player.transform.position.y, this.transform.position.z);
    }

}
