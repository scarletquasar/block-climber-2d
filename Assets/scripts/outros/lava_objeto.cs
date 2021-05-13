using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava_objeto : MonoBehaviour
{
    bool pegouPlayer = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "bloco_azul" && pegouPlayer == false)
        {
            pegouPlayer = true;
            Initiate.Fade("fase1", Color.red, 1f);
        }
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x + 1 * Time.deltaTime, transform.position.y);
    }
}
