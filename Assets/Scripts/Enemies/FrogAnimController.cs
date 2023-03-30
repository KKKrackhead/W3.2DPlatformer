using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogAnimController : MonoBehaviour
{
    private FrogAI frogAI;
    private Animator anim;
    private EnemyCollide collide;

    private void Start()
    {
        frogAI = GetComponent<FrogAI>();
        anim = GetComponent<Animator>();
        collide = GetComponent<EnemyCollide>();

        frogAI.OnFrogJump += FrogAI_OnFrogJump;
        frogAI.OnFrogFall += FrogAI_OnFrogFall;
        frogAI.OnFrogLand += FrogAI_OnFrogLand;
        collide.OnEnemyStomped += Collide_OnEnemyStomped;
    }

    private void Collide_OnEnemyStomped(object sender, System.EventArgs e)
    {
        anim.SetTrigger("Death");
    }

    public void FrogUnalive()
    {
        Destroy(this.gameObject);
    }

    private void FrogAI_OnFrogLand(object sender, System.EventArgs e)
    {
        anim.SetBool("Falling", false);
    }

    private void FrogAI_OnFrogFall(object sender, System.EventArgs e)
    {
        anim.SetBool("Falling", true);
        anim.SetBool("Jumping", false);
    }

    private void FrogAI_OnFrogJump(object sender, System.EventArgs e)
    {
        anim.SetBool("Jumping", true);
    }

    
}
