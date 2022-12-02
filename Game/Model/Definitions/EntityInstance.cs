using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityInstance : InspectorEntity {
  public EntityInfo info;
  public override Dictionary<string, EntityVariable> getVisualisationData() {
    Dictionary<string, string> dictionary = new Dictionary<string, EntityVariable>();
    dictionary.Add("portrait", info.portrait);
    dictionary.Add("name", info.name);
    dictionary.Add("description", info.description);
    return dictionary;
  }
}

