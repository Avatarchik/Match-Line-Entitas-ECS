//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity mapSizeEntity { get { return GetGroup(ConfigMatcher.MapSize).GetSingleEntity(); } }
    public MapSizeComponent mapSize { get { return mapSizeEntity.mapSize; } }
    public bool hasMapSize { get { return mapSizeEntity != null; } }

    public ConfigEntity SetMapSize(GridSize newValue) {
        if (hasMapSize) {
            throw new Entitas.EntitasException("Could not set MapSize!\n" + this + " already has an entity with MapSizeComponent!",
                "You should check if the context already has a mapSizeEntity before setting it or use context.ReplaceMapSize().");
        }
        var entity = CreateEntity();
        entity.AddMapSize(newValue);
        return entity;
    }

    public void ReplaceMapSize(GridSize newValue) {
        var entity = mapSizeEntity;
        if (entity == null) {
            entity = SetMapSize(newValue);
        } else {
            entity.ReplaceMapSize(newValue);
        }
    }

    public void RemoveMapSize() {
        mapSizeEntity.Destroy();
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

    public MapSizeComponent mapSize { get { return (MapSizeComponent)GetComponent(ConfigComponentsLookup.MapSize); } }
    public bool hasMapSize { get { return HasComponent(ConfigComponentsLookup.MapSize); } }

    public void AddMapSize(GridSize newValue) {
        var index = ConfigComponentsLookup.MapSize;
        var component = CreateComponent<MapSizeComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMapSize(GridSize newValue) {
        var index = ConfigComponentsLookup.MapSize;
        var component = CreateComponent<MapSizeComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMapSize() {
        RemoveComponent(ConfigComponentsLookup.MapSize);
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

    static Entitas.IMatcher<ConfigEntity> _matcherMapSize;

    public static Entitas.IMatcher<ConfigEntity> MapSize {
        get {
            if (_matcherMapSize == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.MapSize);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherMapSize = matcher;
            }

            return _matcherMapSize;
        }
    }
}
