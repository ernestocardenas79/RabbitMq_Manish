using MicroRabbit.Mvc.Models.DTO;
using System.Threading.Tasks;

namespace MicroRabbit.Mvc.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transfer);
    }
}
