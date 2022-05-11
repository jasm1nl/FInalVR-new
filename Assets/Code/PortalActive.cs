using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActive : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Potion")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
