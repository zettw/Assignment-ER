using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreSystem : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {   
        
        scoreText.text = "Score: " + score.ToString();
    }
}
