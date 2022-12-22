using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class targetManager : MonoBehaviour
{

    public ARRaycastManager raycastManger;
    public List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public ARRaycastHit hit;
    
    public GameObject indicator;
    public Pose hitPose;

    public GameObject movePhoneText;
    public GameObject aimPlaneText;


    

    // Start is called before the first frame update
    void Start()
    {
        raycastManger = FindObjectOfType<ARRaycastManager>();
        indicator = transform.GetChild(0).gameObject;
        indicator.SetActive(false);

        movePhoneText = GameObject.Find("MovePhone");
        aimPlaneText = GameObject.Find("AimPlane");
        aimPlaneText.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        // define the position of raycast at the center of the screen
        var ray = new Vector2(Screen.width/2, Screen.height/2);

    


        // use AR raycast to place a indicator on the AR plane
        if (raycastManger.Raycast(ray, hits, TrackableType.PlaneWithinPolygon))
        {
            hitPose = hits[0].pose;

            transform.position = hitPose.position;
            transform.rotation = hitPose.rotation;

            movePhoneText.SetActive(false);
            aimPlaneText.SetActive(true);

            if (!indicator.activeInHierarchy)
            {
                indicator.SetActive(true);
            }
        }

        else
        {
            indicator.SetActive(false);
        }
    }
}
