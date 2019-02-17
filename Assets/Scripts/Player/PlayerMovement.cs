using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // movement code
    public Rigidbody2D rb;
    public float speed;
    public float x;
    public float y;
    // clamping code
    public float XMaxMin = -2.71f;
    public float XMaxMax = 2.71f;
    public float YMaxMin = -6.76f;
    public float YMaxMax = -5.76f;
    // buttet spawn code
    public GameObject prefab;
    public Transform spawnAt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
        Vector3 pos = (transform.position);
        pos.x = Mathf.Clamp(pos.x, XMaxMin, XMaxMax);
        pos.y = Mathf.Clamp(pos.y, YMaxMin, YMaxMax);
        transform.position = pos;
        rb.velocity = new Vector2(x, y) * speed;
        if (Input.GetMouseButtonDown(0))
        {
            {
                //Debug.Log("Firing Gun");
                GameObject go;
                go = Instantiate(prefab, spawnAt.position, prefab.transform.rotation) as GameObject;
                go.transform.SetParent(transform, true);
            }
        }


    }
}
