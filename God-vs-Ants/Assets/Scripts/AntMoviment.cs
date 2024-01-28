using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AntMoviment : MonoBehaviour
{
    private int _faixaAtual;
    private Vector3 _targetPosicao; 
    public float offsetFaixa;
    public float mudancaFaixa = 1.0f;

    private void Start() {
        _faixaAtual = 1;
        _targetPosicao = new Vector3(-4.5f, 0.5f, 0);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)){
            ChangeLane(1);
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)){
            ChangeLane(-1);
        }
        
        transform.localPosition = Vector3.MoveTowards(
            transform.localPosition,
            _targetPosicao,
            mudancaFaixa * Time.deltaTime);
    }

    public void ChangeLane(int direcao) {
        int laneAlvo = _faixaAtual + direcao;
        
        if (laneAlvo < 0 || laneAlvo > 2)
            return;

        _faixaAtual = laneAlvo;

        _targetPosicao = new Vector3(-4.5f, ((_faixaAtual - 1) * offsetFaixa) + 0.5f, 0);
    }
}
