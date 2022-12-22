using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class placeSetup : MonoBehaviour
{
    public GameObject goal;
    public GameObject keeper;
    public GameObject soccer_ball;
    public GameObject TargetManager;
    public GameObject crosshair;
    public GameObject respawnPlane;
    public GameObject LivesManager;
    public float setupScale;

    public GameObject aimPlaneText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        // when the touch screen is being triggered
        if ( Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
		{
            
            //disable AimPlane text
            aimPlaneText = GameObject.Find("AimPlane");
            aimPlaneText.SetActive(false);

            // change the color of the AR plane material to clear
            gameObject.GetComponent<planeDetector>().detected_plane.GetComponent<MeshRenderer>().material.color = Color.clear;
            
            // the multipler 2 is chosen arbitrarily so that the gameobject fit well on the AR plane
            setupScale = gameObject.GetComponent<planeDetector>().scale * 2;

            // Activate goalpost 
            Vector3 planePos = gameObject.GetComponent<planeDetector>().detected_plane.transform.position;
            Quaternion planeRot = gameObject.GetComponent<planeDetector>().detected_plane.transform.rotation;
            Vector3 goalPos;
            goal.transform.localScale = new Vector3(0.035f * setupScale,0.035f * setupScale, 0.035f * setupScale);
            goalPos = new Vector3 (0, 0, 0.15f* setupScale);
            goal.transform.position = planePos + goalPos;
            goal.transform.rotation = planeRot;
            goal.SetActive(true);
            
            // create the goal keeper gameobject
            Vector3 keeperPos;
            keeper.transform.localScale = new Vector3(0.012f * setupScale, 0.012f * setupScale, 0.012f * setupScale);
            keeperPos = new Vector3 (0,0,-0.02f * setupScale) + goalPos;
            Instantiate(keeper, planePos + keeperPos, planeRot);

            // create soccer ball gameobject at random position infront of the goal post
            Vector3 soccerPos;
            soccerPos = new Vector3 (Random.Range(-0.08f, 0.08f) , 0.8f , Random.Range(-0.06f ,-0.05f)) * setupScale ;
            soccer_ball.transform.localScale = new Vector3(5 * setupScale,5 * setupScale,5 * setupScale);
            Instantiate(soccer_ball, planePos + soccerPos , planeRot );
			

            // disable AR Plane Manager & ARRaycastManager script
            transform.parent.GetComponent<ARPlaneManager>().enabled = false;
            transform.parent.GetComponent<ARRaycastManager>().enabled = false;

            // disable TargetManager GameObject
            TargetManager.SetActive(false);

            // change selected plane tag to "SelectedPlane"
            gameObject.GetComponent<planeDetector>().detected_plane.tag = "SelectedPlane";

            // Destroy the extra generated planes
            GameObject[] planes = GameObject.FindGameObjectsWithTag("Plane");
            foreach(GameObject plane in planes)
            {
                GameObject.Destroy(plane);
            }
        
            // activated crosshair for marble shooting
            crosshair.SetActive(true);

            // activate ballsManager script
            LivesManager.GetComponent<ballsManager>().enabled = true;

            // disable placeSetup script
            gameObject.GetComponent<placeSetup>().enabled = false;


        }
    }
}
