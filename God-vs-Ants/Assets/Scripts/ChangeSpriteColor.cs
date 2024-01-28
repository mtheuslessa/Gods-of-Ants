using UnityEngine;
using Image = UnityEngine.UI.Image;
using Random = UnityEngine.Random;

public class ChangeSpriteColor : MonoBehaviour
{
    public SpriteRenderer corpoFormiga;
    public Image iconeFormiga;
    
    void Start() {
        ChangeSpriteFormiga();
    }

    public void ChangeSpriteFormiga() {
        Color newColor = Random.ColorHSV(0,1,0,1,0.5f,1,1,1);
        corpoFormiga.color = newColor;
        iconeFormiga.color = newColor;
    }
}
