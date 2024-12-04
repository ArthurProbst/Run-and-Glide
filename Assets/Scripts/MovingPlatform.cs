using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform pos1;
    [SerializeField] Transform pos2;
    [SerializeField] GameObject platform;
    [SerializeField] int speed;

    Transform dest;

    // Start is called before the first frame update
    void Start()
    {
        dest = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, dest.position, speed * Time.deltaTime);
        ChangePositions();
    }

    void ChangePositions()
    {
        if (platform.transform.position == dest.position && dest == pos1)
        {
            dest = pos2;
        }
        else if (platform.transform.position == dest.position && dest == pos2)
        {
            dest = pos1;
        }
    }
}
