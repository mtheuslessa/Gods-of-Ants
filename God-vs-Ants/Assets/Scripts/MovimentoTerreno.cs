using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoTerreno : MonoBehaviour
{
    public GameObject terreno1, terreno2, terreno3, terrenoFim;
    public float velocidadeTerreno;
    public float distanciaInicial, distanciaFinal, distanciaAtual;
    private Vector3 _começoTerreno, _fimTerreno;
    private Transform _terreno1Transform, _terreno2Transform, _terreno3Transform;

    private void Start() {
        _terreno1Transform = terreno1.transform;
        _terreno2Transform = terreno2.transform;
        _terreno3Transform = terreno3.transform;
        
        _começoTerreno = _terreno3Transform.position;
        _fimTerreno = terrenoFim.transform.position;

        distanciaInicial = 0;
        distanciaFinal = 5000;
        distanciaAtual = 0;
    }

    private void Update() {
        _terreno1Transform.position -= new Vector3(velocidadeTerreno, 0, 0) * Time.deltaTime;
        _terreno2Transform.position -= new Vector3(velocidadeTerreno, 0, 0) * Time.deltaTime;
        _terreno3Transform.position -= new Vector3(velocidadeTerreno, 0, 0) * Time.deltaTime;

        if (_terreno1Transform.position.x <= _fimTerreno.x) {
            _terreno1Transform.position = _começoTerreno;
        }
        
        if (_terreno2Transform.position.x <= _fimTerreno.x) {
            _terreno2Transform.position = _começoTerreno;
        }
        
        if (_terreno3Transform.position.x <= _fimTerreno.x) {
            _terreno3Transform.position = _começoTerreno;
        }
        
        float distanciaAtual = Vector3.Distance(other.position.z, transform.position.z) - start;
    }
}
