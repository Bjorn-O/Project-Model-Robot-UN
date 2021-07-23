using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Part/GunArm")]
public class GunArm : Part
{
    public GameObject bullet;

    override public IEnumerator ExecuteAttack()
    {
        Debug.Log("Start Shooting Attack");
        GameObject go = Instantiate<GameObject>(bullet);
        Bot bot = this.GetBot;
        go.GetComponent<Bullet>().Init(
            bot.transform.position + bot.transform.forward,
            bot.transform.forward, 
            10);
        yield return new WaitForSeconds(1);
        Debug.Log("End Attack");
    }
}
