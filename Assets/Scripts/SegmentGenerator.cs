using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject segment;
    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;


    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }

    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 3);
        Instantiate(segment, new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 200;
        yield return new WaitForSeconds(10);
        creatingSegment = false;
    }

}
