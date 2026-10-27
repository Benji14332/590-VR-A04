using UnityEngine;

public class balllhandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject targetball;
    public GameObject currentball;

    public float minx = -3f;
    public float maxx = 3f;

    public float miny = 1f;
    public float maxy = 3f;

    public float minz = 3f;
    public float maxz = 6f;

    public void Start()
    {
        Newball();
    }

    public void Newball() {
        float x = Random.Range(minx, maxx);
        float y = Random.Range(miny, maxy);
        float z = Random.Range(minz, maxz);

        //float[] position= [x, y, z];
        Vector3 position = new Vector3(x, y, z);

        currentball = Instantiate(targetball, position, Quaternion.identity); //obj,pos,rot

    }

    public void shoot() {
        Destroy(currentball);
        Newball();
   }
}
