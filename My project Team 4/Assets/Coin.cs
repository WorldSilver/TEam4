using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Rigidbody rb;
    public int scoreToAdd;
    private float CD;
    void Start()
    {
        CD = 0;
    }
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        Bounce();
        
    }
    private void Update()
    {
        CD += Time.deltaTime;
    }

    // Update is called once per frame

    void Bounce()
    {
        rb.AddForce(new Vector3(1f,2f,0f),ForceMode.Impulse);
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") & CD > 1.5f)
        {
            GameManager.singleton.AddAmmount(scoreToAdd);
            Destroy(gameObject);
        }
    }



}
