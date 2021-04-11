using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailDrop : MonoBehaviour
{
    public static int mailCount = 0;
    public CarController carCtr;
    private void Start()
    {
        ++MailDrop.mailCount;
    }
    private void LateUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 0.1f);
        }
    }
    private void OnDestroy()
    {
        --MailDrop.mailCount;
        if (MailDrop.mailCount <= 0)
        {
            carCtr.gameOver = true;
            Debug.Log("Win");
        }
    }
}
