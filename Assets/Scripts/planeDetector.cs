using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeDetector : MonoBehaviour
{
    
    public GameObject detected_plane;
    public float planeSize_X;
    public float planeSize_Z;
    public float scale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // create a physics raycast to detect the generated AR plane
        RaycastHit hit; 
        if(Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 10000))
        {
            
            detected_plane = hit.collider.gameObject;

            Mesh mesh = detected_plane.GetComponent<MeshFilter>().mesh;
            planeSize_X = mesh.bounds.size.x;
            planeSize_Z = mesh.bounds.size.z;
            // use the smaller value of the plane dimensions to scale gameobjects
            scale = Mathf.Min(planeSize_X, planeSize_Z); 
        }
        
    }
}
