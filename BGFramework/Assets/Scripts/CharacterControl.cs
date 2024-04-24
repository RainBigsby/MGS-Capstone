using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    [SerializeField] private Character character;
    private void Update()
    {
        #region WALKING
        //handle player right input
        if (Input.GetAxisRaw("Horizontal") == 1f)
        {
            character.moveCharacterRight();
        }

        //handle player left input
        if (Input.GetAxisRaw("Horizontal") == -1f)
        {
            character.moveCharacterLeft();
        }

        //handle player up input
        if (Input.GetAxisRaw("Vertical") == 1f)
        {
            character.moveCharacterUp();
        }

        //handle player down input
        if (Input.GetAxisRaw("Vertical") == -1f)
        {
            character.moveCharacterDown();
        }

        //reseting character speed when no input is decteced
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            character.resetSpeedHorizontal();
        }

        if (Input.GetAxisRaw("Vertical") == 0)
        {
            character.resetSpeedVertical();
        }
        #endregion

        #region JUMPING
        character.checkGrounded();
        if (Input.GetButtonDown("Jump"))
        {
            character.characterJump();
        }

        if (Input.GetAxisRaw("Jump") == 0)
        {
            character.resetJump();
        }
        #endregion
    }
}