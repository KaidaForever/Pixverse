using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    public GameObject[] MaaPalat;

    public static int WorldWidth = 40;
    public static int WorldHeight = 10;

    private void Awake()
    {
        transform.position = new Vector3(Random.Range(5, WorldWidth - 5), 3, 0);
    }

    void Start()
    {
        StartCoroutine(MaanLuonti());
        
        
    }

    
    void Update()
    {
        
    }


    IEnumerator MaanLuonti()
    {
        for (int y = 0; y< WorldHeight; y++)
        {

            for (int x = 0; x< WorldWidth; x++)
            {
                yield return new WaitForSeconds(0.0002f);
                Instantiate(MaaPalat[0], new Vector3(x, -y, 0), Quaternion.identity);

                if(y==0)
                Instantiate(MaaPalat[1], new Vector3(x, -y, 0), Quaternion.identity);
                else
                {
                    int rand = Random.Range(1, 11);
                    if(rand == 1)
                        Instantiate(MaaPalat[2], new Vector3(x, -y, 0), Quaternion.identity);
                    else
                        Instantiate(MaaPalat[1], new Vector3(x, -y, 0), Quaternion.identity);
                }
            }
        }
    }
}
