using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantLose : MonoBehaviour
{
    [SerializeField]
    Transform _returnPoint;

    Vector3 _startPOS;
    Rigidbody _rigidBody;
    [SerializeField]
    float _returnTime = 2f;
    WaitForSeconds _returnTimer;
    bool _waitingForReturn;

    // Start is called before the first frame update
    void Start()
    {
        _startPOS = transform.position;
        _rigidBody = GetComponent<Rigidbody>();
        _returnTimer = new WaitForSeconds(_returnTime);
    }

    IEnumerator CheckOutOfBounds()
    {
        while (true)
        {
            yield return new WaitForSeconds(_returnTime);
            if (transform.position.y < -10)
            {
                Return();
            }
        }
    }

    public void Return()
    {
        StartCoroutine(ReturnRoutine());
    }

    IEnumerator ReturnRoutine()
    {
        _waitingForReturn = true;
        yield return _returnTimer;
        _rigidBody.velocity = Vector3.zero;
        _rigidBody.angularVelocity = Vector3.zero;
        if (_returnPoint != null)
        {
            _rigidBody.position = _returnPoint.position;
        }
        else
        {
            _rigidBody.position = _startPOS;
        }
        _waitingForReturn = false;

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("VoidPlane") && !_waitingForReturn)
            Return();

    }
}
