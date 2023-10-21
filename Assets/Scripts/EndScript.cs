using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _endingText;
    // Start is called before the first frame update
    void Start()
    {
        if (_endingText == null)
        {
            Debug.LogError("No ending text assigned!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Stop the player?
        _endingText.gameObject.SetActive(true);
    }
}
