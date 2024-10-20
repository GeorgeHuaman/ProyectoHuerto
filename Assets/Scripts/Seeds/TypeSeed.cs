using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using SpatialSys.UnitySDK;
public class TypeSeed : MonoBehaviour
{
    public Seed typeSeed;
    public float timeNeedle;
    private float time;
    public int productsQuantity;

    //public NetworkVariable<string> syncedText = new();

    public TMP_Text textDisplay;
    private string timeLeftText;
    private bool isReady;
    private bool inZone;
    [HideInInspector]public Zone Zone;
    private bool isWater;
    // Start is called before the first frame update
    void Start()
    {
        //SelectTypeSeed();
        //syncedText.value = typeSeed.ToString();
        textDisplay.text = typeSeed.ToString();
    }
    public void Update()
    {
        GrowProcces();
        if (Input.GetKeyDown(KeyCode.E) && inZone)
        {
            if (isReady)
                Harvest();
            else
                isWater = true;
        }
    }

    private void GrowProcces()
    {
        if (isWater)
        {
            if (timeNeedle > time)
            {
                timeNeedle -= Time.deltaTime;
                int timeLeftInt = Mathf.FloorToInt(timeNeedle);
                timeLeftText = timeLeftInt.ToString();
                textDisplay.text = typeSeed.ToString() + timeLeftText;
            }
            else
            {
                textDisplay.text = typeSeed.ToString() + " Listo";
                isReady = true;
            }
        }
        else
        {
            textDisplay.text = typeSeed.ToString() + " Sin regar";
        }
        
    }
    public void Harvest()
    {
        Products harvestedProduct = (Products)typeSeed;

        // Si el producto ya existe en el inventario, incrementa su cantidad
        if (ProductsInventory.instance.inventarioProductos.ContainsKey(harvestedProduct))
        {
            ProductsInventory.instance.inventarioProductos[harvestedProduct]+= productsQuantity;
        }

        Debug.Log("Producto cosechado: " + harvestedProduct + ". Cantidad actual: " + ProductsInventory.instance.inventarioProductos[harvestedProduct]);
        PlantInteraction.instance.ClosePlantRecipesUI();
        timeNeedle = 10f;
        isReady= false;
        gameObject.SetActive(false);
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("AvatarLocal"))
        {
            inZone = true;
            PlantInteraction.instance.DisplayPlantRecipesUI((Products)typeSeed);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("AvatarLocal"))
        {
            inZone = false;
            PlantInteraction.instance.ClosePlantRecipesUI();
        }
    }
}
