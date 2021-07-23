using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sword", menuName = "Part/SwordArm")]
public class SwordArm : Part
{
    override public IEnumerator ExecuteAttack()
    {
        Debug.Log("Start Slash Attack");
        yield return new WaitForSeconds(1);
        Debug.Log("End Attack");
    }
}
