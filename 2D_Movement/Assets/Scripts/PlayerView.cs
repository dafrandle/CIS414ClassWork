// Dustin Frandle
// Addapted from code by www.youtube.com/@Brackeys

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : ApplicationElement
{
    private void FixedUpdate()
    {
        application.view.playerModel.m_Grounded = false;

        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        // This can be done using layers instead but Sample Assets will not overwrite your project settings.
        Collider2D[] colliders = Physics2D.OverlapCircleAll(application.view.playerModel.m_GroundCheck.position, application.view.playerModel.K_GroundedRadius, application.view.playerModel.m_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
                application.view.playerModel.m_Grounded = true;
        }
    }

    public void Move(float move, bool crouch, bool jump)
    {
        // If crouching, check to see if the character can stand up
        if (!crouch)
        {
            // If the character has a ceiling preventing them from standing up, keep them crouching
            if (Physics2D.OverlapCircle(application.view.playerModel.m_CeilingCheck.position, application.view.playerModel.K_CeilingRadius, application.view.playerModel.m_WhatIsGround))
            {
                crouch = true;
            }
        }

        //only control the player if grounded or airControl is turned on
        if (application.view.playerModel.m_Grounded || application.view.playerModel.m_AirControl)
        {

            // If crouching
            if (crouch)
            {
                // Reduce the speed by the crouchSpeed multiplier
                move *= application.view.playerModel.m_CrouchSpeed;

                // Disable one of the colliders when crouching
                if (application.view.playerModel.m_CrouchDisableCollider != null)
                    application.view.playerModel.m_CrouchDisableCollider.enabled = false;
            }
            else
            {
                // Enable the collider when not crouching
                if (application.view.playerModel.m_CrouchDisableCollider != null)
                    application.view.playerModel.m_CrouchDisableCollider.enabled = true;
            }

            // Move the character by finding the target velocity
            Vector3 targetVelocity = new Vector2(move * 10f, application.view.playerModel.m_Rigidbody2D.velocity.y);
            // And then smoothing it out and applying it to the character
            application.view.playerModel.m_Rigidbody2D.velocity = Vector3.SmoothDamp(application.view.playerModel.m_Rigidbody2D.velocity, targetVelocity, ref application.view.playerModel.velocity, application.view.playerModel.m_MovementSmoothing);

            // If the input is moving the player right and the player is facing left...
            if (move > 0 && !application.view.playerModel.m_FacingRight)
            {
                // ... flip the player.
                Flip();
            }
            // Otherwise if the input is moving the player left and the player is facing right...
            else if (move < 0 && application.view.playerModel.m_FacingRight)
            {
                // ... flip the player.
                Flip();
            }
        }
        // If the player should jump...
        if (application.view.playerModel.m_Grounded && jump)
        {
            // Add a vertical force to the player.
            application.view.playerModel.m_Grounded = false;
            application.view.playerModel.m_Rigidbody2D.AddForce(new Vector2(0f, application.view.playerModel.m_JumpForce));
        }
    }


    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        application.view.playerModel.m_FacingRight = !application.view.playerModel.m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
