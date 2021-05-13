using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ganhar_fase : MonoBehaviour
{
    public GameObject Lava;
    public GameObject[] pernasObj;
    public GameObject[] botoes;
    public AudioSource somFundo;
    public AudioSource somGanhar;
    bool faseGanha = false;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "bloco_azul" && !faseGanha)
        {
            faseGanha = true;
            DesativarPernas();
            DesativarBotoes();
            EventosDeGanhar();
            DesativarMusicaFundo();
        }
    }

    void DesativarPernas()
    {
        foreach(GameObject p in pernasObj)
        {
            p.SetActive(false);
        }
    }

    void DesativarBotoes()
    {
        foreach(GameObject b in botoes)
        {
            b.SetActive(false);
        }
    }

    void DesativarMusicaFundo()
    {
        StartCoroutine(_FadeOutSom(somFundo, 1f));
    }

    void EventosDeGanhar()
    {
        // Ativar música de passar de fase
        StartCoroutine(_AtivarAudioGanhar());
        // Destruir a lava (inimigo que segue o player)
        Destroy(Lava);
    }

    /* Co-rotina de fade out que foi utilizada no som de fundo
     * principal (tema) ao ganhar a fase
     */

    public IEnumerator _FadeOutSom(AudioSource a, float tempo)
    {
        while (a.volume > 0.09) 
        {
            //Usa o volume definido no inspetor como base
            a.volume -= 0.342f * Time.deltaTime / tempo; 
            yield return null;
        }

        //Talvez uma futilidade, mas coloquei pra lidar com possíveis bugs no Time.deltaTime
        a.volume = 0;
    }

    /* Ativação do áudio que deve ser tocado quando o jogador
     * passa de fase
     */

    public IEnumerator _AtivarAudioGanhar()
    {
        new WaitForSeconds(0.9f);
        somGanhar.Play();
        yield return null;
    }

}
