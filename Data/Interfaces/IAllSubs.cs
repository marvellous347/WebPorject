using WebProject.Data.Models;

namespace WebProject.Data.Interfaces
{
    public interface IAllSubs
    {
        IEnumerable<Subscription> AllSubs { get; /*set;*/ }
    }
}
