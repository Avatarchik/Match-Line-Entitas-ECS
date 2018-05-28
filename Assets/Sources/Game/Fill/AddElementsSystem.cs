﻿using System.Collections.Generic;
using Entitas;
using UnityEngine;

public sealed class AddElementsSystem : ReactiveSystem<GameEntity>
{
    private readonly Contexts _contexts;
    private readonly ElementService _elementService;

    public AddElementsSystem(Contexts contexts, Services services) : base(contexts.game)
    {
        _contexts = contexts;
        _elementService = services.ElementService;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Element.Removed(), GameMatcher.Position.AddedOrRemoved());
    }

    protected override bool Filter(GameEntity entity)
    {
        return true;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        var size = _contexts.config.mapSize.value;
        for (int x = 0; x < size.x; x++)
        {
            var position = new GridPosition(x, size.y - 1);
            var candidates = _contexts.game.GetEntitiesWithPosition(position);

            if (candidates.Count == 0)
            {
                _elementService.CreateRandomElement(position);
            }
        }
    }
}