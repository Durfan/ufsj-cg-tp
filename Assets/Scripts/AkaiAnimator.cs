using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkaiAnimator : MonoBehaviour {

    public float animSpeed = 1f;

    private Animator anim;
    private CapsuleCollider col;
    private float VelocityX;
    private float VelocityZ;

    static int jumpState = Animator.StringToHash("Base Layer.Jump");

    void Start() {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate() {
        VelocityX = Input.GetAxis("Horizontal");
        VelocityZ = Input.GetAxis("Vertical");

        anim.SetFloat("VelocityX", VelocityX);
        anim.SetFloat("VelocityZ", VelocityZ);
        anim.speed = animSpeed;

        if (Input.GetButtonDown("Jump")) {
            anim.SetBool("Jump", true);
        }
        else if (anim.GetCurrentAnimatorStateInfo(0).IsName("Jump")) {
            if (!anim.IsInTransition(0)) {
                anim.SetBool("Jump", false);
            }
        }

    }

}
