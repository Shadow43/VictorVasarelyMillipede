using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;

    // Start is called before the first frame update
    void Start()
    {
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            {
                rb.isKinematic = false;
                rb.AddForce(new Vector2(ballForce, ballForce));
                transform.SetParent(null);
            }
        }
    }
}
