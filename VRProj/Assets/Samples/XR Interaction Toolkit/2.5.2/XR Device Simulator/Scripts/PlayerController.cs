using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;
    // Start is called before the first frame update
    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("Die terrorist");
            playerAnim.SetBool("Gun", true);
        }
        if (Input.GeyKeyDown(KeyCode.W))
            playerAnim.SetBool("Gun", false);
    }
}
