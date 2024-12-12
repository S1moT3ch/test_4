using UnityEngine;

public class GirapAnim : MonoBehaviour
{
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()//se non è stato cliccato sul gira provette, non far nulla, altrimenti aprilo e chiudilo
    {
        if(giraProvette.istance.clickOnA == false)
        {
            animator.SetBool("apriGiraP", false);
        }
        else
        {
            animator.SetBool("apriGiraP", true);
            animator.SetBool("apriGiraP", false);
            giraProvette.istance.clickOnA = false;
        }
    } 
}