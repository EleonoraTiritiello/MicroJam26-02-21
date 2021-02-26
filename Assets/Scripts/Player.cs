using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rb2D;
    private BoxCollider2D boxCollider2D;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //if they are on the ground and taken space, the player performs the jump
    public void JumpPlayer()
    {
        if(isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 100f;
            rb2D.velocity = Vector2.up * jumpVelocity;
        }
    }


    private bool isGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down * 1f, platformsLayerMask);
        return raycastHit2D.collider != null;
    }
}
