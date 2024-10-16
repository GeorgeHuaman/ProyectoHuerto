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
            { Seed.colMorada, 10 },
            { Seed.colBlanca, 5 },
            { Seed.lechugaRepollo, 0 },
            { Seed.lechugaCrespa, 8 },
            { Seed.remolacha, 12 },
            { Seed.brocoli, 3 },
            { Seed.coliflor, 7 },
            { Seed.culantro, 4 },
            { Seed.perejil, 6 },
            { Seed.apio, 9 },
            { Seed.calabaza, 2 },
            { Seed.pimiento, 11 },
            { Seed.zanahoria, 0 },
            { Seed.acelga, 5 }
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


