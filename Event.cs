using System.Collections;
public delegate void ChangedEventHandler(object sender, EventArgs e);

public class ListChanged : ArrayList{
    public event ChangedEventHandler? changed;

    protected virtual void OnChanged(EventArgs e){
        if(changed != null){
            changed(this, e);
        }
    }

    public override int Add(object? value)
    {
        OnChanged(EventArgs.Empty);
        return base.Add(value);
    }
}

public class Listener{
    public ListChanged list;

    public Listener(ListChanged list){
        this.list = list;
        list.changed += new ChangedEventHandler(list_changed);
    }

    private void list_changed(object sender, EventArgs e){
        Console.WriteLine("Element added");
    }
}