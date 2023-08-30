using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    The combat object contains the values of each "in-game" 
    object that is able to undergo combat. The combat manager 
    uses multiple combatObjects to create a combat flow.
*/
public class CombatObject : MonoBehaviour
{

    private int maxHealth = 0;
    private int baseHealth = 0;
    private int health = 0;

    private int baseAttack = 0;
    private int attack = 0;

    // -- out of scope but keep for constructor consistency 
    private int baseArmor = 0;
    private int armor = 0;
    
    //empty constructor
    public CombatObject(){
    }



    //create a combat object
    public CombatObject(int MaxHealth, int BaseHealth, int Health, int Armor, int BaseArmor, int Attack, int BaseAttack){
        this.maxHealth = MaxHealth;
        this.baseHealth = BaseHealth;
        this.health = Health;
        this.armor = Armor;
        this.baseArmor = BaseArmor;
        this.attack = Attack;
        this.baseAttack = BaseAttack; 
    }

    //set all stats of the combat object
    public void SetStats(int MaxHealth, int BaseHealth, int Health, int Armor, int BaseArmor, int Attack, int BaseAttack){
        this.maxHealth = MaxHealth;
        this.baseHealth = BaseHealth;
        this.health = Health;
        this.armor = Armor;
        this.baseArmor = BaseArmor;
        this.attack = Attack;
        this.baseAttack = BaseAttack; 
    }

    //getters and setters
      public void SetCurrentAttack(int value){
        attack = value;
    }
    //maxHealth
    public int getMaxHealth(){
        return this.maxHealth;
    }
    public void setMaxHealth(int value){
        this.maxHealth = value;
    }
    public void ChangeMaxHealth(int amount){
        //increase the combat object's Max health
        if(amount > 0){
            this.maxHealth = this.maxHealth + amount;
        }
        //reduce the combat Object's Max health, ensuring the minimum is 1
        else if(amount < 0){
            if(this.maxHealth - amount > 0){
                this.maxHealth = this.maxHealth - amount;
            } else {
                this.maxHealth = 1;
            }
        }
        else return;
    }
    
    //Base health
    public void setBaseHealth(int value){
        this.baseHealth = value;
    }
    public int getBaseHealth(){
        return this.baseHealth;
    }

    //CurrentHealth
    public void setHealth(int value){
        this.health = value;
    }
    public int getHealth(){
        return this.health;
    }
    public void changeHealth(int amount){
        if(amount > 0){
            Heal(amount);
        }
        else if(amount < 0){
            Damage(amount);
        }
        else return;
    }

    //Base attack
    public void setBaseAttack(int value){
        this.baseAttack = value;
    }
    public int getBaseAttack(){
        return this.baseAttack;
    }

    //CurrentAttack (attack)
    public int getAttack(){
        return this.attack;
    }
    public void setAttack(int value){
        this.attack = value;
    }
    public void changeAttack(int amount){
        if(attack + amount <= 0){
            //no negative attack
            attack = 0;
        } else {
            attack = attack + amount;
        }
    }

    //baseArmor ALWAYS ZERO (in this scope)  -- no getters/setters

    //armor
    public void setArmor(int value){
        this.armor = value;
    }
    public int getArmor(){
        return this.armor;
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
    public bool isDead(){
        if (this.health > 0) {
            return false ;
        } else {
            //do The logic to destroy the combat object in the game --> move creature to graveyard or broadcast death message
            return true;
        }
    }
}