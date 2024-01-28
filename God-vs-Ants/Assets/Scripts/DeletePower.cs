using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePower : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Obstaculo"))
        {
            Destroy(other.gameObject);
        }
    }
}
