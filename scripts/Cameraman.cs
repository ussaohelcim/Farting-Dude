using Godot;
using System;

public class Cameraman : Camera2D
{
    public RigidBody2D rbjogador;
    public override void _Ready()
    {
        rbjogador = GetParent().GetChild<RigidBody2D>(0);
        //rbjogador = GetParent().GetChild<RigidBody2D>(1);
        GD.Print(GetParent().GetChildren()[0]);
    }
    public override void _Process(float delta)
    {
        // SetPosition(new Vector2(rbjogador.Transform.x,0))
        Position = new Vector2(rbjogador.Position.x+10,0);
        //Position.x = rbjogador.Transform.x,0); 
    }

}
