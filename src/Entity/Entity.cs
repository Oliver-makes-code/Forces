namespace Forces.Entity;

using Forces;
using Godot;
using System;

abstract class Entity : KinematicBody2D {
    public abstract void init();
    public abstract void tick(float delta);
    public abstract void input(InputEvent @event);

    public override void _Ready() {
        init();
    }
    public override void _PhysicsProcess(float delta) {
        tick(delta);
    }
    public override void _Input(InputEvent @event) {
        input(@event);
    }
}