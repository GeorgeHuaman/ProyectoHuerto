using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeSeed : SpatialNetworkBehaviour
{
    public Seed typeSeed;
    public float timeNeedle;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        SelectTypeSeed(Seed.acelga);
    }

    public void Update()
    {
        if (time < timeNeedle)
        {
            time += Time.deltaTime;
        }
        else
        {
            Debug.Log("Listo");
        }
        
    }
    public void SelectTypeSeed(Seed selectedSeed)
    {
        typeSeed = selectedSeed;
    }
}
//public enum Seed
//{
//    colMorada,
//    colBlanca,
//    lechugaRepollo,
//    lechugaCrespa,
//    remolacha,
//    brocoli,
//    coliflor,
//    culantro,
//    perejil,
//    apio,
//    calabaza,
//    pimiento,
//    zanahoria,
//    acelga
//}
