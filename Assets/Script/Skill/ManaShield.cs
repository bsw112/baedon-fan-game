﻿
using UnityEngine;
using System.Collections;

public sealed class ManaShield : BaseSkill
{
    UnityEngine.Object manaShield;

    //쿨타임 정해주기
    public ManaShield()
       : base(5F, 2F)
    {

    }


    public override string getName()
    {
        return "ManaShield";
    }


    protected override IEnumerator  onActivate(CharacterStats target)
    {
        target.manaBarrierActivate();
        manaShield = GameObject.Instantiate(Resources.Load("Prefabs/ManaShield"), target.transform, false);
        yield return null;
    }


    protected override void onInactivate(CharacterStats target)
    {
        target.manaBarrierInactivate();
        if(manaShield != null)
            GameObject.Destroy(manaShield);

    }

 
}
