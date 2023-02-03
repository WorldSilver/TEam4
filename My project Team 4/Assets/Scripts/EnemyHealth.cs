using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int scoreToAdd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            TakeDmg(50);
        }
    }

    public void TakeDmg(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameManager.singleton.AddAmmount(scoreToAdd);
            Destroy(gameObject);
        }
    }
}
