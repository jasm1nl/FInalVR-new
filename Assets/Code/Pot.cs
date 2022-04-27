using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pot : MonoBehaviour
{
    // string currentRecipeString = "";
    // string recipe = "mushroom" + "eyeball" + "boot";

    // ^you can change the recipe here
    bool cooked = false;

    public GameObject potion;
    public GameObject liquid;
    AudioSource addingSound;

    bool item1 = false;
    bool item2 = false;
    bool item3 = false;
    bool item4 = false;
    bool item5 = false;
    bool item6 = false;
    bool item7 = false;

    // public GameObject text;

    void Start()
    {
        addingSound = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("mushroom") && !item1)
        {
            item1 = true;
            liquid.SetActive(true);
            addingSound.Play();
            // Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("eyeball") && !item2 && item1 == true)
        {
            item2 = true;
            addingSound.Play();
        }
        if (other.gameObject.CompareTag("boot") && !item3 && item2 == true)
        {
            item3 = true;
            addingSound.Play();
        }
        if (other.gameObject.CompareTag("watermelon") && !item4 && item3 == true)
        {
            item4 = true;
            addingSound.Play();
        }
        if (other.gameObject.CompareTag("shampoo") && !item5 && item4 == true)
        {
            item5 = true;
            addingSound.Play();
        }
        if (other.gameObject.CompareTag("hammer") && !item6 && item5 == true)
        {
            item6 = true;
            addingSound.Play();
        }
        if (other.gameObject.CompareTag("dskull") && !item7 && item6 == true)
        {
            item7 = true;
            addingSound.Play();
        }
        if (other.gameObject.CompareTag("berries") && item7 == true)
        {
            cooked = true;
            addingSound.Play();
        }
        if (cooked == true)
        {
            potion.SetActive(true);
            liquid.SetActive(false);
        }
    }

    private void Update()
    {
        // if (cooked == true || itemsAdded == 3)
        // {
        //     StartCoroutine(WaitTime());
        //     Destroy(gameObject);
        // }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2f);
        // text.SetActive(true);
    }
}
