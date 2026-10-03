using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    CharacterController avatarCont;
    bool canjump;
    float jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canjump)
        {
            if (Keyboard.current.spaceKey.isPressed && avatarCont.isGrounded)
            {
                jump = 0.5f;
            }
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.name == "Jump")
        {
            Destroy(hit.gameObject);
            canjump = true;
        }
        
    }
}
