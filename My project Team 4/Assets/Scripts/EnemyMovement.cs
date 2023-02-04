using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;
    GameObject SxBorder;
    GameObject DxBorder;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(15, 0, 0);
        SxBorder = GameObject.Find("SXBorder");
        DxBorder = GameObject.Find("DXBorder");
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
