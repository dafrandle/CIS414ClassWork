// Dustin Frandle
// Addapted from code by www.youtube.com/@Brackeys

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : ApplicationElement
{
    [SerializeField] public float m_JumpForce = 400f;                          // Amount of force added when the player jumps.
    [Range(0, 1)][SerializeField] public float m_CrouchSpeed = .36f;           // Amount of maxSpeed applied to crouching movement. 1 = 100%
    [Range(0, .3f)][SerializeField] public float m_MovementSmoothing = .05f;   // How much to smooth out the movement
    [SerializeField] public bool m_AirControl = false;                         // Whether or not a player can steer while jumping;
    [SerializeField] public LayerMask m_WhatIsGround;                          // A mask determining what is ground to the character
    [SerializeField] public Transform m_GroundCheck;                           // A position marking where to check if the player is grounded.
    [SerializeField] public Transform m_CeilingCheck;                          // A position marking where to check for ceilings
    [SerializeField] public Collider2D m_CrouchDisableCollider;				// A collider that will be disabled when crouching

    public bool m_Grounded;            // Whether or not the player is grounded.
    public Rigidbody2D m_Rigidbody2D;
    public bool m_FacingRight = true;  // For determining which way the player is currently facing.
    public Vector3 velocity = Vector3.zero;

    public float runSpeed = 40f;
    public float horizontalMove = 0f;
    public bool jump = false;
    public bool crouch = false;


    private const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
    public float K_GroundedRadius { get { return k_GroundedRadius; } }

    public const float k_CeilingRadius = .2f; // Radius of the overlap circle to determine if the player can stand up
    public float K_CeilingRadius { get { return k_CeilingRadius; } }

}
