using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : MonoBehaviour
{
    public GameObject ruby;
    public GameObject skull;
    public GameObject sound;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("rbase"))
        {
            PublicVarsGem.gemNum++;
            Destroy(gameObject); 
            ruby.SetActive(true);
            sound.SetActive(true);
        }

        if (PublicVarsGem.gemNum > 3)
        {
            skull.SetActive(true);
        }
    }
}
