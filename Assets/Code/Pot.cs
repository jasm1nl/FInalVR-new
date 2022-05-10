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
    public GameObject wrong;
    AudioSource addingSound;
    public AudioSource explosion;

    bool item1 = false;
    bool item2 = false;
    bool item3 = false;
    bool item4 = false;
    bool item5 = false;
    bool item6 = false;
    bool item7 = false;

    Animation explode;

    void Start()
    {
        addingSound = GetComponent<AudioSource>();
        explode = GetComponent<Animation>();
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Grabbable"))
        {
            if (other.gameObject.CompareTag("mushroom") && !item1)
            {
                item1 = true;
                liquid.SetActive(true);
                wrong.SetActive(false);
                addingSound.Play();
                Destroy(other.gameObject);
                //Timer.secondsLeft += 10;
            }
            else if (other.gameObject.CompareTag("eyeball") && !item2 && item1 == true)
            {
                liquid.SetActive(true);
                wrong.SetActive(false);
                item2 = true;
                addingSound.Play();
                Destroy(other.gameObject);
                //Timer.secondsLeft += 10;
            }
            else if (other.gameObject.CompareTag("boot") && !item3 && item2 == true)
            {
                liquid.SetActive(true);
                wrong.SetActive(false);
                item3 = true;
                addingSound.Play();
                Destroy(other.gameObject);
                //Timer.secondsLeft += 10;
            }
            else if (other.gameObject.CompareTag("watermelon") && !item4 && item3 == true)
            {
                liquid.SetActive(true);
                wrong.SetActive(false);
                item4 = true;
                addingSound.Play();
                Destroy(other.gameObject);
                //Timer.secondsLeft += 10;
            }
            else if (other.gameObject.CompareTag("shampoo") && !item5 && item4 == true)
            {
                liquid.SetActive(true);
                wrong.SetActive(false);
                item5 = true;
                addingSound.Play();
                Destroy(other.gameObject);
                //Timer.secondsLeft += 10;
            }
            else if (other.gameObject.CompareTag("hammer") && !item6 && item5 == true)
            {
                liquid.SetActive(true);
                wrong.SetActive(false);
                item6 = true;
                addingSound.Play();
                Destroy(other.gameObject);
                //Timer.secondsLeft += 10;
            }
            else if (other.gameObject.CompareTag("dskull") && !item7 && item6 == true)
            {
                liquid.SetActive(true);
                wrong.SetActive(false);
                item7 = true;
                addingSound.Play();
                Destroy(other.gameObject);
                //Timer.secondsLeft += 10;
            }
            else if (other.gameObject.CompareTag("berries") && item7 == true)
            {
                liquid.SetActive(true);
                wrong.SetActive(false);
                cooked = true;
                addingSound.Play();
                Destroy(other.gameObject);
                //Timer.secondsLeft += 10;
            }
            else if (cooked == true)
            {
                wrong.SetActive(false);
                potion.SetActive(true);
                liquid.SetActive(false);
            }
            else
            {
                explode.Play();
                wrong.SetActive(true);
                liquid.SetActive(false);
                explosion.Play();
            }
        }
    }

    private void Update()
    {

    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1f);
    }
}
