using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;


public class Spawner : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> actions = new Dictionary<string, System.Action>();

    public GameObject spawnLocation;
    public GameObject obj;
    private Vector3 respawnLocation;
  

    void Start()
    {
        actions.Add("mushroom", Mushroom); // detact "forward", and create a function Forward
        actions.Add("eyeball", Eyeball);
        actions.Add("boot", Boot);
        actions.Add("pot", Pot);
        actions.Add("house", House);
        actions.Add("sofa", Sofa);
        actions.Add("table", Table);
        actions.Add("chair", Chair);
        actions.Add("shelf", Shelf);
        actions.Add("bed", Bed);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;

        keywordRecognizer.Start();

        spawnLocation = GameObject.FindGameObjectWithTag("SpawnPoint");
        //Debug.Log("found " + GameObject.FindGameObjectWithTag("SpawnPoint"));
       // player.transform.position = spawnLocation.transform.position;
        Debug.Log("Post transform call");
        
        //respawnLocation = player.transform.position;
        //SpawnCharacter();
        //player.GetComponent<PlayerMovement>().enabled = true;

    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void Mushroom()
    {
        obj = GameObject.FindGameObjectWithTag("mushroom");
        SpawnCharacter();
    }
     private void Eyeball()
    {
        obj = GameObject.FindGameObjectWithTag("eyeball");
        SpawnCharacter();
    }
     private void Boot()
    {
        obj = GameObject.FindGameObjectWithTag("boot");
        SpawnCharacter();
    }
     private void Pot()
    {
        obj = GameObject.FindGameObjectWithTag("pot");
        SpawnCharacter();
    }
    private void House()
    {
        obj = GameObject.FindGameObjectWithTag("house");
        Vector3 temp = new Vector3(0.1854955f, -1.7f, -2.2f);  
        GameObject.Instantiate(obj,temp,Quaternion.identity); 
    }

    private void Sofa()
    {
        obj = GameObject.FindGameObjectWithTag("sofa");
        SpawnCharacter();
    }

    private void Chair()
    {
        obj = GameObject.FindGameObjectWithTag("chair");
        SpawnCharacter();
    }

    private void Table()
    {
        obj = GameObject.FindGameObjectWithTag("table");
        SpawnCharacter();
    }

    private void Shelf()
    {
        obj = GameObject.FindGameObjectWithTag("shelf");
        SpawnCharacter();
    }

    private void Bed()
    {
        obj = GameObject.FindGameObjectWithTag("bed");
        SpawnCharacter();
    }


    void SpawnCharacter() 
    {
        
        //player.transform.position = spawnLocation.transform.position;
        GameObject.Instantiate(obj,spawnLocation.transform.position,Quaternion.identity);
        
       
    }
}
