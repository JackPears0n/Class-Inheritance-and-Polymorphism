using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void AttackPlayer()
    {
        print("The Orc is attacking the player");
    }
}
