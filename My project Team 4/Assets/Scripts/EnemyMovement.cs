using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;
    public GameObject SxBorder;
    public GameObject DxBorder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if(transform.position.x >= DxBorder.transform.position.x)
        {
            movingRight = false;
            transform.eulerAngles = new Vector3(-15, -180, 0);
            
        }
        else if(transform.position.x <= SxBorder.transform.position.x)
        {
            transform.eulerAngles = new Vector3(15, 0, 0);
            
            movingRight = true;
        }
    }
}
