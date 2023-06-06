using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneKnobScript : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Collider2D boxCollider;
    [SerializeField] private LayerMask player;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(5 * -1, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject.gameObject);
    }

    private bool IsCollided()
    {
        float extraSpace = 0.1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.left, extraSpace, player);

        return raycastHit.collider != null;
    }
}
