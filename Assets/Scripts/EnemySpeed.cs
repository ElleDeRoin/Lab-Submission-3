using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour
{
    public float speed = 5f;

    private GameObject enemy;
    public GameObject player;
    private Vector2 playerPos;
    private Vector2 enemyPos;
    private float distance;

    //testing
    public Vector2 startPos;
    public Vector2 endPos;
    
    // Start is called before the first frame update
    void Start()
    {
        enemy = gameObject;
        enemy.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = transform.position;
        //Debug.Log(enemyPos.sqrMagnitude);
        playerPos = transform.position;
        Debug.Log(playerPos.sqrMagnitude);
        distance = Vector2.Distance(enemyPos, playerPos);
        //Debug.Log(distance);

        if(playerPos.magnitude == 0)
        {
            speed = 5;
        }
        else
        {
            speed = distance * speed;
        }

        // testing
        float t = (Mathf.Sin(Time.deltaTime * speed) + 1f) / 2f;
        enemy.transform.position = Vector2.Lerp(startPos, endPos, t);
    }
}
