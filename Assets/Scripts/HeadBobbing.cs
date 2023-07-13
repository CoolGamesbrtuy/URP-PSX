using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBobbing : MonoBehaviour
{
    public Animator camAnim;
    public bool walking;

    void Update()
    {
        // Check gamepad input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
            camAnim.ResetTrigger("idle");
            walking = true;
            camAnim.ResetTrigger("sprint");
            camAnim.SetTrigger("walk");
            
            if (walking)
            {
                // Check gamepad input for sprinting
                if (Input.GetButton("Sprint"))
                {
                    camAnim.ResetTrigger("walk");
                    camAnim.ResetTrigger("idle");
                    camAnim.SetTrigger("sprint");
                }
            }
        }
        else
        {
            camAnim.ResetTrigger("sprint");
            walking = false;
            camAnim.ResetTrigger("walk");
            camAnim.SetTrigger("idle");
        }
    }
}