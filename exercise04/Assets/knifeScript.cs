using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeScript : MonoBehaviour
{
    public GameObject sharpKnife;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject knife = (GameObject)Instantiate(sharpKnife, gameObject.transform.position, gameObject.transform.rotation);
                float rotXAmount = Random.Range(-3, 0);
                float rotYAmount = 0;
                knife.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody rb = knife.GetComponent<Rigidbody>();
                rb.AddForce(knife.transform.forward * 2000);

                Destroy(knife, 2f);
            }
        }
       
            
       
        
    }
}
