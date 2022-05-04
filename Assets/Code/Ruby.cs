using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : MonoBehaviour
{
    public GameObject ruby;
    public GameObject skull;
    AudioSource rsound;

    void Start()
    {
        rsound = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("rbase"))
        {
            PublicVarsGem.gemNum++;
            Destroy(gameObject); 
            ruby.SetActive(true);
            rsound.Play();
        }

        if (PublicVarsGem.gemNum > 3)
        {
            skull.SetActive(true);
        }
    }
}
