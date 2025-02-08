using SadConsole;
using SadRogue.Primitives;

namespace SpaceShooter;

public class Bullet : ScreenSurface, IMoveable
{
    public Bullet() : base(1, 1)
    {
        Surface[0, 0].Glyph = '|'; // Символ пули
        Surface[0, 0].Foreground = Color.Yellow;
    }

    public void Move()
    {
        Position += new Point(0, -1);
    }
}
public class Supply : ScreenSurface, IMoveable
{
    private Random _random;
    private int _middleX;
    private int _direction;
    private int _ticks;
    private int _lifetime = 50;
    public Supply(int direction) : base(1, 1)
    {
        _random = new Random();
        _middleX = _random.Next(15, 25);
        _direction = direction;
        Surface[0, 0].Glyph = '#';
        Surface[0, 0].Foreground = Color.Purple;
    }
    public void Move()
    {
        _ticks++;
        if (_ticks % 5 != 0)
            return;
        if (Position.X == _middleX)
        {
            _lifetime--;
            return;
        }
        Position += new Point(_direction, 0);
    }

    public bool IsExpired() => _lifetime <= 0;
}