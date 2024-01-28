using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poder : MonoBehaviour
{
    public SlotCheck SlotCheck;
    public GameObject poder;
    
    private void OnMouseUpAsButton()
    {
        SlotCheck.SpawnObstaculo(poder);
    }
}
