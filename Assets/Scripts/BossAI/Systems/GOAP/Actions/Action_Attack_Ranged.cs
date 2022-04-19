﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Attack_Ranged : Action_Base
{
    List<System.Type> SupportedGoals = new List<System.Type>(new System.Type[] { typeof(Goal_Attack_Ranged) });

    Goal_Attack_Ranged RangedAttackGoal;

    public override List<System.Type> GetSupportedGoals()
    {
        return SupportedGoals;
    }

    public override float GetCost()
    {
        return 0;
    }

    public override void OnActivated(Goal_Base _linkedGoal)
    {
        base.OnActivated(_linkedGoal);
        
        //Actually Attack here
        //then change AttackPriority
        Debug.Log("Attack");
    }

    public override void OnDeactivated()
    {
        base.OnDeactivated();
        
        RangedAttackGoal = null;
    }

    public override void OnTick()
    {
        //if enemy is in range repeat is possible here
        //if (MeleeAttackGoal.distanceBetween <= MeleeAttackGoal.attackRange)
        //     OnActivated(LinkedGoal);
        
    }
}