using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrbit : MonoBehaviour
{
    public Transform player;
    public float orbitSpeed = 20f;
    private float currentAngle;
    private Vector3 offsetFromPlayer;

    // Start is called before the first frame update
    void Start()
    {
        offsetFromPlayer = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentAngle += orbitSpeed * Time.deltaTime;

        Quaternion rotation = Quaternion.Euler(0f,0f,currentAngle);

        Vector3 rotatedOffset = rotation * offsetFromPlayer;

        transform.position = player.position + rotatedOffset;
    }
}
