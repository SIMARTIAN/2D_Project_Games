using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lava : MonoBehaviour
{

    public Vector2 respawnPoint = new Vector2(0f, 0f);
    public float respawnDelay = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(RespawnPlayerDelayed(other.gameObject));

        }
    }

    private IEnumerator RespawnPlayerDelayed(GameObject player)
    {
        yield return new WaitForSeconds(respawnDelay); 
        RespawnPlayer(player);
    }

    void RespawnPlayer(GameObject player)
    {
        player.transform.position = respawnPoint;
       
    }
}
