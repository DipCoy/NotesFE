using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace NotesFETelegramBot
{
    public interface IBotService
    {
        Task Run();
        void Stop();
    }
}