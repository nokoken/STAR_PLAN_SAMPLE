using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float changerange = 1.0f;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private float enemy_speed = 10.0f;
    private Rigidbody2D en_rb;
    // Start is called before the first frame update
    void Start()
    {
        en_rb = enemy.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, enemy.transform.position) > changerange)
            Player_Tracking();
    }

    void Player_Tracking()
    {
        float vec_dici = player.transform.position.x > enemy.transform.position.x ? 1.0f : -1.0f;
        en_rb.velocity = new Vector2(enemy_speed * vec_dici, en_rb.velocity.y);
    }
}
