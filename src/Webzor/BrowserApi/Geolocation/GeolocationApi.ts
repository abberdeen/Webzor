import { BaseApi } from "../Core/BaseApi";
import { ScreenApi } from "../Screen/ScreenApi";

export class GeolocationApi implements BaseApi {

    hello(): void {
        var screenApi = new ScreenApi();
        screenApi.hello();
    }

    say(hola: string, privet: number): void {
        
    }




    dispose(): void {
        throw new Error("Method not implemented.");
    }  
}

export var GeolocationApiInstance = new GeolocationApi();
