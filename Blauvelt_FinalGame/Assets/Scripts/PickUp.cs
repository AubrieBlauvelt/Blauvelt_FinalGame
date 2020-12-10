using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;
    public GameObject tempParent;
    public Transform destination;

    void start ()
    {
        this.GetComponent<Rigidbody>().useGravity = true;
    }

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = theDest.position;
        this.transform.rotation = theDest.transform.rotation;
        this.transform.parent = tempParent.transform;
    }

     void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
        this.transform.parent = null;
        this.transform.position = theDest.transform.position; 
    }
}
