using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }
    public void Magic()
    {
        
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }

}

public class Test : MonoBehaviour
{
    

    private void Start()
    {
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 3;
        array[2] = 5;
        array[3] = 7;
        array[4] = 9;

        for(int i = 0; i < array.Length; i ++)
        {
            Debug.Log(array[i]);
        }
        for(int i = array.Length - 1; i>= 0; i --)
        {
            Debug.Log(array[i]);
        }
        Boss boss = new Boss();
        for(int i = 0; i <10;  i ++)
        {
            boss.Magic();
        }
        boss.Magic();
      
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
