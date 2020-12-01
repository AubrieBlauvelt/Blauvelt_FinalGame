using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningSceneA : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;

    void Start()
    {
        ThePlayer.GetComponent<FirstPersonAIO>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);
        TextBox.GetComponent<Text>().text = "I think something is in the house... I just wanted a friend. I have to get rid of it.";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonAIO>().enabled = true;
    }
    
}
