using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    Player player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb2D = collision.collider.GetComponent<Rigidbody2D>();

            if(rb2D != null)
            {
                Vector2 velocity = rb2D.velocity;
                velocity.y = jumpForce;
                rb2D.velocity = velocity;
            }
        }

        if (player)
        {
            Destroy(gameObject);
        }
    }




}
