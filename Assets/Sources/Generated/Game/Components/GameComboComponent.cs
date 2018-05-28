//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ComboComponent combo { get { return (ComboComponent)GetComponent(GameComponentsLookup.Combo); } }
    public bool hasCombo { get { return HasComponent(GameComponentsLookup.Combo); } }

    public void AddCombo(ComboType newValue) {
        var index = GameComponentsLookup.Combo;
        var component = CreateComponent<ComboComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCombo(ComboType newValue) {
        var index = GameComponentsLookup.Combo;
        var component = CreateComponent<ComboComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCombo() {
        RemoveComponent(GameComponentsLookup.Combo);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCombo;

    public static Entitas.IMatcher<GameEntity> Combo {
        get {
            if (_matcherCombo == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Combo);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCombo = matcher;
            }

            return _matcherCombo;
        }
    }
}
