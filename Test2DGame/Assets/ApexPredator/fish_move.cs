using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_move : MonoBehaviour
{
    public float velocity = 5.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-velocity, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
