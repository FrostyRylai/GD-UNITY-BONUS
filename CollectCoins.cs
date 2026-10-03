using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    float ctr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ctr = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.name == "Coin")
        {
            ctr++;
            Destroy(hit.gameObject);
        }
        if (ctr >= 2)
        {
            CharacterController avatarCont = GetComponent<CharacterController>();
            avatarCont.stepOffset = 1;
        }
    }
}
