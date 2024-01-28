using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Morte : MonoBehaviour
{
    public Image image;
    public Sprite[] sprites;

    public MovimentoTerreno movimentoTerreno;

    public TextMeshProUGUI texto;

    private void Start()
    {
        movimentoTerreno = GetComponent<MovimentoTerreno>();
    }

    private void Update()
    {
        if (Input.anyKeyDown)
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

        setDistancia();
    }

    public void setDistancia() {
        var valor = movimentoTerreno.slider.value / 100;
        texto.text = valor.ToString();
    }
}
