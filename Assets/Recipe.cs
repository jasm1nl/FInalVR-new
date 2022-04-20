using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{
    
    public GameObject recipeUI; 
    bool collect = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.CompareTag("recipe")){
            Destroy(other.gameObject);
            collect = true; 
        }
        
        
        if(collect && other.gameObject.CompareTag("Pot")){
            recipeUI.SetActive(true);
        }
    }
}
