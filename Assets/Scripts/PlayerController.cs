using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpForce = 10f;
    [SerializeField]
    private float gravity = -9.81f;

    private CharacterController characterController;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        bool isGrounded = characterController.isGrounded;

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2;
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y += jumpForce;

        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 horizonalMovement = transform.right * x;
        Vector3 verticalMovement = transform.forward * z;

        Vector3 movement = horizonalMovement + verticalMovement;

        characterController.Move(movement * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}
