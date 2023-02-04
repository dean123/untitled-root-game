using System.Collections;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;
    public Color collisionColor = Color.red;
    public float fadeTime = 2.0f;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
        Debug.Log(originalColor.ToString());
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(ChangeColor(collisionColor));
    }

    private IEnumerator ChangeColor(Color color)
    {
        rend.material.color = color;
        yield return new WaitForSeconds(fadeTime);
        rend.material.color = Color.Lerp(rend.material.color, originalColor, Time.deltaTime / fadeTime);
    }
}
