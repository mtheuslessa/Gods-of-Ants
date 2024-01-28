using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class ChangeSpriteColor : MonoBehaviour
{
    public SpriteRenderer corpoFormiga;
    
    void Start() {
        ChangeSpriteFormiga();
    }

    public void ChangeSpriteFormiga() {
        var r = (float)Random.Range(0, 255);
        var g = (float)Random.Range(0, 255);
        var b = (float)Random.Range(0, 255);
        corpoFormiga.color = Random.ColorHSV(0,1,0,1,0.5f,1,1,1);
    }
}
