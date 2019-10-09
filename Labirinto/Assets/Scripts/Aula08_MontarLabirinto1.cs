using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Aula08_MontarLabirinto1 : MonoBehaviour
{
    [SerializeField]
    GameObject[] prefabParede;
    [SerializeField]
    GameObject item, player;

    //public int altura, largura;

    // Start is called before the first frame update
    public void Montar(int altura, int largura)
    {
        // Referenciaa de tamanho baseada no tamanho do prefab
        Vector3 refT = prefabParede[0].GetComponent<Renderer>().bounds.size;
        // Referencia de posição
        Vector3 refP = new Vector3(-2, 2, -1);

        string temp = GerarLabirinto.generateMaze(altura, largura);
        string[] strArray = temp.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); 

        // Quantidade de linhas no texto
        int linhas = strArray.Length;
        // Quantidade de colunas no texto
        int colunas = strArray[0].Length;


        // Pra cada linha...
        for(int l = 0; l < linhas; l++)
        {
            // Pra cada coluna...
            for (int c = 0; c < colunas; c++)
            {
                // Se o caracter correspondente for 1
                if(strArray[l][c] == '1')
                {
                    int rnd = Random.Range(0, prefabParede.Length);
                    // Instancia o prefabParede numa nova posição igual ao tamanho do prefab vezes a linha mais a posição inicial, a mesma coisa pra coluna
                    // Depois muda o nome  pra representar isso
                    Instantiate(prefabParede[rnd], new Vector3(refP.x + refT.x * l, 0, refP.y + refT.y * c), Quaternion.identity).name = "P_" + l + "_" + c;
                }
                else if (strArray[l][c] == '2')
                {
                    Instantiate(item, new Vector3(refP.x + refT.x * l, 0, refP.y + refT.y * c), Quaternion.identity).name = "P_" + l + "_" + c;
                }
                else if (strArray[l][c] == '3')
                {
                    GameObject pl = Instantiate(player, new Vector3(refP.x + refT.x * l, 0, refP.y + refT.y * c), Quaternion.identity);
                    pl.name = "Player";
                    Camera.main.transform.position = pl.transform.position + new Vector3(0, 5, -5);
                    Camera.main.transform.LookAt(pl.transform);
                    Camera.main.transform.parent = pl.transform;
                }
            }
        }
    }
}
