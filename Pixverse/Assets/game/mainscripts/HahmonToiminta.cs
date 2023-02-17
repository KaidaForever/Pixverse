using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HahmonToiminta : MonoBehaviour
{



    private float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindGameObjectWithTag("MainCamera").transform.position = transform.position + new Vector3(0, 0, -10);


        transform.position += new Vector3(Input.GetAxisRaw("Horizontal")*speed,0,0)*Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up*4,ForceMode2D.Impulse);
        }
    }
}
