using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class LightSwitch : MonoBehaviour
{
    public XRNode handRole = XRNode.RightHand;
    public LayerMask lightingLayer;
    private float raycastDist = 30;
    private Light PLight;

    private Transform hoverObject = null;

    //public GameObject Light;
    bool triggerState = false;

    // Update is called once per frame
    void Update()
    {
        InputDevices.GetDeviceAtXRNode(handRole).TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger);
    

        if (trigger && !triggerState) // on trigger down
        {
            //Check raycast hit on a light in the lighting layer 
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDist, lightingLayer))
            {
              //Set light inactive 
              //What should I do here to deactivate the gameObject that the raycast hit on?

                PLight = hit.transform.gameObject.GetComponent<Light>();

                if(PLight.intensity==8)
                {
                    PLight.intensity=0;
                }
                else if (PLight.intensity==0)
                {
                    PLight.intensity=8;
                }

                // if(hit.transform.gameObject.activeInHierarchy)
                //     {
                //         hit.transform.gameObject.SetActive(false);
                //     }
                // else
                //     {
                //         hit.transform.gameObject.SetActive(true);
                //     }
                
            //draft
                // PLight = hit.transform.Find("Point Light").gameObject;
                // if (PLight.activeInHierarchy)
                // {
                //     PLight.SetActive(false);
                // }
                // else
                // {
                //     PLight.SetActive(true);
                // }

                
            }
            
        }
    
    }

    //Checking raycast hit
    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDist, lightingLayer))
        {
            if (hoverObject != hit.transform)
            {
                // if (hoverObject != null)
                // {
                //     hoverObject.GetComponent<Renderer>().material.color = Color.white;
                // }
                hoverObject = hit.transform;
                hoverObject.GetComponent<Renderer>().material.color = Color.green;
            }
        } 
       
        // else
        // {
        //     if (hoverObject != null)
        //     {
        //         hoverObject.GetComponent<Renderer>().material.color = Color.white;
        //         hoverObject = null;
        //     }
        // }
    }

    
}
