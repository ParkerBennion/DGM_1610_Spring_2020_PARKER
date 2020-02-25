using UnityEngine;

[RequireComponent(Rigidbody)]

public class PhisicsFollow : MonoBehaviour
{
    public GameObject player;
    private Rigidbody enemyRB;

    public float moveSpeed;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Sphere");
    }

    void FixedUpdate()
    {
        enemyRB.AddForce((player.transform.position - transform.position).normalized* moveSpeed);
    }
}
