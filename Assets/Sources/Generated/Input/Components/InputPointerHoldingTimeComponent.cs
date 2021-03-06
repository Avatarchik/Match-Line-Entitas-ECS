//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity pointerHoldingTimeEntity { get { return GetGroup(InputMatcher.PointerHoldingTime).GetSingleEntity(); } }
    public PointerHoldingTimeComponent pointerHoldingTime { get { return pointerHoldingTimeEntity.pointerHoldingTime; } }
    public bool hasPointerHoldingTime { get { return pointerHoldingTimeEntity != null; } }

    public InputEntity SetPointerHoldingTime(float newValue) {
        if (hasPointerHoldingTime) {
            throw new Entitas.EntitasException("Could not set PointerHoldingTime!\n" + this + " already has an entity with PointerHoldingTimeComponent!",
                "You should check if the context already has a pointerHoldingTimeEntity before setting it or use context.ReplacePointerHoldingTime().");
        }
        var entity = CreateEntity();
        entity.AddPointerHoldingTime(newValue);
        return entity;
    }

    public void ReplacePointerHoldingTime(float newValue) {
        var entity = pointerHoldingTimeEntity;
        if (entity == null) {
            entity = SetPointerHoldingTime(newValue);
        } else {
            entity.ReplacePointerHoldingTime(newValue);
        }
    }

    public void RemovePointerHoldingTime() {
        pointerHoldingTimeEntity.Destroy();
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
public partial class InputEntity {

    public PointerHoldingTimeComponent pointerHoldingTime { get { return (PointerHoldingTimeComponent)GetComponent(InputComponentsLookup.PointerHoldingTime); } }
    public bool hasPointerHoldingTime { get { return HasComponent(InputComponentsLookup.PointerHoldingTime); } }

    public void AddPointerHoldingTime(float newValue) {
        var index = InputComponentsLookup.PointerHoldingTime;
        var component = CreateComponent<PointerHoldingTimeComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePointerHoldingTime(float newValue) {
        var index = InputComponentsLookup.PointerHoldingTime;
        var component = CreateComponent<PointerHoldingTimeComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePointerHoldingTime() {
        RemoveComponent(InputComponentsLookup.PointerHoldingTime);
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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherPointerHoldingTime;

    public static Entitas.IMatcher<InputEntity> PointerHoldingTime {
        get {
            if (_matcherPointerHoldingTime == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.PointerHoldingTime);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherPointerHoldingTime = matcher;
            }

            return _matcherPointerHoldingTime;
        }
    }
}
