using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class AntMoviment : MonoBehaviour
{
    private int _faixaAtual;
    private Vector3 _targetPosicao; 
    public float offsetFaixa;
    public float mudancaFaixa = 1.0f;

    public AudioSource[] passos;
    public float delayPassos;

    private void Start() {
        _faixaAtual = 1;
        _targetPosicao = new Vector3(-4.25f, 0.75f, 0);

        StartCoroutine(Passos());
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
        
        mudancaFaixa += 0.1f * Time.deltaTime;
    }

    public void ChangeLane(int direcao) {
        int laneAlvo = _faixaAtual + direcao;
        
        if (laneAlvo < 0 || laneAlvo > 2)
            return;

        _faixaAtual = laneAlvo;

        _targetPosicao = new Vector3(-4.25f, ((_faixaAtual - 1) * offsetFaixa) + 0.75f, 0);
    }

    IEnumerator Passos()
    {
        yield return new WaitForSeconds(delayPassos);
        PlayPassos();
    }

    public void PlayPassos()
    {
        int audio = Random.Range(0, passos.Length);

        passos[audio].Play();

        StartCoroutine(Passos());
    }

    public void Stop()
    {
        StopAllCoroutines();
        Debug.Log("Oi");
    }
}
