using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {
  public EffectiveItem head;
  public EffectiveItem neck;
  public EffectiveItem armor;
  public EffectiveItem gloves;
  public EffectiveItem shoes;
  public EffectiveItem rightHand;
  public EffectiveItem leftHand;
  public EffectiveItem rightRing;
  public EffectiveItem leftRing;
  public EffectiveItem pants;
  public Item underHand1;
  public Item underHand2;
  public Item underHand3;
  public Item underHand4;
  public EffectiveItem bag; //capacity mod jest efektem
  public List<Item> others; //bag&pockets
  public int gold;
}


