using UnityEngine;

public class CollectibleRotateAnim : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 150, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
