// simplificar el lanzamiento de excepciones
// Ej de lanzamiento Throw.When<CustomException>(condition, message);
public static class Throw
{
    public static void When<T>( bool condition, string message ) where T : Exception, new()
    {
        if( condition )
        {
            var ex = (T) Activator.CreateInstance( typeof( T ), message );
            throw ex;
        }
    }
}
