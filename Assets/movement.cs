using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
      print("HELLO FROM START");  
    }

    // Update is called once per frame
    void Update()
    {
      
      if(Input.GetKey(KeyCode.W))
        {
            rigidbody2d.velocity = Vector2.up;
        }else if(Input.GetKey(KeyCode.S))
        {
            rigidbody2d.velocity = Vector2.down;
        }else 
        {
            rigidbody2d.velocity = Vector2.zero;
        }
    
    }
    private void OnMouseDown()
    {
       GetComponent<SpriteRenderer>().color = Color.blue;
    }
}
