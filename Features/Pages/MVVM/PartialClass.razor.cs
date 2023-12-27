
using Microsoft.AspNetCore.Components;

namespace Features.Pages.MVVM
{
    [Route("/mvvm/partial")]
    public partial class PartialClass
    {

        int Count = 0;
        void Inc() => Count++;
    }
}
