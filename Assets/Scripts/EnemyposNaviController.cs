using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyposNaviController : MonoBehaviour
{
    [SerializeField]
    private Slider enemypos_navi;
    [SerializeField]
    private GameObject goal;
    [SerializeField]
    private GameObject start;
    [SerializeField]
    private GameObject enemy;
    private float mapdis;
    // Start is called before the first frame update
    void Start()
    {
        mapdis = goal.transform.position.x - start.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        enemypos_navi.value = (enemy.transform.position.x - start.transform.position.x) / mapdis;
    }
}
