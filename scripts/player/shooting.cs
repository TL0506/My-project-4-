using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<enemyMovement>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
