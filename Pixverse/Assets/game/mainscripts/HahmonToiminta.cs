using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HahmonToiminta : MonoBehaviour
{



    private float speed = 4;

    
    void Start()
    {
        transform.position = GameObject.FindGameObjectWithTag("Finish").transform.position;
    }

    
    void Update()
    {

        if (transform.position.x > WorldGeneration.WorldWidth - 9.5f)
            GameObject.FindGameObjectWithTag("MainCamera").transform.position =  new Vector3(WorldGeneration.WorldWidth-9.4f, transform.position.y, -10);
        else if (transform.position.x < 8.4f)
            GameObject.FindGameObjectWithTag("MainCamera").transform.position =  new Vector3(8.4f, transform.position.y, -10);
        else
            GameObject.FindGameObjectWithTag("MainCamera").transform.position = transform.position + new Vector3(0, 0, -10);

        



        if (transform.position.x > WorldGeneration.WorldWidth-1)
            transform.position = new Vector3(WorldGeneration.WorldWidth-1, transform.position.y, 0);
        else if (transform.position.x < 0)
            transform.position = new Vector3(0, transform.position.y, 0);
        else
            transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0, 0) * Time.deltaTime;







        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up*4,ForceMode2D.Impulse);
        }
    }
}
