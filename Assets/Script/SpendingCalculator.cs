using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpendingCalculator : MonoBehaviour
{
    public TMP_InputField homeInput;
    public TMP_InputField houseGardenInput;
    public TMP_InputField foodDrinksInput;
    public TMP_InputField transportInput;
    public TMP_InputField shoppingInput;
    public TMP_InputField skincareInput;

    // TextMeshPro Text for displaying the total spending
    public TMP_Text monthTotalText;

    // Method to update the total spending
    public void UpdateTotal()
    {
        // Parse each input field value, default to 0 if empty
        float home = float.TryParse(homeInput.text, out float h) ? h : 0;
        float houseGarden = float.TryParse(houseGardenInput.text, out float hg) ? hg : 0;
        float foodDrinks = float.TryParse(foodDrinksInput.text, out float fd) ? fd : 0;
        float transport = float.TryParse(transportInput.text, out float t) ? t : 0;
        float shopping = float.TryParse(shoppingInput.text, out float s) ? s : 0;
        float skincare = float.TryParse(skincareInput.text, out float sk) ? sk : 0;

        // Calculate the total
        float total = home + houseGarden + foodDrinks + transport + shopping + skincare;

        // Update the total spending display
        monthTotalText.text = total.ToString("F2");
    }
}
