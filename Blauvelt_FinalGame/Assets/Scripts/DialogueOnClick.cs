using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueOnClick : MonoBehaviour
{

    public string dialogueToDisplay;

    public GameObject dialoguePanel;
    public Text dialogueText;

    bool dialogueOpened;
    bool canClose = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (dialogueOpened)
            {
                if (!canClose)
                {
                    canClose = true;
                }
                else
                    CloseDialoguePanel();
            }
        }


    }

    private void OnMouseDown()
    {
        if (!dialogueOpened)
            OpenDialoguePanel();
    }

    void OpenDialoguePanel()
    {
        dialogueOpened = true;
        Time.timeScale = 0f;

        dialoguePanel.SetActive(true);
        dialogueText.text = dialogueToDisplay;

        canClose = false;
    }

    void CloseDialoguePanel()
    {
        dialogueOpened = false;
        Time.timeScale = 1f;

        dialoguePanel.SetActive(false);
    }
}
