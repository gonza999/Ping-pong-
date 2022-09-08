using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float score = 0;
    public Rigidbody2D rigidbody;
    public float speed = 2;
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position+=new Vector3(0,1*speed*Time.deltaTime,0);
            if (transform.position.y >= 3.40f)
            {
                transform.position = new Vector3(transform.position.x, 3.40f);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -1 * speed * Time.deltaTime, 0);
            if (transform.position.y<=-3.40f)
            {
                transform.position = new Vector3(transform.position.x, -3.40f);
            }
        }

    }
}
