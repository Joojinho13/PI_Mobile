using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    public int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LifeSystem lifeSystem = other.GetComponent<LifeSystem>();

            if (lifeSystem != null)
            {
                lifeSystem.TakeDamage(damageAmount);

                Destroy(gameObject);
            }
        }
    }
}

