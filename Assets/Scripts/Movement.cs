using UnityEngine;

public class Movement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            transform.localScale = new Vector3(transform.localScale.x, 1.5f, transform.localScale.z);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            transform.localScale = new Vector3(transform.localScale.x, 3f, transform.localScale.z);
        }
    }
    void FixedUpdate()
    {
       controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }
}
