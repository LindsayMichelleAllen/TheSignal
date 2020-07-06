using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float rotateSpeed = 0.4f;
    public float gravity = -9.81f;
    public float jumpHeight = 5f;
    Vector3 velocity;

    void Start() {
        if(controller == null){
            controller = GetComponent<CharacterController>();
        }
    }

    void Update()
    {
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        /* Move Object */
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        /* *********** */

        /* Rotate Object */
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        var forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
        /* ************* */

        if (Input.GetButton("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }
}
