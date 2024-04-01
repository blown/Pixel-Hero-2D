using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private bool isHit;
    private int IdisHit;
    private Transform transformEnemy;

    
    private void Start()
    {
        animator = GameObject.Find("Bat").GetComponent<Animator>();
        IdisHit = Animator.StringToHash("isHit");
        transformEnemy = GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UIManager.instance.RestartGame();
        }
        else if (other.CompareTag("Bat"))
        {
            transformEnemy = GameObject.Find(other.name).GetComponent<Transform>();
            isHit = true;
            animator.SetBool(IdisHit, isHit);
            Destroy(gameObject);
        }
    }

}
