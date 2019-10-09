using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public float tempo = 0;
    //public Text txt;
    public TextMeshProUGUI txt;
    
    // Start is called before the first frame update
    void Start()
    {
        txt.text = tempo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        txt.text = Mathf.Round(tempo).ToString();
    }
}
