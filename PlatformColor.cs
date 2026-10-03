using UnityEngine;

public class PlatformColor : MonoBehaviour
{
    [SerializeField]
    MeshRenderer Platform1, Platform2, Platform3;
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
        if (hit.collider.name == "Platform1")
        {
            Platform1.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        if (hit.collider.name == "Platform2")
        {
            Platform2.material.color = Color.red;
        }
        if (hit.collider.name == "Platform3")
        {
            Platform3.material.color = Color.blue;
        }
    }
}
