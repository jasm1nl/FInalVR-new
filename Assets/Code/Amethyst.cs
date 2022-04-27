using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amethyst : MonoBehaviour
{
    public GameObject amethyst;
    public GameObject skull;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("abase"))
        {
            PublicVarsGem.gemNum++;
            Destroy(gameObject); 
            amethyst.SetActive(true);
        }

        if (PublicVarsGem.gemNum > 3)
        {
            skull.SetActive(true);
        }
    }
}
