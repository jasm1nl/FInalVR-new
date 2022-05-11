using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallRoomInstruct : MonoBehaviour
{
    public GameObject puzzleUI;

    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.CompareTag("Player")){
            puzzleUI.SetActive(true); 
            StartCoroutine(UIlifetime());
        }

    IEnumerator UIlifetime(){
        yield return new WaitForSeconds(6f);
        puzzleUI.SetActive(false);

        }
    }
}
