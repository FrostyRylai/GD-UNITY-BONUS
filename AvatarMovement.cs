using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AvatarMovement : MonoBehaviour
{
    CharacterController avatarCont;
    float jump;
    float drop;
    bool canjump;
    bool last;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        avatarCont = GetComponent<CharacterController>();
        jump = 0;
        canjump = false;
        last = false;
        drop = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!last)
        {
            float movX = 0, movZ = 0;
            if (Keyboard.current.aKey.isPressed)
            {
                movX = .05f;
            }

            if (Keyboard.current.dKey.isPressed)
            {
                movX = -.05f;
            }

            if (Keyboard.current.wKey.isPressed)
            {
                movZ = -.05f;
            }

            if (Keyboard.current.sKey.isPressed)
            {
                movZ = .05f;
            }

            if (Keyboard.current.kKey.isPressed)
            {
                avatarCont.height = 0.1f;
            }

            if (Keyboard.current.spaceKey.isPressed && canjump == true)
            {
                jump = 1.5f;
            }

            if (!avatarCont.isGrounded)
            {
                jump = -0.05f;
            }


            avatarCont.Move(new Vector3(movX, jump, movZ));
            float rotY = Mouse.current.delta.ReadValue().x;
            transform.Rotate(0, rotY, 0);
            //avatarCont.stepOffset = 1;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.name == "Jump")
        {
            Destroy(hit.gameObject);
            canjump = true;
        }

        if (hit.collider.name == "End")
        {
            last = true;
        }
    }
}
