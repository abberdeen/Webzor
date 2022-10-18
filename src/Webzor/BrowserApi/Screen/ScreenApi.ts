import { BaseApi } from "../Core/BaseApi";
import { pi2 } from "../Core/Consts"; 

export class ScreenApi implements BaseApi {

    hello(): void {
        alert('hello from screen api ' + pi2);
    }

    dispose(): void {
        throw new Error("Method not implemented.");
    }
    
}

export var ScreenApiInstance = new ScreenApi();