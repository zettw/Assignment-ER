using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeper : MonoBehaviour
{
    
    public Rigidbody rb;
    
    public Vector3 startPos;
    public Vector3 endPos;

    public float setupScale;

    void Awake()
    {
        setupScale = GameObject.FindWithTag("MainCamera").GetComponent<placeSetup>().setupScale;

        startPos = transform.position - transform.up * 0.06f * setupScale;
        endPos = transform.position + transform.up * 0.06f * setupScale;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // move the keeper left and right of the goalpost
        rb.MovePosition(Vector3.Lerp(endPos, startPos, Mathf.PingPong(Time.fixedTime, 1)));


    }


    
}
