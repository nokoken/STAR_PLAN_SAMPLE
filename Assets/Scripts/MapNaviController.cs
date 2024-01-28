using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapNaviController : MonoBehaviour
{
    [SerializeField]
    private Slider MapNavi;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject goal;
    [SerializeField]
    private GameObject start;
    private float mapdis;
    // Start is called before the first frame update
    void Start()
    {
        mapdis = goal.transform.position.x - start.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        MapNavi.value = (player.transform.position.x - start.transform.position.x) / mapdis;
    }
}
