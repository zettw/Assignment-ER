using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // when the marble ball hits the soccer ball, it will give its color to the soccer ball
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = col.gameObject.GetComponent<Renderer>().material.color;
            
            // after the marble hits the soccer ball, destroy the soccer in 1.5seconds and create a new soccer ball
            StartCoroutine(delay_destroy_restore());

        }

    }

    IEnumerator delay_destroy_restore()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);

        GameObject respawnManager = GameObject.FindWithTag("Respawn");
        respawnManager.GetComponent<respawnManager>().respawnSoccer();
    }
}
