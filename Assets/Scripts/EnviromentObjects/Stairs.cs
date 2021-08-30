using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    private SpriteRenderer myRenderer;
    private Color originalColor;

    public GameObject mainCharacter;
    public Transform newStairs;

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
        
        Debug.Log("Fuck you I clicked!");
        StartCoroutine(GoingDownStairs());
        
    }

    public void OnMouseEnter()
    {
        originalColor = myRenderer.material.color;
        myRenderer.material.color = new Color(1, 0.8f, 0.8f, 1);

    }

    public void OnMouseExit()
    {

        myRenderer.material.color = originalColor;
    }

    IEnumerator GoingDownStairs()
    {
        yield return new WaitForSeconds(2);
        //animator.SetBool("IsGoingDownStairs", true);
        mainCharacter.transform.position = newStairs.transform.position;

    }
}
