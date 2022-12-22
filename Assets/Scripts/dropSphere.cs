using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropSphere : MonoBehaviour
{
    public GameObject sphere;
    public GameObject targetManager;
    public GameObject aimPlaneText;

    // Start is called before the first frame update
    void Start()
    {
        // load Sphere prefab from Resources into gameobject
        sphere = Resources.Load("Prefabs/Sphere") as GameObject;
        targetManager = GameObject.Find("TargetManager");
    }

    // Update is called once per frame
    void Update()
    {   
        // detect user touch input
        if ( Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
		{
            

            // create a sphere and drop it on the generated AR plane based on the visual indicator marker
            sphere.transform.position = targetManager.transform.position + new Vector3(0,1,0);          
            Instantiate(sphere, sphere.transform.position, sphere.transform.rotation);

            // change the color of the AR plane material to clear
            gameObject.GetComponent<planeDetector>().detected_plane.GetComponent<MeshRenderer>().material.color = Color.clear;
            
        }
    }
}
