using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    [SerializeField] int currentHitPoints = 0;

    Enemy enemy;

    void OnEnable() {
        currentHitPoints = maxHitPoints;
    }

    void Start() {
        enemy = GetComponent<Enemy>();
    }

     void OnParticleCollision(GameObject other) {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitPoints--;
        if(currentHitPoints <= 0){
            enemy.RewardGold();
            gameObject.SetActive(false);
        }
    }
}
