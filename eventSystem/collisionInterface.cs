public interface collisionInterface(Colllision2D target)
{
    void collisionEnter(Collision2D target);
    void collisionExit(Collision2D target);
    void collisionStay(Collision2D target);
}