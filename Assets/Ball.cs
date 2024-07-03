using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public Vector2 LastVelocity;
    public movement  leftPlayer;
    public movement rigthPlayer;
    public UI_CONTROLLER UICONTROLLER;
    private int leftPlayerScore;
    private int rigthPlayerScore;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        SendBallInRandomDirection();
    }
public void SendBallInRandomDirection()
{
    rigidbody2d.velocity = Vector3.zero;
    rigidbody2d.isKinematic = true; 
    transform.position = Vector3.zero;
    rigidbody2d.isKinematic = false;
    rigidbody2d.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * 5f;
    LastVelocity = rigidbody2d.velocity;
    leftPlayer.speed = leftPlayer.defaultSpeed;
    rigthPlayer.speed = rigthPlayer.defaultSpeed;
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SendBallInRandomDirection();
        }
    }
private void OnCollisionEnter2D(Collision2D collision)
{
    rigidbody2d.velocity = Vector2.Reflect(LastVelocity, collision.contacts[0].normal);
    LastVelocity = rigidbody2d.velocity * 1.1f;
    leftPlayer.speed *= 1.1f;
    rigthPlayer.speed *= 1.1f;
}
 private void OnTriggerEnter2D(Collider2D collision)
 {
    if(transform.position.x > 0)
    {
        leftPlayerScore++;
        UICONTROLLER.setLeftPlayerScore(leftPlayerScore.ToString());
        Debug.Log("Left Player Scored!!");
    }
    if(transform.position.x < 0 )
    {
        rigthPlayerScore++;
        UICONTROLLER.setRigthPlayerScore(rigthPlayerScore.ToString());
        Debug.Log("Rigth Player Scored!!");
    }
    SendBallInRandomDirection();
 }
}
