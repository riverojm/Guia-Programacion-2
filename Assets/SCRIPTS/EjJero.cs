using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjJero : MonoBehaviour
{
    public int numerogrande;
    public int numerochico;
    // Start is called before the first frame update
    void Start()
    {
        if (numerogrande < numerochico || numerochico == numerogrande)
        {
            Debug.Log("Ingrese los numeros en el orden correcto, y que no sean iguales");
        }
        else
        {
            while (numerogrande != numerochico)
            {
                Debug.Log(""+numerogrande+"");
                numerogrande--;
            }
            Debug.Log(""+numerogrande+"");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
