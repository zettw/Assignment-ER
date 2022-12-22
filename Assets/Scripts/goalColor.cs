using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalColor : MonoBehaviour
{
    public GameObject LivesManager;
    // Start is called before the first frame update
    void Start()
    {
         // change color of goal post frame every 1 seconds without delay
         InvokeRepeating("changeColor", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeColor()
    {
        gameObject.GetComponent<Renderer>().material.color = GameObject.FindWithTag("Lives").GetComponent<livesManager>().colors[Random.Range(0, 3)];
        
    }
}
