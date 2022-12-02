using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
  public UnitInfo info;

  public Statistic charisma;
  public Statistic spirit;
  public Statistic precision;
  public Statistic concentration;
  public Statistic body;
  public Statistic mind;
  public Statistic hp;
  public Statistic harmReduction;
  public Statistic magicResistance;
  public Statistic capacity;
  public int morale;
  public int stress;
  public int exhaustion;
  public int exp;
  public int gainedExp;

  public List<EntityInfo> knowledge;
  public List<Domain> domains;
  public List<Profession> professions;
  public List<TrainingInstance> trainings;
  public Characteristic characteristic;
  public Inventory inventory;

//  public int initialGold; //czy nie lepiej po prostu ustawiać to w inventory?

}

