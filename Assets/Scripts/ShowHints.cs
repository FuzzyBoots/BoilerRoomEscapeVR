using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowHints : MonoBehaviour
{
    [SerializeField] private string[] _hintList = { };
    [SerializeField] private TMP_Text _text;
    [SerializeField] private int _hintIndex = 0;

    private bool _displayingHint = false;
    [SerializeField] private float _delayTime = 2f;

    public void  ShowNextHint()
    {
        if (!_displayingHint)
        {
            _text.text = _hintList[_hintIndex];
            _hintIndex = (_hintIndex + 1) % _hintList.Length;
            _displayingHint = true;
            StartCoroutine(HideHint());
        }        
    }

    IEnumerator HideHint()
    {
        yield return new WaitForSeconds(_delayTime);
        _text.text = "";
        _displayingHint = false;
    }
}
