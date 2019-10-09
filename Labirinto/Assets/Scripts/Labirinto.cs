using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Labirinto : MonoBehaviour
{
    [SerializeField]
    GameObject[] paredes;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 refT = paredes[0].GetComponent<Renderer>().bounds.size;
        Vector3 refPosicao = new Vector3(-2, 0, -1);

        ///labirinto do texto
        /// TextAsset t = Resources.Load("meuTexto") as TextAsset;
        /// string[]str=t.text.Split(new char[]{ '\r','\n'},
        /// StringSplitOptions.RemoveEmptyEntries);

        string temp = GerarLabirinto.generateMaze(20, 20);
        string[] str = temp.Split(new char[] { '\r', '\n' },
            StringSplitOptions.RemoveEmptyEntries); ;

        int lin = str.Length;
        int col = str[0].Length;


        for (int l=0;l<lin;l++)
            for(int c=0;c<col;c++)
                if(str[l][c]=='1')
                {
                    int rnd = Random.Range(0, paredes.Length - 1);
                    GameObject obj=GameObject.Instantiate(paredes[rnd], 
                        refPosicao + new Vector3(refPosicao.x + refT.x * l,0,
                                  refT.z* c), Quaternion.identity);
        obj.name = "Parede" + l + "_" + c;
    }
        ///  {
        ///      Instantiate(prefabParede,
        ///          new Vector3(refP.x + refT.x * l, 0,
        ///                      refP.y + refT.y * c),
        ///         Quaternion.identity).name="P"+l+"_"+c;
        ///  }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
