using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] CharacterController controller;
    [SerializeField] int speed;
    [SerializeField] int jumpPower;
    [SerializeField] int jumpCountMax;
    [SerializeField] int gravity;

    Vector3 moveDir;
    Vector3 playerVel;
    int jumpCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement()
    {
        if (controller.isGrounded)
        {
            jumpCount = 0;
            playerVel = Vector3.zero;
        }

        moveDir = (Input.GetAxis("Horizontal") * transform.right) + (Input.GetAxis("Vertical") * transform.forward);
        controller.Move(moveDir * speed * Time.deltaTime);

        jump();
        playerVel.y -= gravity * Time.deltaTime;
        controller.Move(playerVel * Time.deltaTime);
    }

    void jump()
    {
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            playerVel.y = jumpPower;
            jumpCount++;
        }
    }
}
