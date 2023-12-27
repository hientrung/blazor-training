using Microsoft.AspNetCore.Components;

namespace Features.Pages.MVVM
{
    public class BaseClassComponent : ComponentBase
    {
        public int Count = 0;
        public void Inc() => Count++;
    }
}
