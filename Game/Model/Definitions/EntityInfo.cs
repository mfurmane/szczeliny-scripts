using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityInfo : InspectorEntity {	//dla osób, domen, profesji, … nie ma sensu getInstance
  
  public Portrait portrait;
  public Name name;
  public Description description;
  
  public EntityInstance getInstance() {
	
  }
  
  public override Dictionary<string, EntityVariable> getVisualisationData() {
    Dictionary<string, string> dictionary = new Dictionary<string, EntityVariable>();
	dictionary.Add("portrait", portrait);
	dictionary.Add("name", name);
	dictionary.Add("description", description);
	return dictionary;
  }
  
}


