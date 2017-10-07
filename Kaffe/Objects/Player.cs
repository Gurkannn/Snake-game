﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    class Player : MapObject
    {
        public Player(int x, int y) : base(x, y)
        {
            CanWalkOn = false;
            CanInteractWith = false;
            Icon = "O";
            TailIcon = "o";
            CurrentDirection = Direction.West;
            bodyStartLenght = 3;
            bodyLenght = 3;
        }
        int posX;
        int posY;
        int bodyLenght;
        int bodyStartLenght;
        bool canWalkOn;
        bool canInteractWith;
        string icon;
        string tailIcon;
        ConsoleColor color;

        Direction currentDirection;
        public Direction CurrentDirection { get => currentDirection; set => currentDirection = value; }

        public override int PosX { get => posX; set => posX = value; }
        public override int PosY { get => posY; set => posY = value; }

        public override bool CanWalkOn { get => canWalkOn; set => canWalkOn = value; }
        public override bool CanInteractWith { get => canInteractWith; set => canInteractWith = value; }

        public string TailIcon { get => tailIcon; set => tailIcon = value; }
        public override string Icon { get => icon; set => icon = value; }
        public override ConsoleColor Color { get => color; set => color = value; }
        public int BodyLenght { get => bodyLenght; set => bodyLenght = value; }

        public void ResetBodyLenght()
        {
            bodyLenght = bodyStartLenght;
        }

        public void IncreaseBodyLenght()
        {
            BodyLenght++;            
        }

        private int tailDuration;
        public override int TailDuration { get => tailDuration; set => tailDuration = value; }


        private bool isPlayerTail;
        public override bool IsPlayerTail { get => isPlayerTail; set => isPlayerTail = value; }

        public void MovePlayer()
        {
            switch (CurrentDirection)
            {
                case Direction.North:
                    PosY--;
                    break;
                case Direction.South:
                    PosY++;
                    break;
                case Direction.West:
                    PosX--;
                    break;
                case Direction.East:
                    PosX++;
                    break;
                default:
                    break;
            }
        }

        public override void Interact()
        {
            throw new NotImplementedException();
        }
    }

    public enum Direction
    {
        North, South, West, East
    }
}
