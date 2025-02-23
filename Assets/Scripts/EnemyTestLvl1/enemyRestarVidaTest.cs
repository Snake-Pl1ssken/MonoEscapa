using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRestarVidaTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Chocando con player");
            ConsciousnessBar.instance.takeDamage(10);
        }
    }
}
