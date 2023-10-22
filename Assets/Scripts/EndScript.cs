using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EndScript : MonoBehaviour
{
    [SerializeField] private TMP_Text _endingText;
    // Start is called before the first frame update
    [SerializeField] private XROrigin _XROrigin;

    void Start()
    {
        if (_endingText == null)
        {
            Debug.LogError("No ending text assigned!");
        }

        if (_XROrigin == null)
        {
            _XROrigin = FindObjectOfType<XROrigin>();
            if (_XROrigin == null)
            {
                Debug.LogError("No valid XR Origin was found in the scene.");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _endingText.gameObject.SetActive(true);

            ContinuousMoveProviderBase moveBase = _XROrigin.GetComponent<ContinuousMoveProviderBase>();
            if (moveBase != null)
            {
                moveBase.enabled = false;
            }
        }
        
    }
}
