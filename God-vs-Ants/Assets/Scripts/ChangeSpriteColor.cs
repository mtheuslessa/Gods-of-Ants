using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class ChangeSpriteColor : MonoBehaviour
{
    public SpriteRenderer corpoFormiga, membroFormiga;
    
    void Start() {
        ChangeSpriteFormiga();
    }

    public void ChangeSpriteFormiga() {
        var r = Random.Range(0, 255);
        var g = Random.Range(0, 255);
        var b = Random.Range(0, 255);
        corpoFormiga.color = new Color(r, g, b);
        membroFormiga.color = new Color(r - 50, g -50, b - 50);
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            ChangeSpriteFormiga();
        }
    }
}
