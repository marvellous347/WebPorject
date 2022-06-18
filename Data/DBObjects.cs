using WebProject.Data.Models;

namespace WebProject.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Subscriptions.Any())
            {
                content.Subscriptions.AddRange(
                    new Subscription
                    {
                        ServiceImg = "/img/defolt.png",
                        ServiceName = "Defolt",
                        ServicePrice = 1,
                        ServiceReSub = "1th"
                    });
            }

            /*if (content.Subscriptions.Any())
            {
                content.Subscriptions.RemoveRange(

                    new Subscription
                    {
                        id = 10
                    });
            }*/

            content.SaveChanges();
        }
    }
}
