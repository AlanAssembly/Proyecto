using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float Speed=1f;
    public float maxSpeed=1f;

    private Rigidbody2D rgbd;

    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rgbd.AddForce(Vector2.right * Speed);
        float limitedspeed = Mathf.Clamp(rgbd.velocity.x, -maxSpeed, maxSpeed);
        rgbd.velocity = new Vector2(limitedspeed, rgbd.velocity.y);
    }
}
