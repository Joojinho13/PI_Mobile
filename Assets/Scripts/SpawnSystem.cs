using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public GameObject Projectile;
    
    public float Timerinicial;
    public float FrequenciaTiro;

    void Start()
    {
        InvokeRepeating("SpawnInimigo", Timerinicial, FrequenciaTiro);  
    }

    void Update()
    {
        
    }

    public void SpawnInimigo()
    {
        Instantiate(Projectile, new Vector2(12, Random.Range(4.5f,-4.5f)), transform.rotation);
    }
}
