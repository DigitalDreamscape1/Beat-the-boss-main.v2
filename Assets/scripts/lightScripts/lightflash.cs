using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightflash : MonoBehaviour
{
   public bool isFlickering = false;
    public float timeDelay;

    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }
        
    }

    IEnumerator FlickeringLight()
    {
        isFlickering = false;    
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(1.0f, 2.02f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(2.08f, 3.1f);
        isFlickering = false;
    }
}
