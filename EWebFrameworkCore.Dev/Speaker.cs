using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace EWebFrameworkCore.Dev
{
    public class Speaker : ISpeaker
    {
        public string WordGenerated { get; private set; }
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Speaker(IServiceProvider provider)
        {
            _httpContextAccessor = provider.GetService<IHttpContextAccessor>();
            this.WordGenerated = "Word Generated at " + DateTime.Now.ToString();
        }

        public void Speak()
        {
            Console.WriteLine(this.WordGenerated);
        }
    }
}
