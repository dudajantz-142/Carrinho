using System.Collections.Generic;
using UnityEngine;

public class GeraPontos : MonoBehaviour
{
    public GameObject PontosPrefab;
    public List<Transform> posParaCriar; // lista onde cria os meteoros
    public float Timer, TempoParaCriar;
    public float TempoMin, TempoMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime; // Cria um timer para criar o meteoro
        if (Timer >= TempoParaCriar)
        {
            CriaPontos();
            Timer = 0;
            TempoParaCriar = Random.Range(TempoMin, TempoMax);

        }
    }
    public void CriaPontos() // cria o cone
    {
        GameObject obj = Instantiate(PontosPrefab, posParaCriar[Random.Range(0, posParaCriar.Count)].position, this.transform.rotation);
    }
}
