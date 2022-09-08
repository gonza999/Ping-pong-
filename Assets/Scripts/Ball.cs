using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 3;
    public Rigidbody2D rigidbody;
    private void Start()
    {
        Launch();
    }
    public void Launch()
    {
        float xVelocity = Random.Range(0,2)==0?1:-1;
        float yVelocity = Random.Range(0,2)==0?1:-1;
        rigidbody.velocity = new Vector2(xVelocity,yVelocity)*speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Wall"))
        {
            speed++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("GoalPlayer"))
        {
            Score.instancie.AddPointToEnemy();
        }
        if (collision.transform.CompareTag("GoalEnemy"))
        {
            Score.instancie.AddPointToPlayer();
        }
        transform.position = Vector3.zero;
        Launch();
    }

}
