using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(AudioSource))]
public class Shatter : MonoBehaviour
{
    [SerializeField]
    int _locks = 2;

    [SerializeField]
    Animator _doorAnimator;

    [SerializeField]
    XROrigin _XROrigin;

    AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        if (_doorAnimator == null)
        {
            Debug.LogError("No door animator is set on the chains");
        }

        _audioSource= GetComponent<AudioSource>();
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
        
        if (obj.CompareTag("SmashTool"))
        {
            if (_locks <= 0)
            {
                Destroy(gameObject);

                _audioSource.Play();

                _doorAnimator.SetTrigger("OpenDoor");
            }
            else
            {
                // Play sound?
                // Give hint?
            }
        }
    }
}
