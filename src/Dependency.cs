namespace ConsoleApp
{
    class Dependency : IDependency
    {
        string IDependency.Foo()
        {
            return $"from {nameof(Dependency)}";
        }
    }
}