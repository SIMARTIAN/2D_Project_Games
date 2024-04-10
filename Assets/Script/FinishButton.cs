using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishButton : MonoBehaviour
{

    public GameObject finishWindow;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ShowFinishWindow();
        }
    }


    private void ShowFinishWindow()
    {
        finishWindow.SetActive(true);
    }








}
