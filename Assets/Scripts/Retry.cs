using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // functions to be activated by the "Retry button" upon clicking
    
    public void ResetScore()
    {
        GameObject.FindWithTag("Score").GetComponent<scoreSystem>().score = 0;
    }

    public void ResetColor()
    {
        GameObject.FindWithTag("Lives").GetComponent<livesManager>().ResetColor();
    }

    public void ResetBall()
    {
        GameObject.FindWithTag("Lives").GetComponent<livesManager>().ResetBall();
    }

    public void ResetTotalBalls()
    {
        GameObject.FindWithTag("Lives").GetComponent<ballsManager>().ResetTotalBalls();
    }

    public void ResetPointer()
    {
        GameObject.FindWithTag("Lives").GetComponent<livesManager>().ResetPointer();
    }

    public void HideButton()
    {
        gameObject.SetActive(false);
    }
}
