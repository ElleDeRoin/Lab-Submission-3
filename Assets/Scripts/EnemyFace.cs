using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFace : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 360f;
    void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position);
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, rotationSpeed * Time.deltaTime);
        }
    }
}