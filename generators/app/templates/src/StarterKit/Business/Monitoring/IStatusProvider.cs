using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarterKit.Business.Monitoring
{
    public interface IStatusProvider
    {
        Task<Monitoring> GetStatus();
    }
}