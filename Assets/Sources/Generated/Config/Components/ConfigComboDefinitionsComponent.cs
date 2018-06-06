//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity comboDefinitionsEntity { get { return GetGroup(ConfigMatcher.ComboDefinitions).GetSingleEntity(); } }
    public ComboDefinitionsComponent comboDefinitions { get { return comboDefinitionsEntity.comboDefinitions; } }
    public bool hasComboDefinitions { get { return comboDefinitionsEntity != null; } }

    public ConfigEntity SetComboDefinitions(ComboDefinitions newValue) {
        if (hasComboDefinitions) {
            throw new Entitas.EntitasException("Could not set ComboDefinitions!\n" + this + " already has an entity with ComboDefinitionsComponent!",
                "You should check if the context already has a comboDefinitionsEntity before setting it or use context.ReplaceComboDefinitions().");
        }
        var entity = CreateEntity();
        entity.AddComboDefinitions(newValue);
        return entity;
    }

    public void ReplaceComboDefinitions(ComboDefinitions newValue) {
        var entity = comboDefinitionsEntity;
        if (entity == null) {
            entity = SetComboDefinitions(newValue);
        } else {
            entity.ReplaceComboDefinitions(newValue);
        }
    }

    public void RemoveComboDefinitions() {
        comboDefinitionsEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigEntity {

    public ComboDefinitionsComponent comboDefinitions { get { return (ComboDefinitionsComponent)GetComponent(ConfigComponentsLookup.ComboDefinitions); } }
    public bool hasComboDefinitions { get { return HasComponent(ConfigComponentsLookup.ComboDefinitions); } }

    public void AddComboDefinitions(ComboDefinitions newValue) {
        var index = ConfigComponentsLookup.ComboDefinitions;
        var component = CreateComponent<ComboDefinitionsComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceComboDefinitions(ComboDefinitions newValue) {
        var index = ConfigComponentsLookup.ComboDefinitions;
        var component = CreateComponent<ComboDefinitionsComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveComboDefinitions() {
        RemoveComponent(ConfigComponentsLookup.ComboDefinitions);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ConfigMatcher {

    static Entitas.IMatcher<ConfigEntity> _matcherComboDefinitions;

    public static Entitas.IMatcher<ConfigEntity> ComboDefinitions {
        get {
            if (_matcherComboDefinitions == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.ComboDefinitions);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherComboDefinitions = matcher;
            }

            return _matcherComboDefinitions;
        }
    }
}