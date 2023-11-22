using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaMovement : MonoBehaviour
{
    public  float speed = 0;
    public KeyCode up;
    public KeyCode down;
    private Vector2 direccion;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
              rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direccion = Vector2.zero;
        if (Input.GetKey(up))
        {
            direccion = new Vector2(0, 1);
        }else if (Input.GetKey(down))
        {
            direccion = new Vector2(0, -1);
        }
    }

    private void FixedUpdate()
    {
        //Update que se ejecuta cada más tiempo
        rb.velocity = direccion * speed;    
    }
}
