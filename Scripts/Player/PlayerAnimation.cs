using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.istance.cammina == false) //se il player è fermo, nessuna animazione, altrimenti riproduci l'animazione del movimento
        {
            animator.SetBool("Cammina", false);
        }
        else
        {
            animator.SetBool("Cammina", true);
        }
    }
}
