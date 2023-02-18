using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HahmonToiminta : MonoBehaviour
{

    GameObject KohdePalikka;

    private float speed = 4;

    
    void Start()
    {
        transform.position = GameObject.FindGameObjectWithTag("Finish").transform.position;
    }

    
    void Update()
    {

        Liikkuminen();
        Hakkaaminen();

        if(KohdePalikka)
        Debug.Log(KohdePalikka.GetComponent<PalikanToiminta>().PalikanKestävyys + "  /  " + KohdePalikka.GetComponent<PalikanToiminta>().PalikanMaxKestävyys);
    }

    void Liikkuminen()
    {
        if (transform.position.x > WorldGeneration.WorldWidth - 9.5f)
            GameObject.FindGameObjectWithTag("MainCamera").transform.position = new Vector3(WorldGeneration.WorldWidth - 9.4f, transform.position.y, -10);
        else if (transform.position.x < 8.4f)
            GameObject.FindGameObjectWithTag("MainCamera").transform.position = new Vector3(8.4f, transform.position.y, -10);
        else
            GameObject.FindGameObjectWithTag("MainCamera").transform.position = transform.position + new Vector3(0, 0, -10);





        if (transform.position.x > WorldGeneration.WorldWidth - 1)
            transform.position = new Vector3(WorldGeneration.WorldWidth - 1, transform.position.y, 0);
        else if (transform.position.x < 0)
            transform.position = new Vector3(0, transform.position.y, 0);
        else
            transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0, 0) * Time.deltaTime;







        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 4, ForceMode2D.Impulse);
        }
    }
    void Hakkaaminen()
    {
        RaycastHit2D[] Hakkaus = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero,0);

        KohdePalikka = null;
        foreach(RaycastHit2D hit in Hakkaus)
        {
            if(hit.collider.gameObject.GetComponent<BoxCollider2D>() && hit.collider.gameObject.tag != "Player")
            {
                KohdePalikka = hit.collider.gameObject;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(KohdePalikka)
            KohdePalikka.GetComponent<PalikanToiminta>().PalikanKestävyys--;
        }





    }



    
}
