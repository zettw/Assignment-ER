using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballsManager : MonoBehaviour
{
    public int ball_ID;
    public int pointer_ID;
    public int totalBalls;
    public Transform  arCamera;
    public GameObject RetryButton;
    public float setupScale;

    // Start is called before the first frame update
    void Start()
    {
        
        totalBalls = gameObject.GetComponent<livesManager>().totalBalls;
        ball_ID = totalBalls - 1;
        pointer_ID = 0;
    }

    // Update is called once per frame
    public void Update()
    {  
    

        setupScale = GameObject.FindWithTag("MainCamera").GetComponent<placeSetup>().setupScale;

        if ( Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && totalBalls > 0)
            {   
                // set the ball position and rotation to be the same as AR camera
                gameObject.GetComponent<livesManager>().balls[ball_ID].transform.position = arCamera.transform.position;
                gameObject.GetComponent<livesManager>().balls[ball_ID].transform.rotation = arCamera.transform.rotation;
                gameObject.GetComponent<livesManager>().balls[ball_ID].transform.localScale = new Vector3(0.02f * setupScale,0.02f* setupScale,0.02f* setupScale);
                // Activated the ball
                gameObject.GetComponent<livesManager>().balls[ball_ID].SetActive(true);

                // change marble color indicator to white once it is being shot out
                gameObject.GetComponent<livesManager>().lives[ball_ID].GetComponent<Image>().color = Color.white;

                if (pointer_ID < 9 )
                {
                    // change the pointer position to match the current marble color 
                    gameObject.GetComponent<livesManager>().pointers[pointer_ID].SetActive(false);
                    gameObject.GetComponent<livesManager>().pointers[pointer_ID+1].SetActive(true);
                    
                }


                
                ball_ID--;
                pointer_ID++;
                totalBalls--;
                
                
                // when the marble balls are being used up
                if(totalBalls == 0)
                {
                    // clear the missing components on the ball list
                    gameObject.GetComponent<livesManager>().balls.Clear();
                    // show the retry button on canvas
                    RetryButton.SetActive(true);
                    // reset the pointer ID back to 0
                    pointer_ID = 0;

                }
                
            }
        
    }

    // function to reset back the ball_ID to the starting value
    public void ResetTotalBalls()
    {
        totalBalls = gameObject.GetComponent<livesManager>().totalBalls;
        ball_ID = totalBalls - 1;
    }
}
