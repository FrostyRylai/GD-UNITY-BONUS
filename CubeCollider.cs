using UnityEngine;

public class CubeCollider : MonoBehaviour
{
    [SerializeField]
    GameObject Match1;
    [SerializeField]
    MeshRenderer Match1Render;
    [SerializeField]
    GameObject Match2;
    [SerializeField]
    MeshRenderer Match2Render;
    bool checkMatch;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.name == "Match1")
        {
            hit.collider.GetComponent<MeshRenderer>().material.color =
            Random.Range(0, 20) % 3 == 0 ?
            Color.red : Random.Range(0, 20) % 3 == 1 ?
            Color.green : Color.blue;
        }

        if (hit.collider.name == "Match2")
        {
            hit.collider.GetComponent<MeshRenderer>().material.color =
            Random.Range(0, 20) % 3 == 0 ?
            Color.red : Random.Range(0, 20) % 3 == 1 ?
            Color.green : Color.blue;
        }

        if(Match1Render.material.color == Match2Render.material.color)
        {
            CharacterController avatarCont = GetComponent<CharacterController>();
            avatarCont.radius = 0.1f;
        }

        /*
        if (hit.collider.name == "Match")
        {
            hit.collider.GetComponent<MeshRenderer>().material.color =
            Random.Range(0, 20) % 3 == 0 ?
            Color.red : Random.Range(0, 20) % 3 == 1 ?
            Color.green : Color.blue;
            checkMatch = true;
        }

        if (checkMatch)
        {
            if (s1.material.color == s2.material.color)
            {
                CharacterController avatarCont = GetComponent<CharacterController>();
            avatarCont.radius = 0.1f;
            }
        }
        */

    }
}
