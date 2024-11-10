using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 20.0f; 
    private float range = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Pohyb doleva při stisknutí klávesy A
        if (Input.GetKey(KeyCode.A) && transform.position.z > -range)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        // Pohyb doprava při stisknutí klávesy D
        if (Input.GetKey(KeyCode.D) && transform.position.z < range)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
