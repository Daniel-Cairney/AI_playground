using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleAIVision : MonoBehaviour
{
    [SerializeField] public GameObject playerCharacter;
    //this handles seeing the player character 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCharacter = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCharacter = null;
        }
    }
}
