using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueForScene : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    [TextArea(3, 12)]
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public string nextLevelToLoad;

    public GameObject continueButton;
    public GameObject StartButton;

    void Start()
    {
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }

        if (index == sentences.Length - 1)
        {
            EndDialogue();
            return;
        }
    }

    public void EndDialogue()
    {
        Debug.Log("End of conversation");
        SceneManager.LoadScene(nextLevelToLoad);
    }
}
