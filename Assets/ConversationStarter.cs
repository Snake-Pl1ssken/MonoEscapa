using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class ConversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConver;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            { 
                ConversationManager.Instance.StartConversation(myConver);
            }
        }
    }
}
