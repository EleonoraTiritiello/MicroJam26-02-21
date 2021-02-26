using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb2D = collision.collider.GetComponent<Rigidbody2D>();

        if(rb2D != null)
        {
            Vector2 velocity = rb2D.velocity;
            velocity.y = jumpForce;
            rb2D.velocity = velocity;
        }
    }


}
