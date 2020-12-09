using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public  class ConversetionParticipents : MonoBehaviour
{

   public void update()
   {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
   }

    protected IMediator _mediator;

    public ConversetionParticipents(IMediator mediator)
    {
        _mediator = mediator;
    }
}





public interface IMediator
{
    void SendMessage(ConversetionParticipents caller, string msg);
}

public class ConcreteMediator : IMediator
{
    public Ron Colleague1 { get; set; }

    public Yotam Colleague2 { get; set; }

    public void SendMessage(ConversetionParticipents caller, string msg)
    {
        if (caller == Colleague1)
            Colleague2.Receive(msg);
        else
            Colleague1.Receive(msg);
    }
}


