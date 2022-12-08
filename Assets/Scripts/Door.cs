using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour 
{
    [SerializeField] private GameObject _house;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Goblin>(out Goblin goblin)) 
        {
            _house.SetActive(false);        
        }
    }   

    private void OnTriggerExit2D(Collider2D collision)
    {
        _house.SetActive(true);
    }
}
