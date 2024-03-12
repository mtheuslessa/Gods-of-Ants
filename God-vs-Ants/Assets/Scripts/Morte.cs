using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using Random = UnityEngine.Random;

public class Morte : MonoBehaviour
{
    public Image image;
    public Sprite[] sprites;

    public MovimentoTerreno movimentoTerreno;

    public TextMeshProUGUI texto;

    public AudioSource[] vozes;
    public AudioSource papel;
    public AudioSource[] deus;

    private void Start()
    {
        movimentoTerreno = GetComponent<MovimentoTerreno>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void setImagem(int morte)
    {
        switch (morte)
        {
            case 0:
                image.sprite = sprites[0];
                break;
            case 1:
                image.sprite = sprites[1];
                break;
        }

        int audio = Random.Range(0, vozes.Length);

        vozes[audio].Play();
        papel.Play();
        deus[audio].PlayDelayed(vozes[audio].clip.length);

        setDistancia();
    }

    public void setDistancia() {
        var valor = movimentoTerreno.slider.value / 100;
        texto.text = valor.ToString();
    }
}
