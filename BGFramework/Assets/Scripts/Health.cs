using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Health : MonoBehaviour
{

    [HideInInspector]
    public bool takingDamage;
    [HideInInspector]
    public bool isDead;

    public delegate void UpdateHealth(int amount);
    public static event UpdateHealth UpdateHealthBar;

    //The maximum number of health points the player can have
    [SerializeField]
    private int maxHealthPoints;
    //The max amount of time after receiving damage that the player can no longer receive damage
    [SerializeField]
    private float invulnerabilityTime;
    //How long movement should be disabled after receiving damage
    [SerializeField]
    private float cancelMovementTime;

    //Bool that manages if the player can receive more damage
    [HideInInspector]
    public bool hit;

    //The current number of health points on the player after damage is applied
    private int currentHealthPoints;



    private void Start()
    {
        //This is for testing and certain games that refil health when starting a new scene; a lot of games currentHealth doesn't reset to maxHealth at the start of each scene, but for this tutorial it helps manage the values. I would use a PlayerPref int value to manage currentHealth between scenes
        currentHealthPoints = maxHealthPoints;
    }


    //This method is called by any script that would need to handle damage; for this tutorial it is called by the DamageField script
    public void Damage(int amount)
    {
        //First checks to see if the player is currently in an invulnerable state; if not it runs the following logic.
        if (!hit)
        {
            //First sets invulnerable to true
            hit = true;
            //Reduces currentHealthPoints by the amount value that was set by whatever script called this method, for this tutorial in the OnTriggerEnter2D() method
            currentHealthPoints -= amount;
        }
    }


    //Method that changes the hit value back to false to stop knockback forces from constantly being applied
    private void CancelHit()
    {
        hit = false;
    }

}