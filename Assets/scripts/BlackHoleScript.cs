using UnityEngine;

public class BlackHoleScript : MonoBehaviour
{
    public Transform player;
    Rigidbody playerBody;
    public float influenceRange = 5f;
    public float intensity = 1f;
    public float distanceToPlayer = 3f;
    Vector3 pullForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerBody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(player.position, transform.position);
        if (distanceToPlayer <= influenceRange)
        {
            pullForce = (transform.position - player.position).normalized / distanceToPlayer * intensity;
            playerBody.AddForce(pullForce, ForceMode.Force);
        }
    }
}