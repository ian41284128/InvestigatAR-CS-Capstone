using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_question1 : MonoBehaviour
{
    public GameObject target;
    public float appearTime;

    // Start is called before the first frame update
    void Start()
    {
        target.SetActive(false);
        Invoke("appear", appearTime);
        //Destroy(gameObject, duration); //3f
    }

    void appear()
    {
        // Set the object's active state to true, making it appear
         target.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(target);
        }
    }
}
