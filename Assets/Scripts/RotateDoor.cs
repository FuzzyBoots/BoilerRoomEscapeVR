using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDoor : MonoBehaviour
{
    [SerializeField]
    float _rotationSpeed = 5f;
    [SerializeField]
    Quaternion _targetAngle;
 
    // Start is called before the first frame update
    void Start()
    {
        _targetAngle = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _targetAngle, _rotationSpeed * Time.deltaTime);
    }

    public void Rotate(float value)
    {
        Vector3 rotation = this.transform.eulerAngles;
        rotation.y = 90f * value;
        _targetAngle = Quaternion.Euler(rotation);
    }
}
