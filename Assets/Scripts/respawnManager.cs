using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnManager : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject soccerBall;
    
    // this function is used by the soccerManager script to respawn soccer ball after it is being destroyed
    public void respawnSoccer()
    {
        Vector3 planePos = arCamera.GetComponent<planeDetector>().detected_plane.transform.position;
        Quaternion planeRot = arCamera.GetComponent<planeDetector>().detected_plane.transform.rotation;
        
        Vector3 soccerPos;
        soccerPos = new Vector3 (Random.Range(-0.1f,0.1f), 0.8f, Random.Range(-0.12f,-0.1f));
        Instantiate(soccerBall, planePos + soccerPos , planeRot );
    }
}
