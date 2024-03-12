using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisaoFormiga : MonoBehaviour {
    public GameObject morte, imagem;
    public AntMoviment movimentoAnt;
    public MovimentoTerreno movimentoTerreno;

    private void Start()
    {
        movimentoTerreno.GetComponent<MovimentoTerreno>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Obstaculo")){
            morte.SetActive(true);
            movimentoTerreno.Stop();
            movimentoAnt.Stop();
            if(other.name.Contains("Bota")){
                imagem.GetComponent<Morte>().setImagem(0);
            }else {
                imagem.GetComponent<Morte>().setImagem(1);
            }
        }
    }
}
