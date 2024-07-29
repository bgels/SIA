using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b2bul : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] GameObject owner;

    [SerializeField] bool dir;
    [SerializeField] float timer;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        owner = GameObject.FindGameObjectWithTag("p1");
        timer = 0;
        dir = owner.GetComponent<movementP1>().facing == 1;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 3)
        {
            Destroy(gameObject);
        }
        if (dir == true)
        {
            GetComponent<Transform>().position += new Vector3(.03f, 0, 0) * speed;
        }
        else if (dir == false)
        {
            GetComponent<Transform>().position += new Vector3(-.03f, 0, 0) * speed;
        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("COLLIDED");
    }

}
