using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapperingPlatform : MonoBehaviour
{
    [SerializeField] GameObject platform;
    [SerializeField] float timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flash();
            Destroy(platform, timer);
        }
    }

    IEnumerator flash()
    {
        platform.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(1);
        platform.GetComponent<Renderer>().material.color = Color.white;
    }
}
