using SadConsole;
using SadRogue.Primitives;

namespace SpaceShooter;

public class Enemy : ScreenSurface, IMoveable
{
    private int _ticks, _speed;
    public Enemy(int speed) : base(1, 1)
    {
        Surface[0, 0].Glyph = 'V';
        _speed = speed;
    }

    public void Move()
    {
        _ticks++;
        if (_ticks % _speed == 0)
            Position += new Point(0, 1);
    }
}