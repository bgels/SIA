using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
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
        owner = GameObject.FindGameObjectWithTag("p2");
        timer = 0;
        dir = owner.GetComponent<movementP2>().facing == 1;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        print(dir);
        if (timer >= 3)
        {
            Destroy(gameObject);
        }
        if (dir == true)
        {
            GetComponent<Transform>().position += new Vector3(1, 0, 0);
        }
        else if (dir == false)
        {
            GetComponent<Transform>().position += new Vector3(-1, 0, 0);
        }



    }

}
