using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour


{
    public Rigidbody2D rb2D;
    public float Speed = 1f;
    public Vector2 vel;
    public KeyCode Space = KeyCode.Space;
    bool GameStarted;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKey(Space) && GameStarted == false)
            SendBallToRandomDirection();
    }

    private void SendBallToRandomDirection()
    {
        rb2D.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        rb2D.velocity = GenerateRandomVector2Without0(true) * Speed;
        vel = rb2D.velocity;
        GameStarted = true;
    }

    private Vector2 GenerateRandomVector2Without0(bool SwouldReturnNormalize)
    {
        Vector2 newvelocity = new Vector2();
        bool ShouldGoRight = Random.Range(0, 100) > 50;
        newvelocity.x = ShouldGoRight ? Random.Range(.8f, .2f) : Random.Range(-.8f, -.2f);
        newvelocity.y = ShouldGoRight ? Random.Range(.8f, .2f) : Random.Range(-.8f, -.2f);
        
        return SwouldReturnNormalize ? newvelocity.normalized : newvelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2D.velocity = Vector2.Reflect(vel, collision.contacts[0].normal);
        vel = rb2D.velocity;
    }

    private void OnTriggerEnter2D(Collider2D colission)
    {
        if (transform.position.x < 0)
            print("Right PLayer +1");
        if (transform.position.x > 0)
            print("Left PLayer +1");
        
        rb2D.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        GameStarted = false;
    }
   

}
