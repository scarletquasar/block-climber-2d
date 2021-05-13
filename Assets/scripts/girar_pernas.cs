using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girar_pernas : MonoBehaviour
{
    public float velocidade_perna;

    void Update()
    {
        transform.Rotate(Vector3.forward * -velocidade_perna * Time.deltaTime);
    }
}
