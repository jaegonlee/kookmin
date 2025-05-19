using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D playerRigidbody;
    Animator playerAnimator;
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.linearVelocityX = 2.5f;
            transform.localScale = new Vector3(1, 1, 1);
            playerAnimator.SetInteger("PlayerState", 1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.linearVelocityX = -2.5f;
            transform.localScale = new Vector3(-1, 1, 1);
            playerAnimator.SetInteger("PlayerState", 1);
        }
        else
        {
            playerRigidbody.linearVelocityX = 0;
            playerAnimator.SetInteger("PlayerState", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            playerAnimator.SetTrigger("PlayerAttack");
        }
    }
}

