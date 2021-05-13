using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inverter_btn : MonoBehaviour
{
    public GameObject[] pernasObj;
    public Button inverterBtn;
    void Start()
    {
        inverterBtn.onClick.AddListener(InverterVelocidade);
    }

    void InverterVelocidade()
    {
        foreach (GameObject p in pernasObj)
        {
            float baseX = p.transform.localScale.x;
            float baseY = p.transform.localScale.y;

            p.transform.localScale = new Vector3(baseX * -1, baseY, 0);
            p.GetComponent<girar_pernas>().velocidade_perna *= -1;
        }
    }
}
