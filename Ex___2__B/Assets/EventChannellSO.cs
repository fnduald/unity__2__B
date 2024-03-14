using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

[CreatAssetMenu(fileName = "NewEventChannel" , menuName = "Events/Event Channel")]

public class EventChannellSO : ScrptableObject
{
    public UnityEvent OnEventRaised;

    public void RaiseEvent()
    {
        if(OnEventRaised !=null)
        {
            OnEventRaised.invoke();
        }
    }

}
