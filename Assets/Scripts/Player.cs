using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    Rigidbody2D rb2D;

    float movement = 0f;

    public float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb2D.velocity;
        velocity.x = movement;
        rb2D.velocity = velocity;

    }

}
