using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CombatObject : MonoBehaviour
{
    public int maxHealth = 0;
    public int baseHealth = 0;
    public int health = 0;

    public int baseArmor = 0;
    public int armor = 0;

    public int baseAttack = 0;
    public int attack = 0;


    public CombatObject(){

    }

    public CombatObject(int MaxHealth, int BaseHealth, int Health, int Armor, int BaseArmor, int Attack, int BaseAttack){
        this.maxHealth = MaxHealth;
        this.baseHealth = BaseHealth;
        this.health = Health;
        this.armor = Armor;
        this.baseArmor = BaseArmor;
        this.attack = Attack;
        this.baseAttack = BaseAttack; 
    }

    public void SetStats(int MaxHealth, int BaseHealth, int Health, int Armor, int BaseArmor, int Attack, int BaseAttack){
        this.maxHealth = MaxHealth;
        this.baseHealth = BaseHealth;
        this.health = Health;
        this.armor = Armor;
        this.baseArmor = BaseArmor;
        this.attack = Attack;
        this.baseAttack = BaseAttack; 
    }

      public void SetCurrentAttack(int value){
        attack = value;
    }

    public void ChangeCurrentAttack(int amount){
        if(attack + amount <= 0){
            //no negative attack
            attack = 0;
        } else {
            attack = attack + amount;
        }
    }

    public void SetDefaultHealth(int value){
        baseHealth = value;
    }
    public void ChangeCurrentHealth(int amount){
        if(amount > 0){
            Heal(amount);
        }
        else if(amount < 0){
            Damage(amount);
        }
        else return;
    }

    public void Damage(int amount){
        health = health - amount;
    }
    public void Heal(int amount){
        if(baseHealth - health < amount) {
            health = baseHealth;
        }
        else {
            health = health + amount;
        }
    }
       //combatEntity target
}