define("BrowserApi/Geolocation/GeolocationApi", ["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.GeolocationApi = exports.testA = void 0;
    exports.testA = "1";
    var GeolocationApi = /** @class */ (function () {
        function GeolocationApi() {
        }
        return GeolocationApi;
    }());
    exports.GeolocationApi = GeolocationApi;
});
define("BrowserApi/Screen/ScreenApi", ["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ScreenApi = exports.testB = void 0;
    exports.testB = "1";
    var ScreenApi = /** @class */ (function () {
        function ScreenApi() {
        }
        return ScreenApi;
    }());
    exports.ScreenApi = ScreenApi;
});
define("main", ["require", "exports", "BrowserApi/Geolocation/GeolocationApi", "BrowserApi/Screen/ScreenApi"], function (require, exports, GeolocationApi_1, ScreenApi_1) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    console.log(GeolocationApi_1.testA);
    console.log(ScreenApi_1.testB);
    var geo = new GeolocationApi_1.GeolocationApi();
    var screen = new ScreenApi_1.ScreenApi();
});
