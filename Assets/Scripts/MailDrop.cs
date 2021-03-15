using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailDrop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Mail dropped");
        Destroy(gameObject);
    }
}
