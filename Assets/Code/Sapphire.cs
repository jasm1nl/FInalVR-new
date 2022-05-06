using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapphire : MonoBehaviour
{
    public GameObject sapphire;
    public GameObject skull;
    public GameObject sound;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("sbase"))
        {
            PublicVarsGem.gemNum++;
            Destroy(gameObject); 
            sapphire.SetActive(true);
            sound.SetActive(true);
        }

        if (PublicVarsGem.gemNum > 3)
        {
            skull.SetActive(true);
        }
    }
}
