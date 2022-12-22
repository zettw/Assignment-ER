using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalTrigger : MonoBehaviour
{
    public Color triggerColor;
    public GameObject plusOne;
    public GameObject plusOneInstance;
    public GameObject minusOne;
    public GameObject minusOneInstance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        triggerColor = GameObject.FindWithTag("Goal").GetComponent<Renderer>().material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Soccer" && other.gameObject.GetComponent<Renderer>().material.color == triggerColor)
        {
            
            // add score to scoreSystem script when score the correct color
            GameObject.FindWithTag("Score").GetComponent<scoreSystem>().score++;

            // create the "+1" gameobject text when score the correct color
            plusOneInstance = Instantiate(plusOne, plusOne.transform.position, plusOne.transform.rotation);
            plusOneInstance.transform.SetParent (GameObject.FindWithTag("Canvas").transform, false);

            // destory the "+1" gameobject after 1 second
            StartCoroutine(destroyPlusOne());
        }

        if (other.gameObject.tag == "Soccer" && other.gameObject.GetComponent<Renderer>().material.color != triggerColor)
        {
            
            // minus score from scoreSystem script
            GameObject.FindWithTag("Score").GetComponent<scoreSystem>().score--;

            // create the "-1" gameobject text when score the wrong color
            minusOneInstance = Instantiate(minusOne, minusOne.transform.position, minusOne.transform.rotation);
            minusOneInstance.transform.SetParent (GameObject.FindWithTag("Canvas").transform, false);

            // destroy "-1" text
            StartCoroutine(destroyMinusOne());
        }

        IEnumerator destroyPlusOne()
        {
            yield return new WaitForSeconds(1);

            Destroy(plusOneInstance);

            plusOneInstance = null; // clear the missing component message
        }

        IEnumerator destroyMinusOne()
        {
            yield return new WaitForSeconds(1);

            Destroy(minusOneInstance);
            minusOneInstance = null; // clear the missing component message
        }
        
    }


}
