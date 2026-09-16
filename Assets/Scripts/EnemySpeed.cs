using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour
{    
    private GameObject enemy;
    public GameObject player;
    private Vector3 playerPos;
    private Vector3 enemyPos;
    private float distanceSqrd;
    public float orbitSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        enemy = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = transform.position;
        playerPos = player.transform.position;
        distanceSqrd = (enemyPos - playerPos).sqrMagnitude;

        orbitSpeed = distanceSqrd * orbitSpeed;

    }
}
