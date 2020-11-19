using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Parallelwelt : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cube;
    public GameObject CubeZiel;

    public float TimerParalell = 3;

    public bool count = false;
    public bool Puzzleclear = false;

    private Vector3 OldPos;
    private Vector3 CubePos;
    private Vector3 CubeZielPos;

    private void Start()
    {
        Debug.Log(Player.transform.position);
        CubeZielPos = CubeZiel.transform.position;
    }

    private void timerstarten()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            count = true;
            OldPos = Player.transform.position;
            CubePos = Cube.transform.position;
        }

    }

    private void Update()
    {
        if (count)
        {
            TimerParalell -= Time.deltaTime;
            if (TimerParalell <= 0)
            {
                Player.transform.position = OldPos;
                Debug.Log(OldPos);
                TimerParalell = 3;
                count = false;
            }
        }
        timerstarten();
    }

    void puzzleclear()
    {
        if (CubePos == CubeZielPos)
        {
            Puzzleclear = true;
            CubePos = CubeZielPos;
        }
    }
}
