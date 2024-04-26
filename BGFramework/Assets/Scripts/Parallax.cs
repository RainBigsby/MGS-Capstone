using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [Header("Inscribed")]
    public Transform playerTrans;
    public Transform[] panels;
    public float scrollSpeed = -30f;
    public float motionMult = .25f;

    private float panelHt;
    private float depth;

    // Start is called before the first frame update
    void Start()
    {
        panelHt = panels[0].localScale.y;
        depth = panels[0].position.z;

        panels[0].position = new Vector3(0, 0, depth);
        panels[1].position = new Vector3(0,panelHt,depth);
    }

    // Update is called once per frame
    void Update()
    {
        float tY, tX = 0;
        tY = Time.time * scrollSpeed % panelHt + (panelHt * .5f);

        if (playerTrans != null) 
        {
            tX = -playerTrans.transform.position.x * motionMult;
        }

        panels[0].position = new Vector3(tX, tY, depth);

        if (tY >= 0)
        {
            panels[1].position = new Vector3(tX, tY - panelHt, depth);
        }
        else 
        {
            panels[1].position = new Vector3(tX, tY + panelHt, depth);
        }
    }
}
