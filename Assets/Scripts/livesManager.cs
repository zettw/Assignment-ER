using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livesManager : MonoBehaviour
{
    public GameObject live;
    public List<GameObject> lives = new List<GameObject>();
    public Color []colors;
    public GameObject ball;
    public List<GameObject> balls = new List<GameObject>();
    public GameObject pointer;
    public List<GameObject> pointers = new List<GameObject>();
    public int totalBalls;
    public float setupScale;
    
    // Start is called before the first frame update
    void Start()
    {

       totalBalls = 10;

     
       for(int i=0; i< totalBalls; i++)
       {
             // display the amount of marble balls to be shot and their color at random on the UI canvas
             lives.Add( (GameObject)Instantiate(live, new Vector3(-1150 + i*80, 400, 0), live.transform.rotation));
             lives[i].GetComponent<Image>().color = colors[Random.Range(0, colors.Length)];
             lives[i].transform.SetParent (GameObject.FindGameObjectWithTag("Lives").transform, false);
            
             // display the pointer arrow under the marble ball color indicator on the UI canvas
             pointers.Add( (GameObject)Instantiate(pointer, new Vector3(-430 - i*80, 320,0), pointer.transform.rotation));
             pointers[i].transform.SetParent (GameObject.FindGameObjectWithTag("Lives").transform, false);
             pointers[i].SetActive(false);
             pointers[0].SetActive(true);
             
             // Instantiate a list of marble balls with color according to the displayed marble lives on the UI
             balls.Add( (GameObject)Instantiate(ball, ball.transform.position, ball.transform.rotation));
             balls[i].GetComponent<Renderer>().material.color = lives[i].GetComponent<Image>().color ;
             balls[i].transform.SetParent (GameObject.FindGameObjectWithTag("Balls").transform, false);
             balls[i].SetActive(false);
             
       }


    }

    // Update is called once per frame
    void Update()
    {  
       
        
    }

    public void ResetColor()
    {
        for(int i=0; i< 10; i++)
       {
           lives[i].GetComponent<Image>().color = colors[Random.Range(0, colors.Length)];        
       }
    }

    public void ResetBall()
    {
        for(int i=0; i< 10; i++)
       {
           
           balls.Add( (GameObject)Instantiate(ball, ball.transform.position, ball.transform.rotation));
           balls[i].SetActive(false); 
           balls[i].GetComponent<Renderer>().material.color = lives[i].GetComponent<Image>().color ;
           balls[i].transform.SetParent (GameObject.FindGameObjectWithTag("Balls").transform, false);         
       }
    }


    public void ResetPointer()
    {
        for(int i=0; i< 10; i++)
       {
            pointers[i].SetActive(false);
            pointers[0].SetActive(true);
       }
    }

}
