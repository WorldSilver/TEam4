using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAttack : MonoBehaviour
{
    BoxCollider boxCollider;
    int height = 1000;
    float CD = 0;
    public GameObject attack; 
    public GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CD-= Time.deltaTime;
        if (PlayerHit())
        {
            Instantiate(attack,transform.position,Quaternion.identity);
        }
    }
    private bool PlayerHit()
    {
        if (transform.position.x <= player.transform.position.x + 0.5f & transform.position.x >= player.transform.position.x - 0.5f & CD < 0)
        {
            CD = 10;
            return true;
        }
        else return false;
    }
}
