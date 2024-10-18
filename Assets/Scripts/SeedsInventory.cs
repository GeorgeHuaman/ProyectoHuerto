using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedsInventory : MonoBehaviour
{
    public static SeedsInventory instance;
    public Dictionary<Seed, int> inventorySeeds;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        inventorySeeds = new Dictionary<Seed, int>()
        {
            { Seed.colMorada, 1 },
            { Seed.colBlanca, 1 },
            { Seed.lechugaRepollo, 1 },
            { Seed.lechugaCrespa, 1 },
            { Seed.remolacha, 1 },
            { Seed.brocoli, 1 },
            { Seed.coliflor, 1 },
            { Seed.culantro, 1 },
            { Seed.perejil, 1 },
            { Seed.apio, 1 },
            { Seed.calabaza, 1 },
            { Seed.pimiento, 1 },
            { Seed.zanahoria, 1 },
            { Seed.acelga, 1 }
        };
    }
    public bool HaveSeeds(Seed seedSelected)
    {
        if (inventorySeeds.ContainsKey(seedSelected))
        {
            return inventorySeeds[seedSelected] > 0;
        }
        else
        {
            return false;
        }
    }
    public void ReduceSeeds(Seed seedSelected)
    {
        if (inventorySeeds.ContainsKey(seedSelected) && inventorySeeds[seedSelected] > 0)
        {
            inventorySeeds[seedSelected] --;
        }
    }
}
public enum Seed
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


