using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAfterDelay : MonoBehaviour
{
    [SerializeField]
    private float _delay = 5f;
    [SerializeField]
    GameObject _itemToHide = null;

    public void HideThisAfterDelay()
    {
        StartCoroutine(DelayThenHide());
    }

    IEnumerator DelayThenHide()
    {
        _itemToHide.SetActive(true);
        yield return new WaitForSeconds(_delay); 
        _itemToHide.SetActive(false);
    }
}
