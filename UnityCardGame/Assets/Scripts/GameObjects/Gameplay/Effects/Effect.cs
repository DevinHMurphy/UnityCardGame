using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : MonoBehaviour
{
    public enum Target{
        Self,
        Player,
        Minion,
        AllMinions,
        FriendlyMinion,
        AllFriendlyMinions,
        EnemyMinion,
        AllEnemyMinions,
        Hero,
        FriendlyHero,
        EnemyHero,
        FriendlyDeck,
        
    }

    [SerializeField] protected Target target;

    public abstract void effect();

}