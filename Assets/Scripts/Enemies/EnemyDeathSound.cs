using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathSound : MonoBehaviour
{
    private EnemyCollide enemyCollide;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        enemyCollide = GetComponent<EnemyCollide>();
        enemyCollide.OnEnemyStomped += EnemyCollide_OnEnemyStomped;
    }

    private void EnemyCollide_OnEnemyStomped(object sender, System.EventArgs e)
    {
        audioSource.Play();
    }
}
