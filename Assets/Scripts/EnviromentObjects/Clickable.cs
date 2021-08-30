using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clickable : MonoBehaviour
{
    private SpriteRenderer myRenderer;
    private Color originalColor;

    public string nextScene;
    
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        //Objeto hace algo
        Debug.Log("Fuck you I clicked!");
        SceneManager.LoadScene(nextScene);
    }

    public void OnMouseEnter()
    {
        originalColor = myRenderer.material.color;
        myRenderer.material.color = new Color(1, 0.8f , 0.8f , 1);
        
    }

    public void OnMouseExit()
    {
        
        myRenderer.material.color = originalColor;
    }

}
