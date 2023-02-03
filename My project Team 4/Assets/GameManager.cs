using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;

    private float scoreInt = 0;

    public static GameManager singleton;
    void Start()
    {
        singleton = this;
        score.text = $"SCORE: {(int)scoreInt}";
    }

    // Update is called once per frame
    void Update()
    {
        scoreInt += Time.deltaTime;
        score.text = $"SCORE: {(int)scoreInt}";
    }
    public void AddAmmount(int ammount)
    {
        scoreInt += ammount;
    }
}
