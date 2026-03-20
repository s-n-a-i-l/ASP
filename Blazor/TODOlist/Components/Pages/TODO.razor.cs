using TODOlist.Classes;

namespace TODOlist.Components.Pages
{
    public partial class TODO
    {

        List<TODOitem> todos = [];
        string task;
        void AddTask() 
        {
            if (string.IsNullOrWhiteSpace(task)) return;
            if (todos.Contains(new TODOitem { Title = task })) return;
            todos.Add(new TODOitem { Title = task});
            task = "";
            
        }
    }
}
