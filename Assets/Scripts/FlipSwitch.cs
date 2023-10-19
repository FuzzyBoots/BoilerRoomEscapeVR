using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSwitch : MonoBehaviour
{
    [SerializeField] private bool _state = true;
    [SerializeField] private GameObject _target;
    // Start is called before the first frame update
    void Start()
    {
        _target.SetActive(_state);    
    }

    public void FlipState()
    {
        _state = !_state;
        _target.SetActive(_state);
    }
}
