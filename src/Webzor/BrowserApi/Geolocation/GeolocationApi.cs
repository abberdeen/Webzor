using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Webzor.BrowserApi.Core;

namespace Webzor.BrowserApi.Geolocation
{
    public class GeolocationApi : BaseApi
    {
        public GeolocationApi(IJSRuntime jsRuntime) : base(jsRuntime)
        { 
        }

        public async Task<string> GetCurrentLoaction()
        {
            if (!IsModuleLoaded)
            {
                await LoadJsModuleAsync();
            }

            await module.InvokeVoidAsync($"{ModuleInstanceName}.hello");
            return "";
        }
    }
}
