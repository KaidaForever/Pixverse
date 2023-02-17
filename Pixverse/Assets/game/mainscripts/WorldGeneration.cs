using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    public GameObject[] MaaPalat;
    
    
    void Start()
    {
        StartCoroutine(MaanLuonti());
    }

    
    void Update()
    {
        
    }


    IEnumerator MaanLuonti()
    {
        for (int y = 0; y< 10; y++)
        {

            for (int x = -19; x< 20; x++)
            {
                yield return new WaitForSeconds(0.002f);
                Instantiate(MaaPalat[0], new Vector3(x, -y, 0), Quaternion.identity);
            }
        }
    }
}
