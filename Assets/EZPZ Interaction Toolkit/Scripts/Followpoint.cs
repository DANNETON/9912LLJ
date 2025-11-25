using UnityEngine;

public class Lever1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform followPoint;  

    public Vector3 downRotation = new Vector3(90, 0, 0);

    void Update()
    {
        transform.position = followPoint.position;

        transform.rotation = Quaternion.Euler(downRotation);
    }
}
