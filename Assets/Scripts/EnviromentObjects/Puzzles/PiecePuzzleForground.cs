using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PiecePuzzleForground : MonoBehaviour
{
    bool isInside = true;
    PolygonCollider2D polygonCollider;


    // Start is called before the first frame update
    void Start()
    {
        polygonCollider = gameObject.AddComponent(typeof(PolygonCollider2D)) as PolygonCollider2D;
        polygonCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Form")
        {
            Debug.Log("Inside");
            
        }
        
    }

    /*
     * piecePosition = GameObject.FindGameObjectsWithTag<Piece>().transform.position;
     * for (int i = 0; i < 3 && isInside; ++i)
       {
           if (piecePosition[i] < minPosition[i] || piecePosition[i] > maxPosition[i])
               isInside = false;
       }

       if (isInside)
       {
           Debug.Log("The piece is INSIDE the area");
       }




       if (transform.position.x == 0)
       {
           Debug.Log("I AM INSIDE MOM");
       }
       else
       {
           Debug.Log("The object is outside. I repeat.Outside.");
       }*/
}
