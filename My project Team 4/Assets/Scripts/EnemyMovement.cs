using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    GameObject SxBorder;
    GameObject DxBorder;


    Rigidbody2D rb;
    [SerializeField] private float horizontalMove = 0f;

    private bool isFacingRight = true;

    private Vector2 flip;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.eulerAngles = new Vector3(15, 0, 0);
        SxBorder = GameObject.Find("SXBorder");
        DxBorder = GameObject.Find("DXBorder");
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontalMove * speed, rb.velocity.y);
        if (transform.position.x >= DxBorder.transform.position.x & isFacingRight)
        {
            isFacingRight = false;
            Flip();
            speed = -1;
            

        }
        else if(transform.position.x <= SxBorder.transform.position.x & !isFacingRight)
        {
            
            
            speed = 1;
            isFacingRight = true;
            Flip();
           
        }
    }
    private void Flip()
    {
        if (isFacingRight && horizontalMove < 0f || !isFacingRight && horizontalMove > 0f)
        {
            
            
            flip = transform.localScale;
            flip.x *= -1f;
            transform.localScale = flip;
        }
    }
}
