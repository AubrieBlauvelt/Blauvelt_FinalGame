﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingJump : MonoBehaviour
{
    public GameObject cupObject;
    public GameObject sphereTrig;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false; 
        sphereTrig.SetActive(true);
        StartCoroutine(DeactivateSphere());
    }

    IEnumerator DeactivateSphere()
    {
        yield return new WaitForSeconds(0.5f);
        sphereTrig.SetActive(false);
    }
}
