using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "New Part", menuName = "Part")]
public class Part : ScriptableObject
{
    public new string name;
    public string description;
    public GameObject model; //Didn't think about how to implement this.

    public float health;
    public float weight;

    public Bot GetBot { get { return bot; } }
    private Bot bot;

    public void Init(Bot bot)
    {
        this.bot = bot;
    }
    
    public virtual IEnumerator ExecuteAttack()
    {
        yield return null;
    }
}
