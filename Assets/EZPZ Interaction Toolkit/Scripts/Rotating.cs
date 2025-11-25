using UnityEngine;

public class Rotating : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Vector3 rotationSpeed = new Vector3(0, 0, 0); // Ã¿ÃëÐý×ª½Ç¶È

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}

