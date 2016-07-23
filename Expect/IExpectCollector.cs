using System.Threading.Tasks;

namespace Expect
{
    public interface IExpectCollector
    {
        void CollectExpectSource(IExpectSource expectSource);
        Task StartAsync();
    }
}
