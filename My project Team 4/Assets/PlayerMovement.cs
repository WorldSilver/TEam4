using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public float floorDistance;
    float jumpInput;
    public float checkRadius;
    public Transform groundCheck;
    public LayerMask ground;
    BoxCollider2D boxCollider2D;
    Rigidbody2D rb;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        startPos = transform.position;
        boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
    }
    public void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(-15, -180, 0);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(15, 0, 0);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
