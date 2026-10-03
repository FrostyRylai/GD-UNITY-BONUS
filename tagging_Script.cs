using UnityEngine;

public class tagging_Script : MonoBehaviour
{
    GameObject[] grpObjects;
    float ctr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        grpObjects = GameObject.FindGameObjectsWithTag("TX32");
        foreach (GameObject obj in grpObjects)
        {
            Debug.Log(obj.name);
        }
        ctr = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        grpObjects = GameObject.FindGameObjectsWithTag("TX32");
        ctr += Time.deltaTime;
        if (ctr >= 2 && grpObjects.Length > 0)
        {
            Destroy(grpObjects[0]);
            ctr = 0;
        }
    }
}
