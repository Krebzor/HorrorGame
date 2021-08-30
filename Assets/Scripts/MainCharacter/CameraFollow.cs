using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float bobbingSpeed = 1f;
    public float magnitude = 0.4f;

    private Rigidbody2D rb;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        //movement.y = Random.Range(-5f, 5f);
        //rb.MovePosition(rb.position + movement * bobbingSpeed * Time.fixedDeltaTime);

        transform.position = target.position + offset;

        //float y = Random.Range(-1f, 1f) * magnitude;
        //transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
    }

}
