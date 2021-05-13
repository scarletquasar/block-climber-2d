using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class opcoes_pernas : MonoBehaviour
{
	/*
	 * Variáveis utilizadas para armazenar os objetos das pernas e dos botões
	 * ativadores - Escolhi utilizar Arrays pela praticidade
	 */ 
	public GameObject[] pernasObj;
	public Button[] botoesPernas;

	/*
	 * Para evitar fazer um código maior (vários voids como na versão inicial
	 * que fiz onde um era para cada perna pensei em fazer um switch porém
	 * me deparei com o erro de "Não foi possível converter 'void' em 'UnityEvent'"
	 * mas logo consegui resolver chamando a função diretamente pelo delegate
	 */
	 
	void Start()
	{
		botoesPernas[0].onClick.AddListener(delegate { PernaSwitch(0); });
		botoesPernas[1].onClick.AddListener(delegate { PernaSwitch(1); });
		botoesPernas[2].onClick.AddListener(delegate { PernaSwitch(2); });
	}

	/* Esse é o switch de ações para ativação/desativação das pernas, ainda acho que
	 * o código pode ser muito melhorado porém por enquanto este protótipo está estável
	 * e legal resolvi mantê-lo desse jeito e inserir este comentário
	 */
	 
	void PernaSwitch(int perna) 
	{
		switch(perna)
        {
			case 0:
				if (!pernasObj[0].activeInHierarchy)
				{
					pernasObj[0].SetActive(true);
					pernasObj[1].SetActive(false);
					pernasObj[2].SetActive(false);
				}
				else
				{
					pernasObj[0].SetActive(false);
				}
				break;

			case 1:
				if (!pernasObj[1].activeInHierarchy)
				{
					pernasObj[1].SetActive(true);
					pernasObj[0].SetActive(false);
					pernasObj[2].SetActive(false);
				}
				else
				{
					pernasObj[1].SetActive(false);
				}
				break;

			case 2:
				if (!pernasObj[2].activeInHierarchy)
				{
					pernasObj[2].SetActive(true);
					pernasObj[1].SetActive(false);
					pernasObj[0].SetActive(false);
				}
				else
				{
					pernasObj[2].SetActive(false);
				}
				break;

			default:
				Debug.Log("wtf, o que é que deu no código agora? " + perna);
				break;
		}
	}
}