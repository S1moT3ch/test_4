using UnityEngine;

public class TuboAnim : MonoBehaviour
{
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()//se non è stato cliccato il portellone del tupo, non far nulla, altrimenti aprilo
    {
        if(Tubo.istance.apriT == false)
        {
            animator.SetBool("apri", false);
        }
        else
        {
            animator.SetBool("apri", true);
        } 
    }
}
