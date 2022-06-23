using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentScript : MonoBehaviour
{
    
    public Animator animator;
    public float playerSpeed;
    float horizontalMove = 0f;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * playerSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
         if(Input.GetKey(KeyCode.D))
        {
          transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.W))
        {
          transform.Translate(Vector2.up * playerSpeed * Time.deltaTime);
          animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
        // if(Input.GetKey(KeyCode.A))
        // {
        // transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        // }
        if(Input.GetKey(KeyCode.S))
        {
        transform.Translate(Vector2.down * playerSpeed * Time.deltaTime);
        animator.SetBool("IsDown", true);
        }
        else
        {
        animator.SetBool("IsDown", false);
        }
    }

}
