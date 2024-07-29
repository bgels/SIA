using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementP1 : MonoBehaviour
{
    [SerializeField] float speed;
     public int facing;
    [SerializeField] Vector2 direction;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] bool canJump;


    [SerializeField] Vector2 jumpForce;
    [SerializeField] Vector2 leftForce;
    [SerializeField] Vector2 rightForce;

    [SerializeField] GameObject bullet;

    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
        jumpForce = new Vector2(0, 250);
        leftForce = new Vector2(-2f, 0);
        rightForce = new Vector2(2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if(direction.x < 0)
        {
            facing = -1;
            rb.AddForce(leftForce);
        }
        else if(direction.x > 0)
        {
            facing = 1;
            rb.AddForce(rightForce);
        }
        if(Input.GetKeyDown(KeyCode.W) && canJump)
        {
            rb.AddForce(jumpForce);
            canJump = false;
        }
        if (Input.GetKeyDown(KeyCode.Q)){
            Instantiate(bullet, GetComponent<Transform>().position, Quaternion.identity);

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            
            canJump = true;
        }
    }
}
