using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [Header("NPC資料")]
    public NPCData data;
    [Header("對話框")]
    public GameObject dialoug;
    [Header("對話內容")]
    public Text textContent;
    
    public bool playerInArea;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "帥哥哥")
        {
            playerInArea = true;
            Dialoug();
        }
    }
     private void OnTriggerExit(Collider other)
        {
            if (other.name == "帥哥哥")
            {
                playerInArea = false;
            }
        }
    private void Dialoug()
     {
        for (int i = 0; i < data.dialougA.Length; i++)
        {
            print(data.dialougA[i]);
        }
     }
    }