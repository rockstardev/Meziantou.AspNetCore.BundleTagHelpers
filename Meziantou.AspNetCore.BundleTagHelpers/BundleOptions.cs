using Microsoft.AspNetCore.Hosting;

namespace Meziantou.AspNetCore.BundleTagHelpers
{
    public class BundleOptions
    {
        public bool UseMinifiedFiles { get; set; }
        public bool AppendVersion { get; set; }

        internal void Configure(IHostingEnvironment env)
        {
            if (env != null)
            {
                UseMinifiedFiles = !env.IsDevelopment();
                AppendVersion = !env.IsDevelopment();
            }
        }
    }
}