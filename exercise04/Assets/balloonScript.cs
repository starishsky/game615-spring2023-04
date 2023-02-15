using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonScript : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("balloon"))
        {
            Debug.Log("Please...");
            Destroy(other.gameObject);
        }

        if (other.CompareTag("building"))
        {
            rb.isKinematic = true;
        }
    }
}
