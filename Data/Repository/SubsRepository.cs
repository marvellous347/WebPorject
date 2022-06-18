using WebProject.Data.Interfaces;
using WebProject.Data.Models;

namespace WebProject.Data.Repository
{
    public class SubsRepository : IAllSubs
    {
        private readonly AppDBContent appDBContent;

        public SubsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Subscription> AllSubs => appDBContent.Subscriptions;

    }
}
