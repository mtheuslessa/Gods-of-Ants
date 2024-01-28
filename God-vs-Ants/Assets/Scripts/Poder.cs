using System;
using UnityEngine;

public class Poder : MonoBehaviour
{
    public SlotCheck SlotCheck;
    public GameObject poder;

    public float tempo, tempoOriginal = 3f;
    public bool comecarTempo;

    private void Start()
    {
        tempo = tempoOriginal;
    }

    private void Update()
    {
        if (comecarTempo) {
            tempo -= Time.deltaTime;

            if (tempo <= 0)
            {
                tempo = tempoOriginal;
                comecarTempo = false;
            }
        }
        
    }

    public void SpawnPoder() {
        if (!comecarTempo) {
            comecarTempo = true;
            SlotCheck.SpawnObstaculo(poder);
        }
    }
}
