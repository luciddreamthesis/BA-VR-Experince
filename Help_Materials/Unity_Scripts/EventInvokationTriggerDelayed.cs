using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventInvokationTriggerDelayed : MonoBehaviour {

    [Header("Leave empty detect all collisions")]
    public string ColliderTag;
    
    [Space(5)]
    public bool EnterEventActive = true;
    public float EventDelayOnEnter = 0.0f;
    public UnityEvent OnTriggerEnterEvent;
    [Space(5)]
    public bool StayEventActive = true;
    public float EventDelayOnStay = 0.0f;
    public UnityEvent OnTriggerStayEvent;
    [Space(5)]
    public bool ExitEventActive = true;
    public float EventDelayOnExit = 0.0f;
    public UnityEvent OnTriggerExitEvent;
    
    // Use this for initialization
    void Start () {
        if (ColliderTag == null)
        {
            ColliderTag = "other";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //
    private void OnTriggerEnter(Collider ColliderTag)

    {

        Debug.Log("EnterTrigger");
        if (EnterEventActive)
        {
            StartCoroutine(DelayedOnEnter(EventDelayOnEnter));
            //  Debug.Log("entered");
        }
    }

    // stayCount allows the OnTriggerStay to be displayed less often
    // than it actually occurs.

    
    private void OnTriggerStay(Collider ColliderTag)
    {
        if (StayEventActive)
        {
            StartCoroutine(DelayedOnStay(EventDelayOnStay));

            // Debug.Log stayCount
            /**
             
            private float stayCount = 0.0f;
            if (stayCount > 0.25f)
            {
                Debug.Log("staying");
                stayCount = stayCount - 0.25f;
            }
            else
            {
                stayCount = stayCount + Time.deltaTime;
            }

            **/
        }
    }

    private void OnTriggerExit(Collider ColliderTag)
    {
        if (ExitEventActive)
        {
            StartCoroutine(DelayedOnExit(EventDelayOnExit));
            //   Debug.Log("exit");
        }
    }


    IEnumerator DelayedOnEnter(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        OnTriggerEnterEvent.Invoke();
    }

    IEnumerator DelayedOnStay(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        OnTriggerStayEvent.Invoke();
    }

    IEnumerator DelayedOnExit(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        OnTriggerExitEvent.Invoke();
    }


}
