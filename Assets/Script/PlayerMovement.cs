using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalSpeed;
    float speedX;
    public float verticalImpulse;
    Rigidbody2D rb;
    bool isGrounded;

    public GameObject finishWindow;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if(Input.GetKey(KeyCode.A))
       {
            speedX = -horizontalSpeed;
       }
       else if (Input.GetKey(KeyCode.D))
       {
            speedX = horizontalSpeed; ;
       }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);
        }
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        speedX= 0;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        isGrounded= true;

        if (collision.gameObject.CompareTag("FinishButton"))
        {
            finishWindow.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGrounded = false;
    }

}
