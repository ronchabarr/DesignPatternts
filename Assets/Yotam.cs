using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yotam : ConversetionParticipents
{
    public Yotam(IMediator mediator) : base(mediator) { }

    public void Send(string msg)
    {
        Debug.Log("yotams message:" + msg);
        _mediator.SendMessage(this, msg);
    }

    public void Receive(string msg)
    {
        Debug.Log("yotams message:" + msg);
    }
}
