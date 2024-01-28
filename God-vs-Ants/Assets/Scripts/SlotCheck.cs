using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotCheck : MonoBehaviour
{
    private bool _mouseOver;
    private SpriteRenderer _spriteRenderer;
    
    public List<GameObject> listaSlots;

    /*private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseOver() {
        _mouseOver = true;
    }

    private void OnMouseExit() {
        _spriteRenderer.color = Color.white;
        _mouseOver = false;
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag.Equals("Spawn") && _mouseOver) {
            _spriteRenderer.color = Color.black;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (!_mouseOver) {
            
        }
    }*/
    
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
}