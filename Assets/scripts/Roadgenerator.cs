
using UnityEngine;

public class Roadgenerator : MonoBehaviour
{
    public int Startamount;
    public GameObject[] Roadprefabs;

    public Transform endPoint;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < Startamount; i++)
        {
            GameObject r = Instantiate(Roadprefabs[Random.Range(0, Roadprefabs.Length)],transform);

            if(endPoint == null)
            {
                r.transform.localPosition = Vector3.zero;
            }else
            {
                r.transform.position = endPoint.position;
            }
            endPoint = r.transform.GetChild(0);

        }


    }

    // Update is called once per frame

    public void addRoad()
    {
        Destroy(transform.GetChild(0).gameObject);

        GameObject r = Instantiate(Roadprefabs[Random.Range(0, Roadprefabs.Length)], transform);
        r.transform.position = endPoint.position;
        endPoint = r.transform.GetChild(0);

    }
}
