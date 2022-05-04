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
        if(light1.activeInHeriarchy && !light2.activeInHeriarchy && !light3.activeInHeriarchy && 
        light4.activeInHeriarchy && light5.activeInHeriarchy && !light6.activeInHeriarchy && !light7.activeInHeriarchy)
        {
            //remove the door from small room 
            Destroy(Smalldoor);
        }
    }
}
