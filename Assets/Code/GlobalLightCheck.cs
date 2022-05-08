using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLightCheck : MonoBehaviour
{
    
    public GameObject light1, light2, light3, light4, light5, light6, light7;
    public GameObject Smalldoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(light1.activeInHierarchy && !light2.activeInHierarchy && !light3.activeInHierarchy && 
        // light4.activeInHierarchy && light5.activeInHierarchy && !light6.activeInHierarchy && !light7.activeInHierarchy)
        // {
        //     //remove the door from small room 
        //     Destroy(Smalldoor);
        // }

        if(light1.gameObject.GetComponent<Light>().intensity==8 && 
            light2.gameObject.GetComponent<Light>().intensity==0 && 
            light3.gameObject.GetComponent<Light>().intensity==0 && 
            light4.gameObject.GetComponent<Light>().intensity==8 && 
            light5.gameObject.GetComponent<Light>().intensity==8 && 
            light6.gameObject.GetComponent<Light>().intensity==0 && 
            light7.gameObject.GetComponent<Light>().intensity==0)
        {
            //remove the door from small room 
            Smalldoor.gameObject.SetActive(false);
        }
    }
}
