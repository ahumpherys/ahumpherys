using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    //Trigger so when object hits other it names the object
    //private void Ontriggerenter(collider.other)
    //print(other.name);
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}