using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int scoreToAdd;
    public GameObject coin;
    private float CD;
    void Start()
    {
        CD = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CD -= Time.deltaTime;
        if (Input.GetKey(KeyCode.K))
        {
            TakeDmg(50);
        }
    }

    public void TakeDmg(int damage)
    {
        if (CD <= 0)
        {
            health -= damage;
            if (health <= 0)
            {
                GameManager.singleton.AddAmmount(scoreToAdd);
                if (Random.Range(0, 100) > 50)
                {
                    Instantiate(coin, transform.position, Quaternion.identity);
                }
                Destroy(gameObject);
            }
            CD = 0.5f;
        }
    }
}
