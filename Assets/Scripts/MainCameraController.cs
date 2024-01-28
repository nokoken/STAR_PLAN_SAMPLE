using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    private Vector3 relative_pos;
    // Start is called before the first frame update
    void Start()
    {
        relative_pos = this.transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Player.transform.position + relative_pos;
    }
}
