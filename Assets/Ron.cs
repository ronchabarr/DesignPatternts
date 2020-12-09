using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ron : ConversetionParticipents
{
    public Ron(IMediator mediator) : base(mediator) { }

    public void Send(string msg)
    {
        Debug.Log("Rons Message:" + msg);
        _mediator.SendMessage(this, msg);
    }

    public void Receive(string msg)
    {
        Debug.Log("Rons Message:" + msg);
    }
}
