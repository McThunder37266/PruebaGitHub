using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int Objetivo = 1;//ESCRIBE AQUÍ EL NUMERO DE PUNTOS A CONSEGUIR
    public GameObject Oro;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Objetivo; i++)
        {
            int limite = 0;
            int longx;
            int longz;
            Vector3 initialposition;
            Collider[] checkIfOverlaps;
            do
            {
                longx = Random.Range(47, -47);
                longz = Random.Range(47, -47);
                initialposition = new Vector3 (longx, 2f, longz);
                checkIfOverlaps = Physics.OverlapBox(initialposition, Oro.transform.localScale/2, Quaternion.identity);
            }
            while (checkIfOverlaps.Length > 0);
            limite++;
            if (limite == 301)
            {
                break;
            }
            Instantiate(Oro, initialposition, Oro.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
