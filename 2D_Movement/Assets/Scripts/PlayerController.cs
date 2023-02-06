// Dustin Frandle
// Addapted from code by www.youtube.com/@Brackeys

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : ApplicationElement
{
    void Update()
    {
        application.view.playerModel.horizontalMove = Input.GetAxisRaw("Horizontal") * application.view.playerModel.runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            application.view.playerModel.jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            application.view.playerModel.crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            application.view.playerModel.crouch = false;
        }

    }

    void FixedUpdate()
    {
        // Move our character
        application.view.playerView.Move(application.view.playerModel.horizontalMove * Time.fixedDeltaTime, application.view.playerModel.crouch, application.view.playerModel.jump);
        application.view.playerModel.jump = false;
    }
    
}
