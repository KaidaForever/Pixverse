using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalikanToiminta : MonoBehaviour
{
    public int PalikanMaxKestävyys;
    public int PalikanKestävyys;
    private int TarkistusKestävyys;
    


    void Start()
    {
        if (name == "Dirt(Clone)")
            PalikanMaxKestävyys = 3;
        if (name == "DirtBG(Clone)")
            PalikanMaxKestävyys = 3;
        if (name == "Kivi(Clone)")
            PalikanMaxKestävyys = 6;

        PalikanKestävyys = PalikanMaxKestävyys;
        TarkistusKestävyys = PalikanMaxKestävyys;

    }

    
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, PalikanKestävyys/PalikanMaxKestävyys );


        if (PalikanKestävyys <= 0)
            Destroy(gameObject);



        if (PalikanKestävyys < TarkistusKestävyys)
        {
           
            StartCoroutine(Korjaus());
            TarkistusKestävyys = PalikanKestävyys;
        }
            

        
    }

    IEnumerator Korjaus()
    {
        int MikäKestävyys = PalikanKestävyys;
        yield return new WaitForSeconds(3f);
        if (MikäKestävyys == PalikanKestävyys)
        {
            PalikanKestävyys = PalikanMaxKestävyys;
            TarkistusKestävyys = PalikanKestävyys;
            

        }
            
        
    }
}
