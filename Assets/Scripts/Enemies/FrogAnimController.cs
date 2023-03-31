using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogAnimController : EnemyDeathAnim
{
    private FrogAI frogAI;

    protected override void Start()
    {
        base.Start();
        frogAI = GetComponent<FrogAI>();

        frogAI.OnFrogJump += FrogAI_OnFrogJump;
        frogAI.OnFrogFall += FrogAI_OnFrogFall;
        frogAI.OnFrogLand += FrogAI_OnFrogLand;
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
