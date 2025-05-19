using UnityEngine;

public class Chest : MonoBehaviour
{

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
    
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger On Player");
            animator.SetTrigger("Open");
        }
    }
}
