using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalikanToiminta : MonoBehaviour
{
    public int PalikanMaxKest‰vyys;
    public int PalikanKest‰vyys;
    private int TarkistusKest‰vyys;
    


    void Start()
    {
        if (name == "Dirt(Clone)")
            PalikanMaxKest‰vyys = 3;
        if (name == "DirtBG(Clone)")
            PalikanMaxKest‰vyys = 3;
        if (name == "Kivi(Clone)")
            PalikanMaxKest‰vyys = 6;

        PalikanKest‰vyys = PalikanMaxKest‰vyys;
        TarkistusKest‰vyys = PalikanMaxKest‰vyys;

    }

    
    void Update()
    {

        

        if (PalikanKest‰vyys <= 0)
            Destroy(gameObject);



        if (PalikanKest‰vyys < TarkistusKest‰vyys)
        {
            gameObject.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, 1/PalikanMaxKest‰vyys);
            StartCoroutine(Korjaus());
            TarkistusKest‰vyys = PalikanKest‰vyys;
        }
            

        
    }

    IEnumerator Korjaus()
    {
        int Mik‰Kest‰vyys = PalikanKest‰vyys;
        yield return new WaitForSeconds(3f);
        if (Mik‰Kest‰vyys == PalikanKest‰vyys)
        {
            PalikanKest‰vyys = PalikanMaxKest‰vyys;
            TarkistusKest‰vyys = PalikanKest‰vyys;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);

        }
            
        
    }
}
