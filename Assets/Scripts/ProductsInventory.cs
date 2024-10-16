using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductsInventory : MonoBehaviour
{
    public static ProductsInventory instance;

    public Dictionary<Products, int> inventarioProductos;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    
}

public enum Products
{
    colMorada,
    colBlanca,
    lechugaRepollo,
    lechugaCrespa,
    remolacha,
    brocoli,
    coliflor,
    culantro,
    perejil,
    apio,
    calabaza,
    pimiento,
    zanahoria,
    acelga
}
