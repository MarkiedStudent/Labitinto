using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public int pontos = 0;
    public TextMeshProUGUI txtPts;

    public void AlteraPontos(int pts)
    {
        pontos += pts;
        //Debug.Log("Pontuacao" + pts);

        //txtPts.text = pontos.ToString();
    }
}
