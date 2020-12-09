using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class Prefs
{
    public int healt;
    public int life;
    public float armor;

}
public class PrefManager
{
    public List<Prefs> prefsList;
}
