using UnityEngine;

public class animationStateController : MonoBehaviour
{
    public Joystick joystick;
    Animator animator;
    bool verticalMove;
    bool horizontalMove;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isRunning = animator.GetBool("isRunning");
        if (joystick.Vertical != 0)
        verticalMove = true;
        else 
        verticalMove = false;
         if (joystick.Horizontal != 0)
        horizontalMove = true;
        else 
        horizontalMove = false;
        
       

        if (!isRunning && verticalMove || horizontalMove)
        {
            animator.SetBool("isRunning", true);
        }

        if (isRunning && !verticalMove && !horizontalMove)
        {
            animator.SetBool("isRunning", false);
        }

    }

}
