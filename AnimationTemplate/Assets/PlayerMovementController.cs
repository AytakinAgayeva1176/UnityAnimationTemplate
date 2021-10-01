using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private float playerSpeed;


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerAnimator.SetFloat("MoveHorizontal", horizontalInput);
        playerAnimator.SetFloat("MoveVertical", verticalInput);

        transform.position += (transform.forward * verticalInput + transform.right * horizontalInput) * Time.deltaTime * playerSpeed;
    }

}
