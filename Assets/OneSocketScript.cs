using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneSocketScript : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Collider2D collider;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(4 * -1, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject.gameObject);
    }
}
