using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
	public int cloneAmount;
	public Text txtUserCloneAmount;

    public void MultiInstantiate()
    {
        int counter = 0;
		cloneAmount = int.Parse(txtUserCloneAmount.text);
		if (txtUserCloneAmount.text != "")
		{
			cloneAmount = int.Parse(txtUserCloneAmount.text);
		}
		
        while (counter < cloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
