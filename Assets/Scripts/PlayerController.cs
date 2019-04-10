using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public static Vector3 position;


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            //FindObjectOfType<SFXManager>().Play("aircraft");  Ask about this for partb
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * (rotSpeed *10 )* Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * (rotSpeed * 10) * Time.deltaTime);
        }

        //Restricts movement to screen
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

    }
}