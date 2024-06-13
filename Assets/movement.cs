using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public KeyCode UpKey;
    public KeyCode DownKey;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
      print("HELLO FROM START");  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(UpKey) && transform.position.y < 4)
        {
            rigidbody2d.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(DownKey) && transform.position.y > -4)
        {
           rigidbody2d.velocity = Vector2.down * speed;
        }

        else
        {
            rigidbody2d.velocity = Vector2.zero;
        }


    }
}