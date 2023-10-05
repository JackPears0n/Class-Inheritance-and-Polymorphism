using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public virtual void AttackPlayer()
    {
        print("Enemy is attacking the player");
    }
}
