using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webzor.Core.Helpers;

namespace Webzor.BrowserApi.Core
{
    public abstract  class BaseApi
    {
        protected IJSRuntime JS;

        protected IJSObjectReference module;

        protected bool IsModuleLoaded => module != null;
        protected string ModuleInstanceName { get; private set; }

        public BaseApi(IJSRuntime jsRuntime)
        {
            if (jsRuntime == null)
            {
                throw new ArgumentNullException();
            }

            JS = jsRuntime;
        }

        protected async Task LoadJsModuleAsync(string moduleFileName = "")
        {
            if (string.IsNullOrEmpty(moduleFileName))
            {
                var apiName = this.GetType().Name;
                moduleFileName = $"{apiName.Replace("Api", "")}/{apiName}.js";

                ModuleInstanceName = apiName + "Instance";
            }

            var modulePath = StringHelper.CombinePath(Consts.JsModuleBasePath, moduleFileName);
            module = await JS.InvokeAsync<IJSObjectReference>("import", modulePath);
        }

    }
}
