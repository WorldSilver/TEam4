using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Animator aim;
  
    [SerializeField] private float runSpeed = 0f, jumpPower = 0f;

    [SerializeField] private float horizontalMove = 0f;

    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform controlloTerenno;

 
    [Header("------------------Abilita di per vedere Layer-----------------------")]
    [SerializeField] private LayerMask terrenoLayer;


    private Vector2 flip;
    private void Start()
    {


    }
    void FixedUpdate()
    {
        // Muovere il personaggio 
        rb.velocity = new Vector2(horizontalMove * runSpeed, rb.velocity.y);


    }



    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            transform.Translate(0, 0, 0 * 10);

            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
      


        Flip();
    }



    //Controllo se tocca il terreno
    private bool IsGrounded()
    {

        return Physics2D.OverlapCircle(controlloTerenno.position, 0.4f, terrenoLayer);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("TagTerreno") && abilitaDoppioJump)
    //    {
    //        doppioJump = true;
    //    }
    //}
    // qui ci assicuriamo che quando il player si gira al contrario 
    private void Flip()
    {
        if (isFacingRight && horizontalMove < 0f || !isFacingRight && horizontalMove > 0f)
        {
            isFacingRight = !isFacingRight;
            flip = transform.localScale;
            flip.x *= -1f;
            transform.localScale = flip;
        }
    }

  

}
