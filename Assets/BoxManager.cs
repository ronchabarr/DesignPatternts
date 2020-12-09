using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BoxManager : MonoBehaviour
{
   
    public GameObject[] boxObjects;
    List<Observer> boxes = new List<Observer>();
    void Start()
    {
        
       foreach(GameObject found in boxObjects)
        {
            Observer obs= found.GetComponent<Observer>();
            Attach(obs);
        }
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Notify();
        }
        foreach (Observer found in boxes)
        {
            if (found.gameObject.transform.position.y > 5)
            {
                detach(found);
            }
        }

        
    }

        
    public void Notify()
    {
        foreach(Observer found in boxes)
        {
            found.doshit();
            
        }
    }
    public void Attach(Observer box)
    {
        boxes.Add(box);
    }
    public void detach(Observer box)
    {
        boxes.Remove(box);
    }
}




public  class Observer : BoxManager
{ 
    public void doshit()
    {
        transform.position += Vector3.up;
    }
   
}