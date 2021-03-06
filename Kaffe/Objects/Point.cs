﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    class Point : MapObject
    {
        public Point(int x, int y) : base(x, y)
        {
            CanWalkOn = true;
            CanInteractWith = true;
            Icon = "+";
        }
        int posX;
        int posY;
        bool canWalkOn;
        bool canInteractWith;
        string icon;
        ConsoleColor color;
        public override int PosX { get => posX; set => posX = value; }
        public override int PosY { get => posY; set => posY = value; }
        public override bool CanWalkOn { get => canWalkOn; set => canWalkOn = value; }
        public override bool CanInteractWith { get => canInteractWith; set => canInteractWith = value; }
        public override string Icon { get => icon; set => icon = value; }
        public override ConsoleColor Color { get => color; set => color = value; }

        private int tailDuration;
        public override int TailDuration { get => tailDuration; set => tailDuration = value; }

        private bool isPlayerTail;
        public override bool IsPlayerTail { get => isPlayerTail; set => isPlayerTail = value; }

        private ObjectType objType = ObjectType.Point;
        public override ObjectType ObjType { get => objType;}

        public override void Interact()
        {
            Map.SpawnPoint();
            Map.Score++;
            Map.IncreaseTailTimer();
            Map.MapA[PosX, PosY] = new Empty(PosX,PosY);
        }
    }
}
