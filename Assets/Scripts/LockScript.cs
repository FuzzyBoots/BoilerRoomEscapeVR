using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRSocketInteractor))]
public class LockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableInsertedItem()
    {
        XRSocketInteractor socketInteractor = GetComponent<XRSocketInteractor>();
        if (socketInteractor == null)
            Debug.LogError("null socketInteractor");

        IXRSelectInteractable interactable = socketInteractor.GetOldestInteractableSelected();
        if (interactable == null)
            Debug.LogError("null selected item");

        GameObject obj = interactable.transform.gameObject;
        
        obj?.SetActive(false);     
    }
}
