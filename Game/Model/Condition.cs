using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour {
  
  public enum Mod {
    SIMPLE,
	AND,
    OR
  }
  
  /*public enum ConditionType {
	GLOBAL,
	LOCATION,
	AREA,
	TEAM,
	UNIT,
	ITEM
  }*/

  public enum Type {
    VAR_EXISTS,
    VAR_VALUE,
    HAVE_ITEMS,
    VAR_NOT_SET,
    VAR_NOT_VALUE,
    NO_ITEM,
    NOT_ENOUGH_ITEM,
    GOLD,
    NOT_GOLD,
    HERO_STAT_BIGGER,
    HERO_STAT_LOWER,
    TEAM_STAT_BIGGER, // (ktokolwiek)
    TEAM_STAT_LOWER, // (wszyscy)
    HAS_COMPANION,
    IS_SEX,
    IS_RACE,
    IS_CLASS, // (obecna i historyczne)
    IS_UNDEAD,
    UNITS_ALIVE,
    UNITS_IN_PLACE, //  - różne opcje dialogowe rozmowy z towarzyszem w zależności od lokalizacji, ale przy questach działanie przez trigger enter i sprawdzenie, czy mamy wymaganych towarzyszy
    UNITS_DEAD
  }
  
  public List<Condition> subConditions = new List<Condition>();
  public Mod operation = Mod.SIMPLE;
  //public ConditionType type;

  public Type conditionType;
  public List<InspectorEntity> conditionArgs = new List<InspectorEntity>();

  public isTrueGlobal() {
	  
  }
  
  public isTrueLocation(LocationInstance location) {
	  
  }
  
  public isTrueArea() {
	  //can be hard
  }
  
  public isTrueTeam(Team team) {
	  // Team.ALLY, Team.ENEMY, Team.NEUTRAL
  }
  
  public isTrueUnit(Unit unit) {

  }
  
  public isTrueItem(ItemInstance item) {
	  // Team.ALLY, Team.ENEMY, Team.NEUTRAL
  }
  

  
  public bool isTrue() {
    return true;
  }
}

