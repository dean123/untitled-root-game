using UnityEngine;

public class ColorChangeOnCollision : MonoBehaviour
{
    // The object whose color we want to change
    private Renderer rend;

    // The original color of the object
    private Color originalColor;

    // The color to change to on collision
    public Color collisionColor;

    // The speed at which to fade back to the original color
    public float fadeSpeed = 0.5f;

    void Start()
    {
        rend = GetComponent<Renderer>();
        // Store the original color of the object
        originalColor = rend.material.color;
    }

    void Update()
    {
        // Fade back to the original color over time
        rend.material.color = Color.Lerp(rend.material.color, originalColor, fadeSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Change the color on collision
        rend.material.color = collisionColor;
    }
}