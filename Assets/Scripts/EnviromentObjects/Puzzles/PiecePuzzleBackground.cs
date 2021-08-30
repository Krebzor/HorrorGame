using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClipperLib;

using Path = System.Collections.Generic.List<ClipperLib.IntPoint>;
using Paths = System.Collections.Generic.List<System.Collections.Generic.List<ClipperLib.IntPoint>>;



public class PiecePuzzleBackground : MonoBehaviour
{
    public SpriteRenderer myRenderer;
    PolygonCollider2D innerPolygonCollider;
    PolygonCollider2D outerPolygonCollider;

    public double offsetRadius;



    // Start is called before the first frame update
    void Start()
    {
        myRenderer.color = new Color(255, 255, 255, 0.6f);
        innerPolygonCollider = gameObject.AddComponent(typeof(PolygonCollider2D)) as PolygonCollider2D;
        innerPolygonCollider.isTrigger = true;

        outerPolygonCollider = gameObject.AddComponent(typeof(PolygonCollider2D)) as PolygonCollider2D;
        outerPolygonCollider.isTrigger = true;

        Paths biggerOuterPolygon = Test();


    }

    // Update is called once per frame
    void Update()
    {

    }

    private Paths Test()
    {
        Vector2[] subj = outerPolygonCollider.points;


        Paths solution = new Paths();

        ClipperOffset c = new ClipperOffset();

        Path polygonPoints = Vector2ArrayToListIntPoint(subj);

        c.AddPath(polygonPoints, JoinType.jtSquare, EndType.etOpenButt);
        c.Execute(ref solution, offsetRadius);

        return solution;
    }

    private List<IntPoint> Vector2ArrayToListIntPoint(Vector2[] shape)
    {

        List<IntPoint> list = new List<IntPoint>();

        foreach (Vector2 v in shape)
        {

            list.Add(new IntPoint(v.x, v.y));

        }

        return list;
    }

    //Hacer lo mismo de arriba pero al reves
    private Vector2[] ListIntPointToVector2(List<IntPoint> shape)
    {

        Vector2[] listOfVectors = new Vector2[shape.Count];

        for (int i = 0; i < listOfVectors.Length; ++i)
        {
            listOfVectors[i] = new Vector2(shape[i].X, shape[i].Y);
        }
        return listOfVectors;
    }
}
