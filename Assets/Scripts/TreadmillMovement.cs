using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] int speed;
    [SerializeField] Vector3 direction;

    bool playerOnTop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOnTop)
        {
            player.GetComponent<Rigidbody>().AddForce(speed * direction);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        other.transform.parent = gameObject.transform;
        playerOnTop = true;
    }

    void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
        playerOnTop = false;
    }
}
