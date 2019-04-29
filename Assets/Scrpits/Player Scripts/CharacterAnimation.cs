﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    public void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void Walk(bool move)
    {
        anim.SetBool(AnimationTags.MOVEMENT, move);
    }
    public void Punch_1()
    {
        anim.SetTrigger(AnimationTags.PUNCH_1_TRIGGER);
    }
    public void Punch_2()
    {
        anim.SetTrigger(AnimationTags.PUNCH_2_TRIGGER);
    }
    public void Punch_3()
    {
        anim.SetTrigger(AnimationTags.PUNCH_3_TRIGGER);
    }
    public void Kcik_1()
    {
        anim.SetTrigger(AnimationTags.KICK_1_TRIGGER);
    }
    public void Kcik_2()
    {
        anim.SetTrigger(AnimationTags.KICK_2_TRIGGER);
    }

    // enemy animation

    public void EnemyAttack(int attack)
    {
        if(attack == 0){
            anim.SetTrigger(AnimationTags.ATTACK_1_TRIGGER);
        }
        if(attack == 1){
            anim.SetTrigger(AnimationTags.ATTACK_2_TRIGGER);
        }
        if(attack == 2){
            anim.SetTrigger(AnimationTags.ATTACK_3_TRIGGER);
        }
    }//enemy attack

    public void Play_IdleAnimation(){
        anim.Play(AnimationTags.IDEL_ANIMATION);
    }

    public void Knockdown(){
        anim.SetTrigger(AnimationTags.KNOCK_DOWN__TRIGGER);
    }
    public void StandUp(){
        anim.SetTrigger(AnimationTags.STAND_UP_TRIGGER);
    }

    public void HIT(){
        anim.SetTrigger(AnimationTags.HIT_TRIGGER);
    }

    public void DEATH(){
        anim.SetTrigger(AnimationTags.DEATH_TRIGGER);
    }


}//class























