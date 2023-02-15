using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class deathScript : MonoBehaviour
{
    int deathCount = 0;
    public TMP_Text steveDeath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("building"))
        {
            deathCount++;
            steveDeath.text = deathCount.ToString();
        }
    }
}
