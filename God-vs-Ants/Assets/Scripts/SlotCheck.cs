using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SlotCheck : MonoBehaviour
{
    private bool _mouseOver;
    private SpriteRenderer _spriteRenderer;
    
    public List<GameObject> listaSlots;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Slot")) {
            listaSlots.Add(other.gameObject);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Slot")) {
            listaSlots.Remove(other.gameObject);
        }
    }

    public void SpawnObstaculo(GameObject poder)
    {
        int randomNum = Random.Range(0, 2);
        var power =Instantiate(poder.gameObject, listaSlots.ElementAt(randomNum).transform);
        power.transform.position = Vector3.zero;
    }
}