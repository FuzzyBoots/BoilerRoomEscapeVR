using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatter : MonoBehaviour
{
    [SerializeField]
    int _locks = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LockRemoved()
    {
        _locks--;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        Debug.Log($"{obj.name} - {obj.tag}");
        if (obj.CompareTag("SmashTool"))
        {
            if (_locks <= 0)
            {
                Destroy(gameObject);

                // Play sound?
            }
            else
            {
                // Play sound?
                // Give hint?
            }
        }
    }
}
