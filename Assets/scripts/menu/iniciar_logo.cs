using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iniciar_logo : MonoBehaviour
{
    bool carregando = false;
    public Button iniciarJogoBtn;

    void Start()
    {
        iniciarJogoBtn.onClick.AddListener(IniciarJogo);
    }

    void IniciarJogo()
    {
        if (!carregando)
        {
            Initiate.Fade("fase1", Color.black, 1f);
            carregando = true;
        }
    }

}
