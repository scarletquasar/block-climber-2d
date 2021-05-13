using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir_camera : MonoBehaviour
{
    public GameObject alvo;
    public float velocidade;

    void Start()
    {
        transform.position = new Vector3(alvo.transform.position.x, alvo.transform.position.y, transform.position.z);
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(alvo.transform.position.x, alvo.transform.position.y, transform.position.z), velocidade * Time.deltaTime);
    }
}