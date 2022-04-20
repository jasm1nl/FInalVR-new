using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGate : MonoBehaviour
{
    public GameObject exit;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Potion")
        {
            Destroy(other.gameObject);
            exit.SetActive(true);
        }
    }


}
