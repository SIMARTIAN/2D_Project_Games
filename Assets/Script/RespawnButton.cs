using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnButton : MonoBehaviour
{

    public GameObject player;
    public Vector3 initialPlayerPosition = new Vector3(-2.04f, 4.69f, 0f);

    public GameObject finishWindow;



    public void RespawnPlayer()
    {
        Debug.Log("Гравець респавнується на позицію: " + initialPlayerPosition);
        player.transform.position = initialPlayerPosition;

        finishWindow.SetActive(false);
    }
}
