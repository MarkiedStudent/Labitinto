using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSetTexto : MonoBehaviour
{
    public InputField larguradolabirinto;
    public InputField alturadolabirinto;
    public Text textocomtamanho;

    public GameObject canvas;

    public void setget()
    {        
        textocomtamanho.text = larguradolabirinto.text + " x " + alturadolabirinto.text;
        canvas.SetActive(false);
        GetComponent<Aula08_MontarLabirinto1>().Montar(int.Parse(alturadolabirinto.text), int.Parse(larguradolabirinto.text));
    }

}
