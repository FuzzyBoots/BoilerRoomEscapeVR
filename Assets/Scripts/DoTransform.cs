using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoTransform : MonoBehaviour
{
    [SerializeField]
    float _translateSpeed = 5f;
    [SerializeField]
    float _rotateSpeed = 45f;
    [SerializeField]
    Transform _targetTransform;

    private float _transformPosition;
 
    // Start is called before the first frame update
    void Start()
    {
        if ( _targetTransform == null )
        {
            _targetTransform = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetTransform.position, _translateSpeed * Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _targetTransform.rotation, _rotateSpeed * Time.deltaTime);
    }
}
