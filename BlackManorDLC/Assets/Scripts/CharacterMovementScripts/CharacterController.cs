using UnityEngine;
using System.Collections;
public class CharacterController : MonoBehaviour
{
    private float speed = 0;
    public float wSpeed;
    public float rSpeed;
    public float rotSpeed;

    static Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = rSpeed;            //Running
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", false);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", false);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", false);
            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", false);
            }
            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", false);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", true);
                anim.SetBool("isJumping", false);
            }
            else if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.W))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", false);
            }
            else if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", false);
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", false);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", true);
            }
            else
            {
                //Is Idle
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", false);
                anim.SetBool("isIdle", true);
                anim.SetBool("isIdleLeft", false);
                anim.SetBool("isIdleRight", false);
                anim.SetBool("isJumping", false);
            }
        }
        //Walking
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isIdleLeft", false);
            anim.SetBool("isIdleRight", false);
            anim.SetBool("isJumping", false);
            speed = wSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isIdleLeft", false);
            anim.SetBool("isIdleRight", false);
            anim.SetBool("isJumping", false);
            speed = wSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isIdleLeft", true);
            anim.SetBool("isIdleRight", false);
            anim.SetBool("isJumping", false);
            speed = wSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isIdleLeft", false);
            anim.SetBool("isIdleRight", true);
            anim.SetBool("isJumping", false);
            speed = wSpeed;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isIdleLeft", false);
            anim.SetBool("isIdleRight", false);
            anim.SetBool("isJumping", true);
            speed = wSpeed;
        }
        else
        {
            //Is Idle
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isIdle", true);
            anim.SetBool("isIdleLeft", false);
            anim.SetBool("isIdleRight", false);
            anim.SetBool("isJumping", false);
            speed = wSpeed;
        }
        var z = Input.GetAxis("Vertical") * speed;
        var x = Input.GetAxis("Horizontal") * rotSpeed; transform.Translate(0, 0, z);
        transform.Translate(x, 0, 0);
    }

}
