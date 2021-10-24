using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour
{
    bool switchState;
    public Material mActive, mInactive;
    Transform player;

    MeshRenderer meshRenderer;

    public UnityEvent onActivationEvent, onDeactivationEvents;
    void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerEnter()
    {
        
        if (switchState == true)
        {
            switchState = false;
            meshRenderer.material = mInactive;
            onDeactivationEvents.Invoke();
        }
        else
        {
            switchState = true;
            meshRenderer.material = mActive;
            onActivationEvent.Invoke();
        }

        /*
         * switchState = !switchState;
         * meshRenderer.material = switchState ? mActive : mInactive;
         */
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
