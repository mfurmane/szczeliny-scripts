using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : EntityVariable {
	
  public List<NameVariant> variants;
  
  public string getMostSpecificVariant() {
    if (variants[i].condition.isTrue()) {
      return variants[i];
    }
  }
  
  public string tryGetFirstname() {
    return "";
  }
  
  public string tryGetSurname() {
    return "";
  }
  
}

