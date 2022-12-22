using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    
    public float Force;
    public float setupScale;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        // scale the force according to the AR plane size
        setupScale = GameObject.FindWithTag("MainCamera").GetComponent<placeSetup>().setupScale;
        Force = 0.5f * setupScale;

        // add force to the ball once it is being activated 
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * Force, ForceMode.Impulse);

        // destroy ball after 2 seconds
        StartCoroutine(SelfDestruct());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // function to destroy ball after 2 seconds
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
