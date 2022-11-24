using System.Collections.Generic;

namespace Tetris
{
    public abstract class Block
    {
        //Como base del experimento se debe crear una clase abstracta y luego crear una subclase.
        //Esto no permitará más adelante crear unas subclases reutilizando los mismos metodos de la clase abstracta (Para los 7 bloques diferentes). 
        //Una matriz de posici{on bidimensional que contiene las pocisiones de los bloques en los cuatro estados.
        //line1
        protected abstract Pos
public Block()
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }

        public IEnumerable<Position> TilePositions()
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public void RotateCC