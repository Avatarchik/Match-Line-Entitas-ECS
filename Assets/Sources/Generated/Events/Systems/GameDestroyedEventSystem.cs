//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameDestroyedEventSystem : Entitas.ReactiveSystem<GameEntity> {

    public GameDestroyedEventSystem(Contexts contexts) : base(contexts.game) {
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.Destroyed)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.isDestroyed && entity.hasGameDestroyedListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            
            foreach (var listener in e.gameDestroyedListener.value) {
                listener.OnDestroyed(e);
            }
        }
    }
}
