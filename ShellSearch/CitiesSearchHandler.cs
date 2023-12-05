namespace ShellSearch;

public class CitiesSearchHandler : SearchHandler
{
    protected override void OnItemSelected(object item)
    {
        base.OnItemSelected(item);

#if IOS
        Command.Execute(null);
#endif
    }
}
