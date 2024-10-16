using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public SelectSeed selectSeed;
    public SeedsInventory seedsInventory;
    public SpatialNetworkObject seedPrefab;
    public bool inZone;
    public SpatialNetworkObject seedPlant;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inZone && !seedPlant)
        {
            Plant();
        }
    }
    public void Plant()
    {

        bool tieneSemillas = seedsInventory.HaveSeeds(selectSeed.actualSeed);
        if (tieneSemillas)
        {
            Debug.Log("Hay semillas disponibles para: " + selectSeed.actualSeed);
            SpatialBridge.spaceContentService.SpawnNetworkObject(seedPrefab, transform.position, Quaternion.identity);
            //seedPlant.GetComponent<TypeSeed>().SelectTypeSeed(selectSeed.actualSeed);
        }
        else
        {
            Debug.Log("No hay semillas disponibles para: " + selectSeed.actualSeed);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("AvatarLocal")) 
        {
            inZone = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("AvatarLocal"))
        {
            inZone = false;
        }
    }
}