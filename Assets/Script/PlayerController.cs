using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private bool isGrounded = false;
    public Animator anim;
    private Rigidbody2D rb;
    public float jump;
    private bool doubleJump;
    private BoxCollider2D boxCollider;
    public Vector2 colliderNormalOffset;
    public Vector2 colliderSneakOffset;
    public Vector2 colliderNormalSize;
    public Vector2 colliderSneakSize;

    public int max_lompat;
    private int sisa_lompat;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        sisa_lompat = max_lompat;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(isGrounded){
            sisa_lompat = max_lompat;
        }




        if (Input.GetKeyDown(KeyCode.Space) && sisa_lompat>0)
        {
            rb.AddForce(Vector2.up * jump); 
            doubleJump = true;
            

            isGrounded = false;
            sisa_lompat -= 1;

        }

        if(Input.GetKeyDown(KeyCode.Space) && !isGrounded && doubleJump)
            {

                rb.AddForce(Vector2.up * jump);

                doubleJump = false;

            }

        if (Input.GetKeyDown(KeyCode.S))
        {
            boxCollider.offset = colliderSneakOffset;
            boxCollider.size = colliderSneakSize;
            anim.SetTrigger("Sneak");
        }

        if (Input.GetKeyUp(KeyCode.S)) 
        {
            boxCollider.offset = colliderNormalOffset;
            boxCollider.size = colliderNormalSize;
            anim.SetTrigger("Move");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            anim.SetBool("Hurt", false);
            SceneManager.LoadScene("Game Over");
            //GameManager.distance = 0;
        }
    }
    
}
