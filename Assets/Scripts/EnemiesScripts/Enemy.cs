using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState{
    idle,
    walk,
    attak,
    stagger
}

public class Enemy : MonoBehaviour
{
    [Header("State Machine")]
    public EnemyState currentState;
    
    [Header("Enemy Stats")]
    public FloatValue maxHealth;
    public float health;
    public string enemyName;
    public int baseAtack;
    public float moveSpeed;
    
    [Header("Death Effects")]
    public GameObject deathEffect;
    private float deathEffectDelay = 1f;
    
    public void Awake(){
        health = maxHealth.RuntimeValue;
    }

    private void TakeDamage(float damage){
        Debug.Log("Vida inical"+health);
        health -= damage;
        Debug.Log("Vida restante"+health);
        Debug.Log("Dano sofrido "+damage);
        if(health <= 0){
            DeathEffect();
            this.gameObject.SetActive(false);

        }
    }

    private void DeathEffect(){
        if(deathEffect != null){
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, deathEffectDelay);
        }
    }

    public void Knock(Rigidbody2D myRigidbody, float knockTime, float damage){
        StartCoroutine(KnockCo(myRigidbody, knockTime));
        TakeDamage(damage);
    }
    
    private IEnumerator KnockCo(Rigidbody2D myRigidbody, float knockTime){
        if (myRigidbody != null ){
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = EnemyState.idle;
        }
    }
}
