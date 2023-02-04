using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemy;
    
    public GameObject borderSX;
    public GameObject borderDX;
    float CD = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CD-= Time.deltaTime;
        if(CD <= 0)
        {
            Vector3 pos = new Vector3(borderSX.transform.position.x,Random.Range(borderSX.transform.position.y, borderDX.transform.position.y),borderSX.transform.position.z);
            //Instantiate(enemy[Random.RandomRange(0,2)],pos,Quaternion.identity);
            CD += 10f/(Time.time*0.1f);
            Debug.Log(5f / (Time.realtimeSinceStartup * 0.1f));
        }
    }
}
