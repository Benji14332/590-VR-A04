using UnityEngine;

public class ballshooter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform lhray;
    public Transform rhray;

    public balllhandler bh;

    //public LineRenderer lhline;
    //public LineRenderer rhline;

    //void drawray(Transform r, LineRenderer line)
    //{//2 dots for the line
    //    line.SetPosition(0, r.position);
    //    line.SetPosition(1, r.position + r.forward * 5f);
    //}
    void Shoot(Transform r) {

        RaycastHit hit;

        
        //max 100f, so it should be ok
        //raycast funct from physics

        if (Physics.Raycast(r.position, r.forward, out hit, 100f)) {
            if (hit.collider.gameObject == bh.currentball) {
               bh.shoot();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger)) { //OVR: meta input
            Shoot(lhray);
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Shoot(rhray);
        }

        //drawray(lhray, lhline);
        //drawray(rhray, rhline);


    }
}
