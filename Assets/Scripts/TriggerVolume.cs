using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerVolume : MonoBehaviour
{
    [SerializeField] List<string> TagsToCheck;
    [SerializeField] UnityEvent OnTriggered = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TagsToCheck.Contains(other.tag))
        {
            OnTriggered.Invoke();
        }
    }
}
