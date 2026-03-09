using System.Collections.Generic;
using UnityEngine;

public class CriaBuff : MonoBehaviour
{
    public GameObject BuffVelprefab;
    public List<Transform> posparacriar;
    public float Timer, TempoParaCrar;
    public float TempMin, TempMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= TempoParaCrar)
        {
            criabuff();
            Timer = 0;
            TempoParaCrar = Random.Range(TempMin, TempMax);
        }
    }
    public void criabuff()
    {
        GameObject obj = Instantiate(BuffVelprefab, posparacriar[Random.Range(0, posparacriar.Count)].position, this.transform.rotation);
    }
}
