using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathAnim : MonoBehaviour
{
    protected Animator anim;
    private EnemyCollide enemyCollide;

    protected virtual void Start()
    {
        anim = GetComponent<Animator>();
        enemyCollide = GetComponent<EnemyCollide>();
        enemyCollide.OnEnemyStomped += EnemyCollide_OnEnemyStomped;
    }

    private void EnemyCollide_OnEnemyStomped(object sender, System.EventArgs e)
    {
        anim.SetTrigger("Death");
    }

    public void EnemyDie()
    {
        Destroy(this.gameObject);
    }
}
