using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emerald : MonoBehaviour
{
    public GameObject emerald;
    public GameObject skull;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("ebase"))
        {
            PublicVarsGem.gemNum++;
            Destroy(gameObject); 
            emerald.SetActive(true);
        }

        if (PublicVarsGem.gemNum > 3)
        {
            skull.SetActive(true);
        }
    }
}
