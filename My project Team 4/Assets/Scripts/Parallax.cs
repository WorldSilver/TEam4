using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    // Start is called before the first frame update
    private float lenght;
    private float startPosition;
    public GameObject camera;
    public float parallaxEffect;
    void Start()
    {
        startPosition = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = (camera.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startPosition + distance,transform.position.y,transform.position.z);
    }
}
