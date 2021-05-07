using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetKeyDown("space") && Mathf.Abs(body.velocity.y) < 0.001f)
        {
            body.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
