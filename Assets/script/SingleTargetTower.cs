﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTargetTower : Tower
{
    private Enemy _target;

    protected override bool CanAttack()
    {
        _target = _rangeChecker.GetFirstEnemyInRange();
        return _target != null;
    }


    protected override void Attack()

    {
        Debug.Log("hahah me go pew.");
    }



}
