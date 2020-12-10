using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    public Text MyText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        MyText.text = "" + score; 
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag ("Pickup"))
        {
            score = score + 1;
        }
    }
}
