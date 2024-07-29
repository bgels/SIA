using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroller : MonoBehaviour
{

    [SerializeField] private RawImage img1;


    [SerializeField] private float _x, _y;
    // Start is called before the first frame update
    void Start()
    {
        img1.uvRect = new Rect(img1.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, img1.uvRect.size);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
