using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    float forwardSpeed = 20.0f;
    float rotateSpeed = 0.1f;
    float rotationResetSpeed = 0.1f;
    Quaternion InitialRotation;
    Vector3 InitialPosition;

    public GameObject sharpKnife;
    

    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = gameObject.transform.position;
        InitialRotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);

        Physics.IgnoreCollision(sharpKnife.GetComponent<Collider>(), GetComponent<Collider>());

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.up * 50f * Time.deltaTime, Space.World);
            gameObject.transform.Rotate(-rotateSpeed,0,0);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, InitialRotation, Time.deltaTime * rotationResetSpeed);
            gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
         
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * 50f * Time.deltaTime, Space.World);
            gameObject.transform.Rotate(0, -rotateSpeed, 0);
        }


        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.down * 30f * Time.deltaTime, Space.World);
            gameObject.transform.Rotate(rotateSpeed, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, InitialRotation, Time.deltaTime * rotationResetSpeed) ;
            //gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * 50f * Time.deltaTime, Space.World);
            gameObject.transform.Rotate(0, rotateSpeed, 0);
        }

    }

}
