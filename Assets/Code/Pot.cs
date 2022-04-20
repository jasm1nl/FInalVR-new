using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pot : MonoBehaviour
{
    string currentRecipeString = "";
    string recipe = "mushroom" + "eyeball" + "boot";

    // ^you can change the recipe here
    bool cooked = false;

    public GameObject potion;
    public GameObject liquid;
    AudioSource addingSound;

    int itemsAdded = 0;

    // public GameObject text;

    void Start()
    {
        addingSound = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Grabbable"))
        {
            currentRecipeString += other.gameObject.tag;
            liquid.SetActive(true);
            addingSound.Play();
            itemsAdded++;
            Destroy(other.gameObject);

            if (currentRecipeString == recipe && !cooked)
            {
                potion.SetActive(true);
                gameObject.SetActive(false);
                StartCoroutine(WaitTime());
                cooked = true;
            }
        }
    }

    private void Update()
    {
        if (cooked == true || itemsAdded == 3)
        {
            StartCoroutine(WaitTime());
            Destroy(gameObject);
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2f);
        // text.SetActive(true);
    }
}
