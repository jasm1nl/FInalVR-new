using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sapphire : MonoBehaviour
{
    public GameObject sapphire;
    public GameObject skull;
    AudioSource ssound;

    void Start()
    {
        ssound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("sbase"))
        {
            PublicVarsGem.gemNum++;
            Destroy(gameObject); 
            sapphire.SetActive(true);
            ssound.Play();
        }

        if (PublicVarsGem.gemNum > 3)
        {
            skull.SetActive(true);
        }
    }
}
