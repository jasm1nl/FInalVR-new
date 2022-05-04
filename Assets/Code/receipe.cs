using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recipe : MonoBehaviour
{

    public Transform SpawnPosition;
    public GameObject ObjectToCreate;


    void Start()
    {
        Destroy(gameObject, 3);
        

        if (gameObject == null)
        {
            Instantiate(gameObject, SpawnPosition.transform);
            print("yes");
        }
        
    }

   
    void Update()
    {
        
    }
}
