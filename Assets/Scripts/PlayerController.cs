using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public Vector2 translate_pl;
    [SerializeField]
    private LayerMask grandlayer;
    [SerializeField]
    private float jumppower = 800.0f;
    private Rigidbody2D player_rb;
    private float walkpower;
    void Start()
    {
        player_rb = this.GetComponent<Rigidbody2D>();
        player_rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        WalkPlayer();
        JumpPlater();
    }
    void WalkPlayer()
    {
        float beside_walk = Input.GetAxis("Horizontal");
        walkpower = beside_walk * Time.deltaTime * 5.0f;
        translate_pl = new Vector2(walkpower, 0.0f);
        this.transform.Translate(translate_pl);
    }
    void JumpPlater()
    {
        if (Input.GetKey("space") && Physics2D.Raycast(this.transform.position, Vector2.down, 1.0f, grandlayer))
            player_rb.AddForce(transform.up * Time.deltaTime * jumppower);
    }
}
